using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace Detection
{
    class Filehandler
    {
        public static string esc = "^&*#(";

        public Bitmap savefile()
        {
           // string t=imagetobase64(Program.tumour,ImageFormat.Png);
           // string h=imagetobase64(Program.HOG,ImageFormat.Png);
            string final = esc+Program.text+esc+Program.text;
            CNNModel obj = new CNNModel();
            Bitmap finalbmp = obj.CNNModelpool(final, (Bitmap)Program.org);
            return finalbmp;
        }

        public void save()
        {
            

           
           


          
        }



        public string imagetobase64(System.Drawing.Image simage, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                simage.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;

        }
    }
}
