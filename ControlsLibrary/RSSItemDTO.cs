using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace RSS_Feed
{
    public class RSSItemDTO
    {
        public string feedName, title, summary, link;
        public DateTimeOffset pubDate;

        public RSSItemDTO(string feedName, SyndicationItem item)
        {
            this.feedName = feedName;
            this.title = item.Title.Text;
            this.summary = item.Summary.Text;
            this.pubDate = item.PublishDate;
            this.link = item.Links.First().Uri.ToString();
        }

        public static RSSItemDTO[] GetItems(SyndicationFeed feed)
        {
            RSSItemDTO[] ret = new RSSItemDTO[feed.Items.Count()];

            int i = 0;
            foreach (var syndicationItem in feed.Items)
            {
                ret[i] = new RSSItemDTO(feed.Title.Text, syndicationItem);
                ++i;
            }

            return ret;
        }
    }
}
