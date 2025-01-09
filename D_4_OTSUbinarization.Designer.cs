namespace Detection
{
    partial class D_4_OTSUbinarization
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thresholdBox = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.orginalpic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Selected Slice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(-5, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 62);
            this.label2.TabIndex = 117;
            this.label2.Text = "Pre Processing Stage";
            // 
            // thresholdBox
            // 
            this.thresholdBox.AutoSize = true;
            this.thresholdBox.BackColor = System.Drawing.Color.Transparent;
            this.thresholdBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdBox.ForeColor = System.Drawing.Color.White;
            this.thresholdBox.Location = new System.Drawing.Point(547, 412);
            this.thresholdBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thresholdBox.Name = "thresholdBox";
            this.thresholdBox.Size = new System.Drawing.Size(30, 23);
            this.thresholdBox.TabIndex = 122;
            this.thresholdBox.Text = ".....";
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(423, 437);
            this.slider.Margin = new System.Windows.Forms.Padding(4);
            this.slider.Maximum = 255;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(351, 56);
            this.slider.TabIndex = 121;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(419, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "&Threshold value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(419, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Noise Removal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 41);
            this.button1.TabIndex = 123;
            this.button1.Text = "PreProcessing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(934, 498);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 41);
            this.button3.TabIndex = 127;
            this.button3.Text = "Proceed";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(909, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 132;
            this.label5.Text = ".....";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(785, 434);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(351, 56);
            this.trackBar1.TabIndex = 131;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label7.Location = new System.Drawing.Point(781, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 130;
            this.label7.Text = "&Threshold value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label8.Location = new System.Drawing.Point(781, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 129;
            this.label8.Text = "Shading Removal";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(583, 498);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 41);
            this.button4.TabIndex = 133;
            this.button4.Text = "Calculate Median";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(1144, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 46);
            this.label3.TabIndex = 135;
            this.label3.Text = "Training Phase";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1144, 90);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(241, 231);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 134;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(785, 89);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 313);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 128;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1212, 479);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 125;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // orginalpic
            // 
            this.orginalpic.Location = new System.Drawing.Point(423, 90);
            this.orginalpic.Margin = new System.Windows.Forms.Padding(4);
            this.orginalpic.Name = "orginalpic";
            this.orginalpic.Size = new System.Drawing.Size(351, 313);
            this.orginalpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orginalpic.TabIndex = 118;
            this.orginalpic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // D_4_OTSUbinarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1401, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thresholdBox);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orginalpic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "D_4_OTSUbinarization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D_4_OTSUbinarization";
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label thresholdBox;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox orginalpic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}