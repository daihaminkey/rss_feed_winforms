namespace RSS_Feed
{
    partial class RSSItemDescriptionPanel
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.rssItemPanel1 = new RSS_Feed.RSSItemPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отобразитьТегиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Location = new System.Drawing.Point(3, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(398, 324);
            this.webBrowser1.TabIndex = 1;
            // 
            // rssItemPanel1
            // 
            this.rssItemPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssItemPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rssItemPanel1.Enabled = false;
            this.rssItemPanel1.Location = new System.Drawing.Point(3, 3);
            this.rssItemPanel1.Name = "rssItemPanel1";
            this.rssItemPanel1.Size = new System.Drawing.Size(398, 59);
            this.rssItemPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьТегиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // отобразитьТегиToolStripMenuItem
            // 
            this.отобразитьТегиToolStripMenuItem.Name = "отобразитьТегиToolStripMenuItem";
            this.отобразитьТегиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отобразитьТегиToolStripMenuItem.Text = "Отобразить теги";
            // 
            // RSSItemDescriptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rssItemPanel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "RSSItemDescriptionPanel";
            this.Size = new System.Drawing.Size(404, 391);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private RSSItemPanel rssItemPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отобразитьТегиToolStripMenuItem;
    }
}
