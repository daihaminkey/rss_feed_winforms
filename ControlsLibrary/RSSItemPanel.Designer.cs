namespace ControlsLibrary
{
    partial class RSSItemPanel
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(336, 5);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 26);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "18.03.1998\r\n21:37";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RSSPanel_MouseClick);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChannel.Location = new System.Drawing.Point(3, 13);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(30, 13);
            this.labelChannel.TabIndex = 3;
            this.labelChannel.Text = "Habr";
            this.labelChannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RSSPanel_MouseClick);
            // 
            // panelWrapper
            // 
            this.panelWrapper.Controls.Add(this.labelTitle);
            this.panelWrapper.Location = new System.Drawing.Point(6, 13);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(392, 30);
            this.panelWrapper.TabIndex = 4;
            this.panelWrapper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RSSPanel_MouseClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitle.Location = new System.Drawing.Point(0, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(392, 13);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "simple text";
            this.labelTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RSSPanel_MouseClick);
            // 
            // RSSItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panelWrapper);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RSSItemPanel";
            this.Size = new System.Drawing.Size(398, 59);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RSSPanel_MouseClick);
            this.panelWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Label labelTitle;
    }
}
