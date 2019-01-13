namespace RSS_Feed
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rssItemDescriptionPanel1 = new RSS_Feed.RSSItemDescriptionPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReload = new System.Windows.Forms.Button();
            this.timerReload = new System.Windows.Forms.Timer(this.components);
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.Controls.Add(this.pictureBox1);
            this.panelList.Location = new System.Drawing.Point(3, 27);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(417, 391);
            this.panelList.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSS_Feed.Properties.Resources.Gear_81;
            this.pictureBox1.Location = new System.Drawing.Point(168, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rssItemDescriptionPanel1
            // 
            this.rssItemDescriptionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssItemDescriptionPanel1.Location = new System.Drawing.Point(426, 27);
            this.rssItemDescriptionPanel1.Name = "rssItemDescriptionPanel1";
            this.rssItemDescriptionPanel1.renderHTML = true;
            this.rssItemDescriptionPanel1.Size = new System.Drawing.Size(409, 391);
            this.rssItemDescriptionPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markdownToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.markdownToolStripMenuItem.Text = "Разметка";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.markdownToolStripMenuItem_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(9, 30);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(405, 61);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Обновить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // timerReload
            // 
            this.timerReload.Enabled = true;
            this.timerReload.Interval = 5000;
            this.timerReload.Tick += new System.EventHandler(this.timerReload_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 418);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.rssItemDescriptionPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RSSItemDescriptionPanel rssItemDescriptionPanel1;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markdownToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Timer timerReload;
    }
}

