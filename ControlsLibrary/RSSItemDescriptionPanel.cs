using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ControlsLibrary
{
    /// <summary>
    ///     Панель, отображающая краткое и подробное содержание RSS-элемента
    ///     Содержит <see cref="RSSItemPanel" /> и Summary
    /// </summary>
    public partial class RSSItemDescriptionPanel
    {
        /// <summary>
        ///     <para>Флаг, обработана ли первая ссылка</para>
        ///     <para><see cref="WebBrowser" />'у нельзя разрешать обработку ссылок, кроме первой</para>
        ///     <para>Первая - это загрузка Summary обрабатываемого RSS</para>
        ///     <para>Все остальные - это href, на которые можно кликнуть в Summary</para>
        ///     <para>Они ведут в веб, там js, <see cref="WebBrowser" /> не умеет с ним работать</para>
        ///     <para>Поэтому мы ограничиваем обработку всех ссылок, кроме первой</para>
        /// </summary>
        private bool _firstLinkHandled;

        /// <summary>
        ///     <para>Режим рендеринга содержимого:</para>
        ///     <para>true - HTML</para>
        ///     <para>false - plain text</para>
        /// </summary>
        private bool _renderHtml = true;

        /// <summary>
        ///     Стандартный конструктор. Содержимое скрыто, подсветка отключена
        /// </summary>
        public RSSItemDescriptionPanel()
        {
            InitializeComponent();
            rssItemPanel.Highlightable = false;
            rssItemPanel.HideContent = true;
        }

        /// <summary>
        ///     <para>get - возвращает режим рендеринга <see cref="_renderHtml" /></para>
        ///     <para>set - задает режим рендеринга и соответствующим образом обновляет контент</para>
        /// </summary>
        public bool RenderHtml
        {
            get => _renderHtml;
            set
            {
                _renderHtml = value;
                FillContent();
            }
        }

        /// <summary>
        ///     Обрабатывает все изображения html, чтобы они влезали в окно
        /// </summary>
        /// <param name="text">html-код</param>
        /// <returns></returns>
        private string convertToHTML(string text)
        {
            return Regex.Replace(text, @"(<img src=[^>]+)>", "$1 width=\"345\"  >");
        }

        /// <summary>
        ///     Меняет все тэги html на &lt; &gt;, чтобы они отображались, как текст
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string convertToPlainText(string text)
        {
            return text.Replace("<", "&lt;").Replace(">", "&gt;");
        }

        /// <summary>
        ///     В зависимости от режима рендеринга отображает html или plain text
        /// </summary>
        private void FillContent()
        {
            _firstLinkHandled = false;
            if (rssItemPanel.Item != null)
                webBrowser.DocumentText = RenderHtml
                    ? convertToHTML(rssItemPanel.Item.Summary)
                    : convertToPlainText(rssItemPanel.Item.Summary);
        }

        /// <summary>
        ///     Задает отображаемые данные
        /// </summary>
        /// <param name="dto">Данные</param>
        public void SetContent(RSSItemDTO dto)
        {
            rssItemPanel.SetData(dto);
            _firstLinkHandled = false;
            if (rssItemPanel.HideContent)
                rssItemPanel.HideContent = false;
            FillContent();
        }

        /// <summary>
        ///     <para>Обработчик, перехватывающий ссылки</para>
        ///     <para>Первая ссылка (ведущая на содержимое) отображается в программе</para>
        ///     <para>Остальные обрабатываются в браузере пользователя</para>
        ///     <para>см. <see cref="_firstLinkHandled" /></para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (_firstLinkHandled)
            {
                Process.Start(e.Url.ToString());
                e.Cancel = true;
            }
            else
            {
                _firstLinkHandled = true;
            }
        }
    }
}