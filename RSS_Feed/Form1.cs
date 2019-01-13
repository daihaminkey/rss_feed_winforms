using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace RSS_Feed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MouseEventHandler rightClickHandler = new MouseEventHandler(this.RightClickHandler);

            XmlReaderSettings settings = new XmlReaderSettings() {DtdProcessing = DtdProcessing.Parse };

            string[] urls = new string[]
                {"https://habr.com/rss/interesting/", "https://feeds.podcastmirror.com/zavtracast"};

            List<RSSItemDTO> itemsDTO = new List<RSSItemDTO>();

            foreach (var url in urls)
            {
                XmlReader reader = XmlReader.Create(url, settings);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                itemsDTO.AddRange(RSSItemDTO.GetItems(feed));

            }

            int y = 0;
            foreach (RSSItemDTO item in itemsDTO.OrderByDescending(i => i.pubDate))
            {
                Console.WriteLine(item.feedName+": "+item.title);
                RSSItemPanel itemPanel = new RSSItemPanel(item, rightClickHandler);
                itemPanel.Location = new Point(0, y * (itemPanel.Height + 2));
                panelList.Controls.Add(itemPanel);
                y++;
            }

        }

        RSSItemPanel lastClickedPanel = null;


        private void RightClickHandler(object sender, MouseEventArgs e)
        {
            RSSItemPanel clickedPanel = sender as RSSItemPanel;

            if(!clickedPanel.Equals(lastClickedPanel) && e.Button == MouseButtons.Right)
            {
                
                rssItemDescriptionPanel1.SetContent(clickedPanel);

                clickedPanel.Colored = true;
                if (lastClickedPanel != null)
                    lastClickedPanel.Colored = false;
                lastClickedPanel = clickedPanel;
            }
        }

        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rssItemDescriptionPanel1.renderHTML = !rssItemDescriptionPanel1.renderHTML;
        }
    }
}
