namespace Jukebox_Assignment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GenreTitleBox = new System.Windows.Forms.TextBox();
            this.GenreListBox = new System.Windows.Forms.ListBox();
            this.PlaylistListBox = new System.Windows.Forms.ListBox();
            this.PlayNowTextBox = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreTitleBox
            // 
            this.GenreTitleBox.Location = new System.Drawing.Point(335, 263);
            this.GenreTitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTitleBox.Name = "GenreTitleBox";
            this.GenreTitleBox.Size = new System.Drawing.Size(183, 22);
            this.GenreTitleBox.TabIndex = 0;
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.ItemHeight = 16;
            this.GenreListBox.Location = new System.Drawing.Point(335, 295);
            this.GenreListBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.ScrollAlwaysVisible = true;
            this.GenreListBox.Size = new System.Drawing.Size(183, 100);
            this.GenreListBox.TabIndex = 1;
            this.GenreListBox.SelectedIndexChanged += new System.EventHandler(this.GenreListBox_SelectedIndexChanged);
            this.GenreListBox.DoubleClick += new System.EventHandler(this.Selecttrack);
            // 
            // PlaylistListBox
            // 
            this.PlaylistListBox.FormattingEnabled = true;
            this.PlaylistListBox.ItemHeight = 16;
            this.PlaylistListBox.Location = new System.Drawing.Point(335, 452);
            this.PlaylistListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlaylistListBox.Name = "PlaylistListBox";
            this.PlaylistListBox.Size = new System.Drawing.Size(183, 132);
            this.PlaylistListBox.TabIndex = 2;
            // 
            // PlayNowTextBox
            // 
            this.PlayNowTextBox.Location = new System.Drawing.Point(335, 420);
            this.PlayNowTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayNowTextBox.Name = "PlayNowTextBox";
            this.PlayNowTextBox.Size = new System.Drawing.Size(183, 22);
            this.PlayNowTextBox.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(308, 209);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(241, 46);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(12, 704);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.MainMenu.Size = new System.Drawing.Size(131, 26);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(335, 395);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(184, 17);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copyright 2018, Mr Adam Woodliffe.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tracks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Now Playing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "In Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 741);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PlayNowTextBox);
            this.Controls.Add(this.PlaylistListBox);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.GenreTitleBox);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Jukebox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenreTitleBox;
        private System.Windows.Forms.ListBox GenreListBox;
        private System.Windows.Forms.ListBox PlaylistListBox;
        private System.Windows.Forms.TextBox PlayNowTextBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

