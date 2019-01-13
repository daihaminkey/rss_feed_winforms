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
            XmlReaderSettings settings = new XmlReaderSettings() {DtdProcessing = DtdProcessing.Parse };
            

            string url = "https://habr.com/rss/interesting/";
            XmlReader reader = XmlReader.Create(url, settings);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            MouseEventHandler rightClickHandler = new MouseEventHandler(this.RightClickHandler);

            int y = 0;
            foreach (SyndicationItem item in feed.Items)
            {
                RSSItemPanel itemPanel = new RSSItemPanel(item, feed.Title.Text, rightClickHandler);
                itemPanel.Location = new Point(0, y*(itemPanel.Height+2));
                panelList.Controls.Add(itemPanel);
                y++;
            }
            

            

        }

        private void RightClickHandler(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                rssItemDescriptionPanel1.SetContent(sender as RSSItemPanel);
            }
        }

        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rssItemDescriptionPanel1.renderHTML = !rssItemDescriptionPanel1.renderHTML;
        }
    }
}
