using System;
using System.Linq;
using System.ServiceModel.Syndication;

namespace ControlsLibrary
{
    /// <summary>
    ///     Содержит минимально-необходимые данные об элементе ленты
    /// </summary>
    public class RSSItemDTO
    {
        /// <summary>
        ///     Название ленты, к которой принадлежит элемент
        /// </summary>
        public string FeedName;

        /// <summary>
        ///     Ссылка на полную версию
        /// </summary>
        public string Link;

        /// <summary>
        ///     Дата публикации
        /// </summary>
        public DateTimeOffset PubDate;

        /// <summary>
        ///     Описание
        /// </summary>
        public string Summary;

        /// <summary>
        ///     Название элемента
        /// </summary>
        public string Title;

        /// <summary>
        ///     Конвертирует <see cref="SyndicationItem" /> в DTO
        /// </summary>
        /// <param name="feedName">Название ленты</param>
        /// <param name="item">Элемент</param>
        public RSSItemDTO(string feedName, SyndicationItem item)
        {
            this.FeedName = feedName;
            Title = item.Title.Text;
            Summary = item.Summary.Text;
            PubDate = item.PublishDate;
            Link = item.Links.First().Uri.ToString();
        }

        /// <summary>
        ///     Конвертирует всю ленту в массив DTO
        /// </summary>
        /// <param name="feed">Лента</param>
        /// <returns></returns>
        public static RSSItemDTO[] GetItems(SyndicationFeed feed)
        {
            var ret = new RSSItemDTO[feed.Items.Count()];

            var i = 0;
            foreach (var syndicationItem in feed.Items)
            {
                ret[i] = new RSSItemDTO(feed.Title.Text, syndicationItem);
                ++i;
            }

            return ret;
        }
    }
}