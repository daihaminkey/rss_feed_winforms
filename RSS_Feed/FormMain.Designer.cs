namespace RSS_Feed
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelList = new System.Windows.Forms.Panel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minute3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minute5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minute15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minute30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minute60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxAddFeed = new System.Windows.Forms.ToolStripTextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.timerReload = new System.Windows.Forms.Timer(this.components);
            this.rssItemDescriptionPanel = new ControlsLibrary.RSSItemDescriptionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.AutoScroll = true;
            this.panelList.Location = new System.Drawing.Point(3, 27);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(417, 391);
            this.panelList.TabIndex = 1;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::RSS_Feed.Properties.Resources.loading_gif;
            this.pictureBoxLoading.Location = new System.Drawing.Point(170, 175);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoading.TabIndex = 0;
            this.pictureBoxLoading.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.SetupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SetupToolStripMenuItem
            // 
            this.SetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markdownToolStripMenuItem,
            this.FreqToolStripMenuItem,
            this.FeedToolStripMenuItem});
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            this.SetupToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SetupToolStripMenuItem.Text = "Настройки";
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.markdownToolStripMenuItem.Text = "Разметка";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.markdownToolStripMenuItem_Click);
            // 
            // FreqToolStripMenuItem
            // 
            this.FreqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minuteToolStripMenuItem,
            this.minute3ToolStripMenuItem,
            this.minute5ToolStripMenuItem,
            this.minute15ToolStripMenuItem,
            this.minute30ToolStripMenuItem,
            this.minute60ToolStripMenuItem});
            this.FreqToolStripMenuItem.Name = "FreqToolStripMenuItem";
            this.FreqToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.FreqToolStripMenuItem.Text = "Частота обновления";
            // 
            // minuteToolStripMenuItem
            // 
            this.minuteToolStripMenuItem.Name = "minuteToolStripMenuItem";
            this.minuteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minuteToolStripMenuItem.Text = "1 минута";
            this.minuteToolStripMenuItem.Click += new System.EventHandler(this.MinuteToolStripMenuItem_Click);
            // 
            // minute3ToolStripMenuItem
            // 
            this.minute3ToolStripMenuItem.Name = "minute3ToolStripMenuItem";
            this.minute3ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minute3ToolStripMenuItem.Text = "3 минуты";
            this.minute3ToolStripMenuItem.Click += new System.EventHandler(this.minute3ToolStripMenuItem_Click);
            // 
            // minute5ToolStripMenuItem
            // 
            this.minute5ToolStripMenuItem.Name = "minute5ToolStripMenuItem";
            this.minute5ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minute5ToolStripMenuItem.Text = "5 минут";
            this.minute5ToolStripMenuItem.Click += new System.EventHandler(this.minute5ToolStripMenuItem_Click);
            // 
            // minute15ToolStripMenuItem
            // 
            this.minute15ToolStripMenuItem.Name = "minute15ToolStripMenuItem";
            this.minute15ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minute15ToolStripMenuItem.Text = "15 минут";
            this.minute15ToolStripMenuItem.Click += new System.EventHandler(this.minute15ToolStripMenuItem1_Click);
            // 
            // minute30ToolStripMenuItem
            // 
            this.minute30ToolStripMenuItem.Name = "minute30ToolStripMenuItem";
            this.minute30ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minute30ToolStripMenuItem.Text = "30 минут";
            this.minute30ToolStripMenuItem.Click += new System.EventHandler(this.minute30ToolStripMenuItem2_Click);
            // 
            // minute60ToolStripMenuItem
            // 
            this.minute60ToolStripMenuItem.Name = "minute60ToolStripMenuItem";
            this.minute60ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minute60ToolStripMenuItem.Text = "60 минут";
            this.minute60ToolStripMenuItem.Click += new System.EventHandler(this.minute60ToolStripMenuItem3_Click);
            // 
            // FeedToolStripMenuItem
            // 
            this.FeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem});
            this.FeedToolStripMenuItem.Name = "FeedToolStripMenuItem";
            this.FeedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.FeedToolStripMenuItem.Text = "Управление лентами";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxAddFeed});
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.AddToolStripMenuItem.Text = "Добавить...";
            // 
            // toolStripTextBoxAddFeed
            // 
            this.toolStripTextBoxAddFeed.Name = "toolStripTextBoxAddFeed";
            this.toolStripTextBoxAddFeed.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxAddFeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxAddFeed_KeyDown);
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
            this.timerReload.Interval = 50000;
            this.timerReload.Tick += new System.EventHandler(this.timerReload_Tick);
            // 
            // rssItemDescriptionPanel
            // 
            this.rssItemDescriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssItemDescriptionPanel.Location = new System.Drawing.Point(426, 27);
            this.rssItemDescriptionPanel.Name = "rssItemDescriptionPanel";
            this.rssItemDescriptionPanel.RenderHtml = true;
            this.rssItemDescriptionPanel.Size = new System.Drawing.Size(409, 391);
            this.rssItemDescriptionPanel.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 418);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.rssItemDescriptionPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "RSS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLibrary.RSSItemDescriptionPanel rssItemDescriptionPanel;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markdownToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Timer timerReload;
        private System.Windows.Forms.ToolStripMenuItem FreqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minute3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minute5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minute15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minute30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minute60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAddFeed;
    }
}

