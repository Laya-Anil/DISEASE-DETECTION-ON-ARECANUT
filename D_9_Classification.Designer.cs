namespace Detection
{
    partial class D_9_Classification
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orginalpic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(436, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 28);
            this.label4.TabIndex = 157;
            this.label4.Text = "Feature Model Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(33, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 159;
            this.label1.Text = "Leaf Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // orginalpic
            // 
            this.orginalpic.Location = new System.Drawing.Point(441, 125);
            this.orginalpic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orginalpic.Name = "orginalpic";
            this.orginalpic.Size = new System.Drawing.Size(395, 391);
            this.orginalpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orginalpic.TabIndex = 156;
            this.orginalpic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 74);
            this.label6.TabIndex = 167;
            this.label6.Text = "Classification";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(565, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 51);
            this.button1.TabIndex = 168;
            this.button1.Text = "CNN Model Generation (SoftMax)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // D_9_Classification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orginalpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "D_9_Classification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D_9_Classification";
            this.Load += new System.EventHandler(this.D_9_Classification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox orginalpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}