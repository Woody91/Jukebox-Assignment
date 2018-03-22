namespace Jukebox_Assignment
{
    partial class Setup
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.TrackImpBox = new System.Windows.Forms.ListBox();
            this.PresGenTrackBox = new System.Windows.Forms.ListBox();
            this.ImpTraDirBut = new System.Windows.Forms.Button();
            this.ClrImpTraBut = new System.Windows.Forms.Button();
            this.CopTrackBut = new System.Windows.Forms.Button();
            this.MoveTrackBut = new System.Windows.Forms.Button();
            this.DelTrackGenBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.PrevBut = new System.Windows.Forms.Button();
            this.NextBut = new System.Windows.Forms.Button();
            this.OkBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // TrackImpBox
            // 
            this.TrackImpBox.FormattingEnabled = true;
            this.TrackImpBox.Location = new System.Drawing.Point(18, 25);
            this.TrackImpBox.Name = "TrackImpBox";
            this.TrackImpBox.Size = new System.Drawing.Size(200, 199);
            this.TrackImpBox.TabIndex = 0;
            // 
            // PresGenTrackBox
            // 
            this.PresGenTrackBox.FormattingEnabled = true;
            this.PresGenTrackBox.Location = new System.Drawing.Point(14, 69);
            this.PresGenTrackBox.Name = "PresGenTrackBox";
            this.PresGenTrackBox.Size = new System.Drawing.Size(219, 160);
            this.PresGenTrackBox.TabIndex = 1;
            // 
            // ImpTraDirBut
            // 
            this.ImpTraDirBut.Location = new System.Drawing.Point(18, 230);
            this.ImpTraDirBut.Name = "ImpTraDirBut";
            this.ImpTraDirBut.Size = new System.Drawing.Size(200, 31);
            this.ImpTraDirBut.TabIndex = 2;
            this.ImpTraDirBut.Text = "Import Tracks From Directory";
            this.ImpTraDirBut.UseVisualStyleBackColor = true;
            // 
            // ClrImpTraBut
            // 
            this.ClrImpTraBut.Location = new System.Drawing.Point(18, 267);
            this.ClrImpTraBut.Name = "ClrImpTraBut";
            this.ClrImpTraBut.Size = new System.Drawing.Size(200, 30);
            this.ClrImpTraBut.TabIndex = 3;
            this.ClrImpTraBut.Text = "Clear Imported Tracks";
            this.ClrImpTraBut.UseVisualStyleBackColor = true;
            // 
            // CopTrackBut
            // 
            this.CopTrackBut.Location = new System.Drawing.Point(252, 87);
            this.CopTrackBut.Name = "CopTrackBut";
            this.CopTrackBut.Size = new System.Drawing.Size(105, 23);
            this.CopTrackBut.TabIndex = 4;
            this.CopTrackBut.Text = "Copy Track >>";
            this.CopTrackBut.UseVisualStyleBackColor = true;
            // 
            // MoveTrackBut
            // 
            this.MoveTrackBut.Location = new System.Drawing.Point(251, 116);
            this.MoveTrackBut.Name = "MoveTrackBut";
            this.MoveTrackBut.Size = new System.Drawing.Size(105, 23);
            this.MoveTrackBut.TabIndex = 5;
            this.MoveTrackBut.Text = "Move Track >>";
            this.MoveTrackBut.UseVisualStyleBackColor = true;
            // 
            // DelTrackGenBut
            // 
            this.DelTrackGenBut.Location = new System.Drawing.Point(266, 188);
            this.DelTrackGenBut.Name = "DelTrackGenBut";
            this.DelTrackGenBut.Size = new System.Drawing.Size(75, 70);
            this.DelTrackGenBut.TabIndex = 6;
            this.DelTrackGenBut.Text = "Delete Track From Genre";
            this.DelTrackGenBut.UseVisualStyleBackColor = true;
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(94, 234);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 8;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(94, 263);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(75, 23);
            this.DelBut.TabIndex = 9;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = true;
            // 
            // PrevBut
            // 
            this.PrevBut.Location = new System.Drawing.Point(14, 250);
            this.PrevBut.Name = "PrevBut";
            this.PrevBut.Size = new System.Drawing.Size(75, 23);
            this.PrevBut.TabIndex = 10;
            this.PrevBut.Text = "<< Previous";
            this.PrevBut.UseVisualStyleBackColor = true;
            // 
            // NextBut
            // 
            this.NextBut.Location = new System.Drawing.Point(175, 250);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(75, 23);
            this.NextBut.TabIndex = 11;
            this.NextBut.Text = "Next >>";
            this.NextBut.UseVisualStyleBackColor = true;
            // 
            // OkBut
            // 
            this.OkBut.Location = new System.Drawing.Point(456, 375);
            this.OkBut.Name = "OkBut";
            this.OkBut.Size = new System.Drawing.Size(75, 23);
            this.OkBut.TabIndex = 12;
            this.OkBut.Text = "OK";
            this.OkBut.UseVisualStyleBackColor = true;
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(537, 375);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 13;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrackImpBox);
            this.groupBox1.Controls.Add(this.ImpTraDirBut);
            this.groupBox1.Controls.Add(this.ClrImpTraBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 309);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Tracks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.PresGenTrackBox);
            this.groupBox2.Controls.Add(this.AddBut);
            this.groupBox2.Controls.Add(this.DelBut);
            this.groupBox2.Controls.Add(this.PrevBut);
            this.groupBox2.Controls.Add(this.NextBut);
            this.groupBox2.Location = new System.Drawing.Point(362, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 297);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Genre Title";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.OkBut);
            this.Controls.Add(this.DelTrackGenBut);
            this.Controls.Add(this.MoveTrackBut);
            this.Controls.Add(this.CopTrackBut);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox PresGenTrackBox;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Button PrevBut;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TrackImpBox;
        private System.Windows.Forms.Button ImpTraDirBut;
        private System.Windows.Forms.Button ClrImpTraBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button OkBut;
        private System.Windows.Forms.Button DelTrackGenBut;
        private System.Windows.Forms.Button MoveTrackBut;
        private System.Windows.Forms.Button CopTrackBut;
    }
}