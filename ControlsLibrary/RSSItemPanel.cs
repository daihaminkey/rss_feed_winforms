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

        private bool _hidden = false;
        private bool _colored = false;
        public bool colorable = true;

        public MouseEventHandler rightClickHandler = new MouseEventHandler(EmptyMouseHandler);
        public RSSItemDTO item { get; private set; }

        public bool HideContent
        {
            get => _hidden;
            set
            {
                _hidden = value;
                this.labelChannel.Visible = this.labelDate.Visible = this.labelTitle.Visible = !value;
                this.Enabled = !value;
            }
        }

        public bool Colored
        {
            get => _colored;
            set
            {
                if (colorable)
                {
                    _colored = value;
                    this.BackColor = _colored ? Color.LightSteelBlue : Control.DefaultBackColor;
                }
            }
        }

        public RSSItemPanel()
        {
            InitializeComponent();
        }

        public RSSItemPanel(RSSItemDTO item, MouseEventHandler rightClickHandler)
        {
            InitializeComponent();
            
            this.SetData(item);
            this.rightClickHandler = rightClickHandler;
        }

        

        public void SetData(RSSItemDTO item)
        {
            this.item = item;
            this.labelChannel.Text = item.feedName;
            this.labelTitle.Text = item.title;
            this.labelDate.Text = item.pubDate.ToString("dd.MM.yy\nHH:mm");
        }


        private void RSSPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Diagnostics.Process.Start(item.link);
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
