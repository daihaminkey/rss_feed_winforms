using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ControlsLibrary;

namespace RSS_Feed
{
    public partial class FormMain : Form
    {
        /// <summary>
        ///     Жирный шрифт контекстного меню
        /// </summary>
        private readonly Font _boldStripFont;

        /// <summary>
        ///     Конфигурация
        /// </summary>
        private Config config;

        /// <summary>
        ///     Последняя нажатая панель, будет перекрашена при выборе новой
        /// </summary>
        private RSSItemPanel _lastClickedPanel;

        /// <summary>
        ///     Последняя нажатая кнопка меню, будет перекрашена при выборе новой
        /// </summary>
        private ToolStripMenuItem _lastTimeStripClicked;

        /// <summary>
        ///     Обычный шрифт контекстного меню
        /// </summary>
        private readonly Font _regularStripFont;

        public FormMain()
        {
            InitializeComponent();

            _regularStripFont = new Font(toolStripMenuItemFile.Font, FontStyle.Regular);
            _boldStripFont = new Font(_regularStripFont, FontStyle.Bold);

            buttonReload.Visible = false;
        }

        /// <summary>
        ///     Загрузка формы
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupConfig();
            SetupTimer();
            LoadData();
        }


        /// <summary>
        ///     Загрузка конфигурации; настройки, связанные с ней
        /// </summary>
        private void SetupConfig()
        {
            try
            {
                config = Config.Load();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Файл конфигурации не соответствует формату. Использована стандартная конфигурация.",
                    "Ошибка файла конфигуарции");
                config = new Config();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл конфигурации не найден. Создан стандартный файл конфигурации",
                    "Ошибка файла конфигуарции");
                config = new Config();

