using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge;
using System.Drawing.Imaging;
using System.IO;


namespace Detection
{
    public partial class D_5_CNN : Form
    {
        CNNData _cnn1;
        public static int _count = 0;
        public static Bitmap bc1;
        public static Bitmap bc;
        public static Bitmap img2;
        public D_5_CNN(Bitmap bmp, Bitmap bmp2)
        {
            InitializeComponent();
           // orginalpic.Image = System.Drawing.Image.FromFile(Program.sliceFilePath);
            orginalpic.Image = (System.Drawing.Image)bmp;
            bc1 = bmp;
            bc = bmp2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                _cnn1 = new CNNData(bc, Convert.ToInt32(txtNumClusters.Text), Detection.Colour.Types.RGB);
            else
                _cnn1 = new CNNData(bc, Convert.ToInt32(txtNumClusters.Text), Detection.Colour.Types.HSV);

            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!_cnn1.Converged)
            {
                _cnn1.Iterate();
                pictureBox1.Image = _cnn1.ProcessedImage;
                pictureBox1.Refresh();
                _count++;
                lblInfo.Text = "Iteration: " + _count.ToString();
            }
            else
            {
                lblInfo.Text = "Converged After " + _count.ToString() + " Iterations";
                
                _count = 0;
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //img2 = (Bitmap)pictureBox1.Image;
            //ApplyFilter1(new ConnectedComponentsLabeling());
            //ApplyFilter2();
            //ApplyFilter3();
            D_5_DWT obj = new D_5_DWT((Bitmap)orginalpic.Image, (Bitmap)pictureBox1.Image);
            ActiveForm.Hide();
            obj.Show();

        }
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;

        private void ApplyFilter3()
        {
           

            Bitmap selectedSource1 = null;
            Bitmap bitmapResult1 = null;

            //ExtBitmap.DistanceFormulaType distanceType = (ExtBitmap.DistanceFormulaType)cmbDistanceType.SelectedItem;
            ExtBitmap.DistanceFormulaType distanceType1 = ExtBitmap.DistanceFormulaType.Chebyshev;

            selectedSource1 = (Bitmap)Bitmap.FromFile(Program.sliceFilePath);
            

            if (selectedSource1 != null)
            {
                int bsize1 = 10;
                double factor1 = 1;
                bool hedge1 = true;
                int thre1 = 2;
                //bitmapResult = selectedSource.StainedGlassColorFilter((int)numBlockSize.Value, (double)numBlockFactor.Value, distanceType, chkHighlightEdges.Checked, (byte)numEdgeThreshold.Value, btnColour.BackColor, selectedSource);
                bitmapResult1 = selectedSource1.StainedGlassColorFilter((int)bsize1, (double)factor1, distanceType1, hedge1, (byte)thre1, Color.Teal, selectedSource1);
            }

            if (bitmapResult1 != null)
            {
                
                    pictureBox4.Image = bitmapResult1;
                
                   
                
            }
        }
        private void ApplyFilter2()
        {
           

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            //ExtBitmap.DistanceFormulaType distanceType = (ExtBitmap.DistanceFormulaType)cmbDistanceType.SelectedItem;
            ExtBitmap.DistanceFormulaType distanceType = ExtBitmap.DistanceFormulaType.Euclidean;

            selectedSource = (Bitmap)Bitmap.FromFile(Program.sliceFilePath);
           
           

            if (selectedSource != null)
            {
                int bsize = 40;
                double factor = 4.0;
                bool hedge = true;
                int thre = 1;


                //bitmapResult = selectedSource.StainedGlassColorFilter((int)numBlockSize.Value, (double)numBlockFactor.Value, distanceType, chkHighlightEdges.Checked, (byte)numEdgeThreshold.Value, btnColour.BackColor, selectedSource);
                bitmapResult = selectedSource.StainedGlassColorFilter((int)bsize, (double)factor, distanceType, hedge, (byte)thre, Color.Teal, selectedSource);
            }

            if (bitmapResult != null)
            {

                pictureBox3.Image = bitmapResult;
                
            }
        }

        private void ApplyFilter1(IFilter filter)
        {
            try
            {
                // set wait cursor
                this.Cursor = Cursors.WaitCursor;

                // apply filter to the image
                Bitmap newImage = filter.Apply((Bitmap)orginalpic.Image);

                pictureBox2.Image = (System.Drawing.Image)newImage;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Selected filter can not be applied to the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // restore cursor
                this.Cursor = Cursors.Default;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
