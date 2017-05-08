namespace MoviesConverter
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
            this.SelectInputFileBtn = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SaveFileTB = new System.Windows.Forms.TextBox();
            this.SelectOutputFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.ImageFlowTB = new System.Windows.Forms.TextBox();
            this.AudioFlowTB = new System.Windows.Forms.TextBox();
            this.FpsTB = new System.Windows.Forms.TextBox();
            this.AudioComboBox = new System.Windows.Forms.ComboBox();
            this.ImageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.ResultTB = new System.Windows.Forms.RichTextBox();
            this.VlcPathTB = new System.Windows.Forms.TextBox();
            this.vlcPathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectInputFileBtn
            // 
            this.SelectInputFileBtn.Location = new System.Drawing.Point(152, 43);
            this.SelectInputFileBtn.Name = "SelectInputFileBtn";
            this.SelectInputFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectInputFileBtn.TabIndex = 0;
            this.SelectInputFileBtn.Text = "Select ...";
            this.SelectInputFileBtn.UseVisualStyleBackColor = true;
            this.SelectInputFileBtn.Click += new System.EventHandler(this.SelectInputFileBtn_Click);
            // 
            // FilePath
            // 
            this.FilePath.Enabled = false;
            this.FilePath.Location = new System.Drawing.Point(13, 43);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(133, 20);
            this.FilePath.TabIndex = 1;
            this.FilePath.Text = "File load path";
            // 
            // SaveFileTB
            // 
            this.SaveFileTB.Enabled = false;
            this.SaveFileTB.Location = new System.Drawing.Point(13, 69);
            this.SaveFileTB.Name = "SaveFileTB";
            this.SaveFileTB.Size = new System.Drawing.Size(133, 20);
            this.SaveFileTB.TabIndex = 3;
            this.SaveFileTB.Text = "File save folder";
            // 
            // SelectOutputFileBtn
            // 
            this.SelectOutputFileBtn.Location = new System.Drawing.Point(152, 69);
            this.SelectOutputFileBtn.Name = "SelectOutputFileBtn";
            this.SelectOutputFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectOutputFileBtn.TabIndex = 2;
            this.SelectOutputFileBtn.Text = "Select ...";
            this.SelectOutputFileBtn.UseVisualStyleBackColor = true;
            this.SelectOutputFileBtn.Click += new System.EventHandler(this.SelectOutputFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(12, 204);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(133, 20);
            this.WidthTB.TabIndex = 4;
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(152, 204);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(133, 20);
            this.HeightTB.TabIndex = 5;
            // 
            // ImageFlowTB
            // 
            this.ImageFlowTB.Location = new System.Drawing.Point(152, 243);
            this.ImageFlowTB.Name = "ImageFlowTB";
            this.ImageFlowTB.Size = new System.Drawing.Size(133, 20);
            this.ImageFlowTB.TabIndex = 6;
            // 
            // AudioFlowTB
            // 
            this.AudioFlowTB.Location = new System.Drawing.Point(12, 243);
            this.AudioFlowTB.Name = "AudioFlowTB";
            this.AudioFlowTB.Size = new System.Drawing.Size(133, 20);
            this.AudioFlowTB.TabIndex = 7;
            // 
            // FpsTB
            // 
            this.FpsTB.Location = new System.Drawing.Point(12, 282);
            this.FpsTB.Name = "FpsTB";
            this.FpsTB.Size = new System.Drawing.Size(133, 20);
            this.FpsTB.TabIndex = 8;
            // 
            // AudioComboBox
            // 
            this.AudioComboBox.FormattingEnabled = true;
            this.AudioComboBox.Items.AddRange(new object[] {
            "mpga",
            "mp3"});
            this.AudioComboBox.Location = new System.Drawing.Point(12, 132);
            this.AudioComboBox.Name = "AudioComboBox";
            this.AudioComboBox.Size = new System.Drawing.Size(121, 21);
            this.AudioComboBox.TabIndex = 9;
            // 
            // ImageComboBox
            // 
            this.ImageComboBox.FormattingEnabled = true;
            this.ImageComboBox.Items.AddRange(new object[] {
            "h264",
            "wmv2",
            "MJPG"});
            this.ImageComboBox.Location = new System.Drawing.Point(139, 132);
            this.ImageComboBox.Name = "ImageComboBox";
            this.ImageComboBox.Size = new System.Drawing.Size(121, 21);
            this.ImageComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Audio Codecs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Image Codecs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Audio Flow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Image Flow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "FPS";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(13, 321);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(272, 115);
            this.ExecuteBtn.TabIndex = 18;
            this.ExecuteBtn.Text = "Convert";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.Enabled = false;
            this.ResultTB.Location = new System.Drawing.Point(347, 30);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(462, 123);
            this.ResultTB.TabIndex = 19;
            this.ResultTB.Text = "";
            // 
            // VlcPathTB
            // 
            this.VlcPathTB.Enabled = false;
            this.VlcPathTB.Location = new System.Drawing.Point(12, 17);
            this.VlcPathTB.Name = "VlcPathTB";
            this.VlcPathTB.Size = new System.Drawing.Size(133, 20);
            this.VlcPathTB.TabIndex = 21;
            this.VlcPathTB.Text = "File load path";
            // 
            // vlcPathBtn
            // 
            this.vlcPathBtn.Location = new System.Drawing.Point(151, 17);
            this.vlcPathBtn.Name = "vlcPathBtn";
            this.vlcPathBtn.Size = new System.Drawing.Size(75, 23);
            this.vlcPathBtn.TabIndex = 20;
            this.vlcPathBtn.Text = "Select ...";
            this.vlcPathBtn.UseVisualStyleBackColor = true;
            this.vlcPathBtn.Click += new System.EventHandler(this.vlcPathBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 448);
            this.Controls.Add(this.VlcPathTB);
            this.Controls.Add(this.vlcPathBtn);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageComboBox);
            this.Controls.Add(this.AudioComboBox);
            this.Controls.Add(this.FpsTB);
            this.Controls.Add(this.AudioFlowTB);
            this.Controls.Add(this.ImageFlowTB);
            this.Controls.Add(this.HeightTB);
            this.Controls.Add(this.WidthTB);
            this.Controls.Add(this.SaveFileTB);
            this.Controls.Add(this.SelectOutputFileBtn);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.SelectInputFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectInputFileBtn;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox SaveFileTB;
        private System.Windows.Forms.Button SelectOutputFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.TextBox ImageFlowTB;
        private System.Windows.Forms.TextBox AudioFlowTB;
        private System.Windows.Forms.TextBox FpsTB;
        private System.Windows.Forms.ComboBox AudioComboBox;
        private System.Windows.Forms.ComboBox ImageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.RichTextBox ResultTB;
        private System.Windows.Forms.TextBox VlcPathTB;
        private System.Windows.Forms.Button vlcPathBtn;
    }
}