                try
                {
                    config.Save();
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить файл конфигурации.",
                        "Ошибка файла конфигуарции");
                }
            }

            // Режим отображения
            rssItemDescriptionPanel.RenderHtml = config.RenderHtml;
            markdownToolStripMenuItem.Text = "Разметка: " + (config.RenderHtml ? "HTML" : "текст");

            //Добавление полей в меню настроек
            foreach (var feed in config.Feeds) AddFeedStrip(feed);

            //Подсветка выбранной настройки частоты обновления, если таковая есть
            switch (config.ReloadTimeInMinutes)
            {
                case 1:
                    TimeStripClicked(minuteToolStripMenuItem);
                    break;

                case 3:
                    TimeStripClicked(minute3ToolStripMenuItem);
                    break;

                case 5:
                    TimeStripClicked(minute5ToolStripMenuItem);
                    break;

                case 15:
                    TimeStripClicked(minute15ToolStripMenuItem);
                    break;

                case 30:
                    TimeStripClicked(minute30ToolStripMenuItem);
                    break;

                case 60:
                    TimeStripClicked(minute60ToolStripMenuItem);
                    break;
            }
        }

        /// <summary>
        ///     Добавить в меню ленту
        /// </summary>
        /// <param name="feed"></param>
        private void AddFeedStrip(string feed)
        {
            var toolStrip = new ToolStripMenuItem(feed);
            toolStrip.Click += FeedToolStrip_Click;
            FeedToolStripMenuItem.DropDownItems.Add(toolStrip);
        }

        /// <summary>
        ///     Нажатие на ленту из меню удаляет ее
        /// </summary>
        private void FeedToolStrip_Click(object sender, EventArgs e)
        {
            var clickedStrip = sender as ToolStripItem;
            config.Feeds.Remove(clickedStrip.Text);
            FeedToolStripMenuItem.DropDownItems.Remove(clickedStrip);
            LoadData();
        }

        /// <summary>
        ///     Обновление конфигурации и таймера
        /// </summary>
        /// <param name="minutes"> Новая частота обновления</param>
        private void SetupTimer(int minutes)
        {
            config.ReloadTimeInMinutes = minutes;
            SetupTimer();
        }

        /// <summary>
        ///     Настройка таймера в соответствии с конфигурацией
        /// </summary>
        private void SetupTimer()
        {
            timerReload.Enabled = true;
            timerReload.Interval = config.ReloadTimeInMinutes * 60000;
        }

        /// <summary>
        ///     Загрузка содержимого RSS
        /// </summary>
        /// <param name="urls">Адреса каналов</param>
        /// <returns></returns>
        private List<RSSItemDTO> loadRSS(List<string> urls)
        {
            var settings = new XmlReaderSettings {DtdProcessing = DtdProcessing.Parse};
            var itemsDTO = new List<RSSItemDTO>();

            foreach (var url in urls)
                try
                {
                    using (var reader = XmlReader.Create(url, settings))
                    {
                        var feed = SyndicationFeed.Load(reader);
                        itemsDTO.AddRange(RSSItemDTO.GetItems(feed));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"При чтении ленты {url} произошла ошибка: {e.Message}", "Ошибка");
                }

            return itemsDTO;
        }

        /// <summary>
        ///     Загрузка и обновление списка RSS-элементов
        /// </summary>
        private void LoadData()
        {
            panelList.Controls.Clear();
            if (config.Feeds?.Count > 0)
            {
                // Анимация загрузки
                pictureBoxLoading.Visible = true;


                var rightClickHandler = new MouseEventHandler(RightClickHandler);

                // Данные грузятся в отдельном потоке
                var itemsDTOTask = Task.Run(() => loadRSS(config.Feeds));

                var itemsDTO = itemsDTOTask.Result;
                //К огда данные загрузились, выключаем анимацию загрузки
                pictureBoxLoading.Visible = false;


                if (itemsDTO?.Count > 0)
                {
                    buttonReload.Visible = false;

                    // Добавляем панели на каждый элемент данных
                    var y = 0;
                    foreach (var item in itemsDTO.OrderByDescending(i => i.PubDate))
                    {
                        var itemPanel = new RSSItemPanel(item, rightClickHandler);
                        itemPanel.Location = new Point(0, y * (itemPanel.Height + 2));
                        panelList.Controls.Add(itemPanel);
                        y++;
                    }
                }
                else
                {
                    buttonReload.Visible = true;
                }
            }
            else
            {
                buttonReload.Visible = true;
                pictureBoxLoading.Visible = false;
                MessageBox.Show("Добавьте ленты в настройках", "Отсутствуют ленты для загрузки");
            }
        }



        /// <summary>
        ///     <para>Обработчик правого клика по панелям, задается при их инициализации</para>
        ///     <para>Переносит данные из нажатой панели в <see cref="RSSItemDescriptionPanel" />, перекрашивает панели</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightClickHandler(object sender, MouseEventArgs e)
        {
            var clickedPanel = sender as RSSItemPanel;

            if (!clickedPanel.Equals(_lastClickedPanel) && e.Button == MouseButtons.Right)
            {
                rssItemDescriptionPanel.SetContent(clickedPanel.Item);

                clickedPanel.Highlighted = true;
                if (_lastClickedPanel != null)
                    _lastClickedPanel.Highlighted = false;
                _lastClickedPanel = clickedPanel;
            }
        }

        /// <summary>
        ///     Выбор режима рендеринга
        /// </summary>
        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rssItemDescriptionPanel.RenderHtml = !rssItemDescriptionPanel.RenderHtml;
            config.RenderHtml = rssItemDescriptionPanel.RenderHtml;

            markdownToolStripMenuItem.Text = "Разметка: " + (config.RenderHtml ? "HTML" : "текст");
        }

        /// <summary>
        ///     Перезагрузка списка по таймеру
        /// </summary>
        private void timerReload_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        ///     Нажатие на кнопку "обновить"
        /// </summary>
        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        ///     Нажатие на кнопку "выход"
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Сохранение конфигурации при закрытии формы
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                config.Save();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить текущую конфигурацию", "Ошибка сохранения конфигурации");
            }
        }

        /// <summary>
        ///     Добавление новой RSS-ленты из меню
        /// </summary>
        private void toolStripTextBoxAddFeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {
                    if (config.AddFeed(toolStripTextBoxAddFeed.Text))
                    {
                        AddFeedStrip(toolStripTextBoxAddFeed.Text);

                        LoadData();
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Адрес {toolStripTextBoxAddFeed.Text} имеет неверный формат",
                        "Ошибка добавления ленты");
                }
                finally
                {
                    toolStripTextBoxAddFeed.Text = "";
                }
        }


        /// <summary>
        ///     Нажатие на один из вариантов частоты обновления
        /// </summary>
        private void TimeStripClicked(ToolStripMenuItem strip)
        {
            if (_lastTimeStripClicked != null) _lastTimeStripClicked.Font = _regularStripFont;
            _lastTimeStripClicked = strip;
            _lastTimeStripClicked.Font = _boldStripFont;
        }


        /// <summary>
        ///     Частота - 1 минута
        /// </summary>
        private void MinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupTimer(1);
            TimeStripClicked(sender as ToolStripMenuItem);
        }

        /// <summary>
        ///     Частота - 3 минуты
        /// </summary>
        private void minute3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupTimer(3);
            TimeStripClicked(sender as ToolStripMenuItem);
        }

        /// <summary>
        ///     Частота - 5 минут
        /// </summary>
        private void minute5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupTimer(5);
            TimeStripClicked(sender as ToolStripMenuItem);
        }

        /// <summary>
        ///     Частота - 15 минут
        /// </summary>
        private void minute15ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetupTimer(15);
            TimeStripClicked(sender as ToolStripMenuItem);
        }

        /// <summary>
        ///     Частота - 30 минут
        /// </summary>
        private void minute30ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetupTimer(30);
            TimeStripClicked(sender as ToolStripMenuItem);
        }

        /// <summary>
        ///     Частота - 60 минут
        /// </summary>
        private void minute60ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetupTimer(60);
            TimeStripClicked(sender as ToolStripMenuItem);
        }
    }
}