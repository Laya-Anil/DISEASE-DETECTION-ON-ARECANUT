using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Detection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string OrginalFilePath = "";
        public static string sliceFilePath = "";
        public static Bitmap blackImage;

        public static string ss = "";


        public static Bitmap org;
        public static Bitmap tumour;
        public static Bitmap HOG;
        public static string text = "";

        public static double sdata = 0.75;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasePage());
        }
    }
}
