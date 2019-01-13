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
        private bool firstLinkHandled = false;
        
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
            rssItemPanel1.colorable = false;
            rssItemPanel1.HideContent = true;
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
            firstLinkHandled = false;
            if (rssItemPanel1.HideContent)
                rssItemPanel1.HideContent = false;
            FillContent();



        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Console.WriteLine("Навигация пошла");
            if (firstLinkHandled)
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true; 
            }
            else
                firstLinkHandled = true;
        }
    }
}
