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
using System.Text.RegularExpressions;

namespace RSS_Feed
{
    public partial class RSSItemDescriptionPanel : UserControl
    {
        private bool _renderHTML = true;
        
        public bool renderHTML
        {
            get => _renderHTML;
            set
            {
                _renderHTML = value;
                FillContent();
            }
        }
        public RSSItemDescriptionPanel()
        {
            InitializeComponent();
        }

        string convertToHTML(string text)
        {
            return Regex.Replace(text, @"(<img src=[^>]+)>", "$1 width=\"345\"  >");
        }

        string convertToPlainText(string text)
        {
            return text.Replace(" width=\"345\"  >", ">").Replace("<", "&lt;").Replace(">", "&gt;");
        }

        void FillContent()
        {
            if(rssItemPanel1.item != null)
                webBrowser1.DocumentText = renderHTML
                    ? convertToHTML(rssItemPanel1.item.Summary.Text)
                    : convertToPlainText(rssItemPanel1.item.Summary.Text);
        }

        public void SetContent(RSSItemPanel panel)
        {
            this.rssItemPanel1.CopyData(panel);
            FillContent();



        }

    }
}
