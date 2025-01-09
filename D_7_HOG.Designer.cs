namespace Detection
{
    partial class D_7_HOG
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
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.picMRI = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 74);
            this.label2.TabIndex = 151;
            this.label2.Text = "Feature Reduction";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(914, 685);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 152;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picMRI);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button5);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Size = new System.Drawing.Size(391, 685);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // picMRI
            // 
            this.picMRI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMRI.Location = new System.Drawing.Point(0, 24);
            this.picMRI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMRI.Name = "picMRI";
            this.picMRI.Size = new System.Drawing.Size(391, 366);
            this.picMRI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMRI.TabIndex = 117;
            this.picMRI.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "Leaf Image";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(22, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(288, 51);
            this.button5.TabIndex = 118;
            this.button5.Text = "Proceed";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Detection.Properties.Resources.Login1___Copy___Copy;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(22, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 51);
            this.button4.TabIndex = 117;
            this.button4.Text = "Identify Region";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.PictureBox1);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackgroundImage = global::Detection.Properties.Resources.green_leaves_texture_tropical_leaf_1075757;
            this.splitContainer3.Size = new System.Drawing.Size(517, 685);
            this.splitContainer3.SplitterDistance = 493;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(0, 24);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(517, 469);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 119;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(169)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 118;
            this.label3.Text = "Leaf Image";
            // 
            // D_7_HOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 759);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "D_7_HOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D_7_HOG";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMRI)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox picMRI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label3;
    }
}