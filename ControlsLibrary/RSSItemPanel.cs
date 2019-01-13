using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;

namespace RSS_Feed
{
    public partial class RSSItemPanel : UserControl
    {
        string channelName;
        public MouseEventHandler rightClickHandler = new MouseEventHandler(EmptyMouseHandler);
        public SyndicationItem item { get; private set; }
        
        public RSSItemPanel()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public RSSItemPanel(SyndicationItem item, string channelName, MouseEventHandler rightClickHandler)
        {
            InitializeComponent();
            
            this.SetData(item, channelName);
            this.rightClickHandler = rightClickHandler;
        }

        private void SetData(SyndicationItem item, string channelName)
        {
            this.Enabled = true;
            this.item = item;
            this.labelChannel.Text = channelName;
            this.labelTitle.Text = item.Title.Text;
            this.labelDate.Text = item.PublishDate.ToString("dd.MM.yy\nHH:mm");
            this.channelName = channelName;
        }

        public void CopyData(RSSItemPanel panel)
        {
            this.SetData(panel.item, panel.channelName);
        }

        private void RSSPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Click");
            if (e.Button == MouseButtons.Left)
            {
                System.Diagnostics.Process.Start(item.Links.First().Uri.ToString());
            }
            else if(e.Button == MouseButtons.Right)
            {
                rightClickHandler(this, e);
            }
        }

        private static void EmptyMouseHandler(object sender, MouseEventArgs e)
        {

        }
    }
}
