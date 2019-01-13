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
using System.Windows.Forms.VisualStyles;

namespace RSS_Feed
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            buttonReload.Visible = false;
        }

        List<RSSItemDTO> loadRSS(string[] urls)
        {
            Console.WriteLine("In task start");
            XmlReaderSettings settings = new XmlReaderSettings() { DtdProcessing = DtdProcessing.Parse };
            List<RSSItemDTO> itemsDTO = new List<RSSItemDTO>();

            foreach (var url in urls)
            {
                try
                {
                    using (var reader = XmlReader.Create(url, settings))
                    {
                        SyndicationFeed feed = SyndicationFeed.Load(reader);
                        itemsDTO.AddRange(RSSItemDTO.GetItems(feed));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"При чтении ленты {url} произошла ошибка: {e.Message}", "Ошибка");
                }
                
            }
            Console.WriteLine("In task finish");
            return itemsDTO;
        }

        void LoadData()
        {
            pictureBox1.Visible = true;
            panelList.Controls.Clear();
            
            MouseEventHandler rightClickHandler = new MouseEventHandler(this.RightClickHandler);

            string[] urls = new string[]
                {"https://habr.com/rss/interesting7/", "https://feeds.podcastmirror.com/zavtracast7"};

            var itemsDTOTask = Task.Run(() => loadRSS(urls));

            var itemsDTO = itemsDTOTask.Result;
            pictureBox1.Visible = false;


            if (itemsDTO?.Count > 0)
            {
                buttonReload.Visible = false;
                int y = 0;
                foreach (RSSItemDTO item in itemsDTO.OrderByDescending(i => i.pubDate))
                {
                    RSSItemPanel itemPanel = new RSSItemPanel(item, rightClickHandler);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
