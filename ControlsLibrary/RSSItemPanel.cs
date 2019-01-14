using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ControlsLibrary
{
    /// <summary>
    /// Панель, отображающая RSS-элемент
    /// </summary>
    public partial class RSSItemPanel : UserControl
    {
        /// <summary>
        ///     Скрыта ли панель
        /// </summary>
        private bool _hidden;

        /// <summary>
        ///     Подсвечена ли панель
        /// </summary>
        private bool _highlighted;

        /// <summary>
        ///     Может ли панель быть подсвечена
        /// </summary>
        public bool Highlightable = true;

        /// <summary>
        ///     Обработчик правого клика по всем элементам панели (задается извне)
        /// </summary>
        public MouseEventHandler RightClickHandler = EmptyMouseHandler;

        /// <summary>
        ///     Конструктор панели-заглушки
        /// </summary>
        public RSSItemPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Конструктор панели, содержащей данные
        /// </summary>
        /// <param name="item">Данные RSS-элемента</param>
        /// <param name="rightClickHandler">Обработчик правого клика</param>
        public RSSItemPanel(RSSItemDTO item, MouseEventHandler rightClickHandler)
        {
            InitializeComponent();

            SetData(item);
            RightClickHandler = rightClickHandler;
        }

        /// <summary>
        ///     Данные, отображаемые панелью
        /// </summary>
        public RSSItemDTO Item { get; private set; }

        /// <summary>
        ///     <para>get - возвращает, скрыто ли содержание панели</para>
        ///     <para>set - скрывает все элементы панели</para>
        /// </summary>
        public bool HideContent
        {
            get => _hidden;
            set
            {
                _hidden = value;
                labelChannel.Visible = labelDate.Visible = labelTitle.Visible = !value;
                Enabled = !value;
            }
        }

        /// <summary>
        ///     <para>get - возвращает, раскрашена ли панель</para>
        ///     <para>set - включает/выключает выделение панели цветом</para>
        /// </summary>
        public bool Highlighted
        {
            get => _highlighted;
            set
            {
                if (Highlightable)
                {
                    _highlighted = value;
                    BackColor = _highlighted ? Color.LightSteelBlue : DefaultBackColor;
                }
            }
        }

        /// <summary>
        ///     Задает данные для отображения
        /// </summary>
        /// <param name="item">Данные</param>
        public void SetData(RSSItemDTO item)
        {
            Item = item;
            labelChannel.Text = item.FeedName;
            labelTitle.Text = item.Title;
            labelDate.Text = item.PubDate.ToString("dd.MM.yy\nHH:mm");
        }

        /// <summary>
        ///     Обработчик клика
        /// </summary>
        private void RSSPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Process.Start(Item.Link);
            else if (e.Button == MouseButtons.Right) RightClickHandler(this, e);
        }

        /// <summary>
        ///     Пустой обработчик, необходимый для корректной компиляции
        /// </summary>
        private static void EmptyMouseHandler(object sender, MouseEventArgs e)
        {
        }
    }
}