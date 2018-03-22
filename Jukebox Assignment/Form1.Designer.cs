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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreTitleBox
            // 
            this.GenreTitleBox.Location = new System.Drawing.Point(272, 214);
            this.GenreTitleBox.Name = "GenreTitleBox";
            this.GenreTitleBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTitleBox.TabIndex = 0;
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.HorizontalScrollbar = true;
            this.GenreListBox.Location = new System.Drawing.Point(251, 240);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.ScrollAlwaysVisible = true;
            this.GenreListBox.Size = new System.Drawing.Size(138, 95);
            this.GenreListBox.TabIndex = 1;
            // 
            // PlaylistListBox
            // 
            this.PlaylistListBox.FormattingEnabled = true;
            this.PlaylistListBox.Location = new System.Drawing.Point(251, 367);
            this.PlaylistListBox.Name = "PlaylistListBox";
            this.PlaylistListBox.Size = new System.Drawing.Size(138, 108);
            this.PlaylistListBox.TabIndex = 2;
            // 
            // PlayNowTextBox
            // 
            this.PlayNowTextBox.Location = new System.Drawing.Point(251, 341);
            this.PlayNowTextBox.Name = "PlayNowTextBox";
            this.PlayNowTextBox.Size = new System.Drawing.Size(138, 20);
            this.PlayNowTextBox.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(204, 162);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(241, 46);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(9, 569);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.MainMenu.Size = new System.Drawing.Size(109, 24);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 602);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PlayNowTextBox);
            this.Controls.Add(this.PlaylistListBox);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.GenreTitleBox);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

