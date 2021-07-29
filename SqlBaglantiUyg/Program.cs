using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SqlBaglantiUyg
{
    static class Program
    {
        private static readonly string textFile = @"C:\Users\Angel Diesel\Desktop\Staj\Staj Alıştırma\EğitimAmaçlı\ConnectionString.txt";
        public static string connStr="";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    connStr = file.ReadLine();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
