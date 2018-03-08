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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreTitleBox
            // 
            this.GenreTitleBox.Location = new System.Drawing.Point(331, 213);
            this.GenreTitleBox.Name = "GenreTitleBox";
            this.GenreTitleBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTitleBox.TabIndex = 0;
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.HorizontalScrollbar = true;
            this.GenreListBox.Location = new System.Drawing.Point(312, 240);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.ScrollAlwaysVisible = true;
            this.GenreListBox.Size = new System.Drawing.Size(138, 95);
            this.GenreListBox.TabIndex = 1;
            // 
            // PlaylistListBox
            // 
            this.PlaylistListBox.FormattingEnabled = true;
            this.PlaylistListBox.Location = new System.Drawing.Point(312, 386);
            this.PlaylistListBox.Name = "PlaylistListBox";
            this.PlaylistListBox.Size = new System.Drawing.Size(138, 134);
            this.PlaylistListBox.TabIndex = 2;
            // 
            // PlayNowTextBox
            // 
            this.PlayNowTextBox.Location = new System.Drawing.Point(312, 342);
            this.PlayNowTextBox.Name = "PlayNowTextBox";
            this.PlayNowTextBox.Size = new System.Drawing.Size(138, 20);
            this.PlayNowTextBox.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(261, 152);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(241, 46);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 720);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PlayNowTextBox);
            this.Controls.Add(this.PlaylistListBox);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.GenreTitleBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenreTitleBox;
        private System.Windows.Forms.ListBox GenreListBox;
        private System.Windows.Forms.ListBox PlaylistListBox;
        private System.Windows.Forms.TextBox PlayNowTextBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

