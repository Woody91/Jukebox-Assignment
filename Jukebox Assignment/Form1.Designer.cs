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
            this.GenreListBox = new System.Windows.Forms.TextBox();
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
            this.GenreListBox.Location = new System.Drawing.Point(331, 240);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(100, 20);
            this.GenreListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 720);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.GenreTitleBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenreTitleBox;
        private System.Windows.Forms.TextBox GenreListBox;
    }
}

