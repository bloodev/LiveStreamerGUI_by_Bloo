namespace LiveStreamerGUI_by_Bloo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RecordButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livestreamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoConfifFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileInputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VisualCommand = new System.Windows.Forms.RichTextBox();
            this.watchButton = new System.Windows.Forms.Button();
            this.QualityInputBox = new System.Windows.Forms.ComboBox();
            this.ChannelInputBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordButton
            // 
            this.RecordButton.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordButton.Location = new System.Drawing.Point(230, 150);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(74, 22);
            this.RecordButton.TabIndex = 4;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(27, 27);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.livestreamerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // livestreamerToolStripMenuItem
            // 
            this.livestreamerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.editConfigFileToolStripMenuItem,
            this.demoConfifFileToolStripMenuItem});
            this.livestreamerToolStripMenuItem.Name = "livestreamerToolStripMenuItem";
            this.livestreamerToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.livestreamerToolStripMenuItem.Text = "Streamlink";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.downloadToolStripMenuItem.Text = "Download Streamlink";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // editConfigFileToolStripMenuItem
            // 
            this.editConfigFileToolStripMenuItem.Name = "editConfigFileToolStripMenuItem";
            this.editConfigFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editConfigFileToolStripMenuItem.Text = "Edit SL config file";
            this.editConfigFileToolStripMenuItem.Click += new System.EventHandler(this.editConfigFileToolStripMenuItem_Click);
            // 
            // demoConfifFileToolStripMenuItem
            // 
            this.demoConfifFileToolStripMenuItem.Name = "demoConfifFileToolStripMenuItem";
            this.demoConfifFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.demoConfifFileToolStripMenuItem.Text = "Example SL config file";
            this.demoConfifFileToolStripMenuItem.Click += new System.EventHandler(this.demoConfifFileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "File";
            // 
            // FileInputBox
            // 
            this.FileInputBox.Font = new System.Drawing.Font("Arial", 8.834356F);
            this.FileInputBox.Location = new System.Drawing.Point(42, 51);
            this.FileInputBox.Name = "FileInputBox";
            this.FileInputBox.Size = new System.Drawing.Size(180, 21);
            this.FileInputBox.TabIndex = 3;
            this.FileInputBox.TextChanged += new System.EventHandler(this.FileInputBox_TextChanged);
            this.FileInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileInputBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command to be executed:";
            // 
            // VisualCommand
            // 
            this.VisualCommand.Font = new System.Drawing.Font("Arial", 8.834356F);
            this.VisualCommand.Location = new System.Drawing.Point(12, 88);
            this.VisualCommand.Name = "VisualCommand";
            this.VisualCommand.ReadOnly = true;
            this.VisualCommand.Size = new System.Drawing.Size(339, 56);
            this.VisualCommand.TabIndex = 6;
            this.VisualCommand.Text = "";
            // 
            // watchButton
            // 
            this.watchButton.Font = new System.Drawing.Font("Arial", 8.834356F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchButton.Location = new System.Drawing.Point(73, 150);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(74, 22);
            this.watchButton.TabIndex = 5;
            this.watchButton.Text = "Watch";
            this.watchButton.UseCompatibleTextRendering = true;
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.WatchBtn_Click);
            // 
            // QualityInputBox
            // 
            this.QualityInputBox.Font = new System.Drawing.Font("Arial", 8.834356F);
            this.QualityInputBox.FormattingEnabled = true;
            this.QualityInputBox.Items.AddRange(new object[] {
            "best",
            "1080p60",
            "720p60",
            "720p30",
            "540p30",
            "480p30",
            "360p30",
            "240p30",
            "144p30",
            "audio"});
            this.QualityInputBox.Location = new System.Drawing.Point(277, 51);
            this.QualityInputBox.Name = "QualityInputBox";
            this.QualityInputBox.Size = new System.Drawing.Size(73, 23);
            this.QualityInputBox.TabIndex = 2;
            this.QualityInputBox.SelectedIndexChanged += new System.EventHandler(this.QualityInputBox_SelectedIndexChanged);
            this.QualityInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QualityInputBox_KeyPress);
            // 
            // ChannelInputBox
            // 
            this.ChannelInputBox.Font = new System.Drawing.Font("Arial", 8.834356F);
            this.ChannelInputBox.FormattingEnabled = true;
            this.ChannelInputBox.Location = new System.Drawing.Point(42, 22);
            this.ChannelInputBox.Name = "ChannelInputBox";
            this.ChannelInputBox.Size = new System.Drawing.Size(306, 23);
            this.ChannelInputBox.TabIndex = 1;
            this.ChannelInputBox.TextUpdate += new System.EventHandler(this.ChannelInputBox_TextUpdate);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.ChannelInputBox);
            this.Controls.Add(this.QualityInputBox);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.VisualCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileInputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(375, 220);
            this.MinimumSize = new System.Drawing.Size(375, 220);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streamlink GUI (Bloo 0.2 BETA)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livestreamerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoConfifFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileInputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox VisualCommand;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.ComboBox QualityInputBox;
        private System.Windows.Forms.ComboBox ChannelInputBox;
    }
}

