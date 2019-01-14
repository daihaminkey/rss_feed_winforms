using System.Windows.Forms;

namespace ControlsLibrary
{
    partial class RSSItemDescriptionPanel : UserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отобразитьТегиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rssItemPanel = new ControlsLibrary.RSSItemPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser.Location = new System.Drawing.Point(3, 68);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(398, 324);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьТегиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 26);
            // 
            // отобразитьТегиToolStripMenuItem
            // 
            this.отобразитьТегиToolStripMenuItem.Name = "отобразитьТегиToolStripMenuItem";
            this.отобразитьТегиToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.отобразитьТегиToolStripMenuItem.Text = "Отобразить теги";
            // 
            // rssItemPanel
            // 
            this.rssItemPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rssItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssItemPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rssItemPanel.Enabled = false;
            this.rssItemPanel.HideContent = false;
            this.rssItemPanel.Highlighted = false;
            this.rssItemPanel.Location = new System.Drawing.Point(3, 3);
            this.rssItemPanel.Name = "rssItemPanel";
            this.rssItemPanel.Size = new System.Drawing.Size(398, 59);
            this.rssItemPanel.TabIndex = 3;
            // 
            // RSSItemDescriptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rssItemPanel);
            this.Controls.Add(this.webBrowser);
            this.Name = "RSSItemDescriptionPanel";
            this.Size = new System.Drawing.Size(404, 391);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private RSSItemPanel rssItemPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отобразитьТегиToolStripMenuItem;
    }
}
