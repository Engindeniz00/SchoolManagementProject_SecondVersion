﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SqlBaglantiUyg
{
    public static class Utils
    {
        #region utils
        public static string KullaniciAdi;
        public static int KullaniciId;
        public static string SifreDegisimKullanici;
        public static string KullaniciDegisimAdi;
        public static int KullaniciDegisimId;
        public static int StokItemId;
        private static readonly string textFile = @"C:\Users\Angel Diesel\Desktop\Staj\Staj Alıştırma\EğitimAmaçlı\ConnectionString.txt";

        public static string KarakterUret()
        {
            string karakterler = "";
            Random rnd = new Random();

            for (int i = 0; i < 12; i++)
            {
                int number = rnd.Next(1, 10);
                karakterler += Convert.ToString(number);
            }

            return karakterler;
        }

        #endregion





        /// <summary>
        /// BU KISIMDA STATIC METODLAR KULLARAK PROJEMİZDEKİ KOD SEKMELERİNİN HER BİRİNDE TEKRAR TEKRAR SQL BAGLANTISI OLUŞTURMA VE SQL ÜZERİNDE
        /// ÇEŞİTLİ KOMUTLARI GERÇEKLEŞTİRME KODLARINI YAZMAKTAN KURTULMUŞ OLDUK. AYNI ZAMANDA ÇOK PRATİK BİR ŞEKİLDE SQL ÜZERİNDE OLUŞTURDUĞUMUZ
        /// TABLOYU C# UYGULUMAMIZIN İÇİNDE KULLANABİLİYORUZ.
        /// </summary>
        
        #region baglanti


        /*** BU KISIMI GERÇEKTEN ÇOK İYİ ÖĞREN ÇÜNKÜ İLERİDEKİ PROFESYONEL YAZILIM HAYATINDA GERÇEKTEN ÇOK İŞE YARAYACAK ***/

        private static SqlConnection sqlConnection;


        public static string ConnStr()
        {
            string connectionString = "";
            connectionString = Program.connStr;

            /*** burada her iki kod da text file okumak için başarılı bir şekilde çalışıyor ***/
            //if (File.Exists(textFile))
            //{ 
            //    string[] lines = File.ReadAllLines(textFile);
            //    foreach(string line in lines)
            //    {
            //        connectionString = line;
            //    }
            //}            
            
            //if (File.Exists(textFile)) 
            //{
            //    using (StreamReader file = new StreamReader(textFile))
            //    {
            //        connectionString = file.ReadLine();
            //    }
            //}               


            return connectionString;
        }

        private static void BaglantiSagla()
        {
            sqlConnection = new SqlConnection(ConnStr());
            try
            {
                BaglantiAc();
            }
            catch (Exception)
            { 
            }
        }

        // burada da sql üzerinde komutlar kullarak tablo oluşturma işlemini yapıyoruz
        public static DataTable TabloGetir(string sorgu)
        {
            BaglantiSagla();
            DataTable dtTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand(sorgu);
            sqlDataAdapter.SelectCommand.Connection = sqlConnection;
            sqlDataAdapter.Fill(dtTable);
            BaglantiKapat();
            return dtTable;
        }
         
        public static void BaglantiAc()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public static void BaglantiKapat()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        // burada sql için yazdığımız kodların sql üzerinde işlenmesi için kullandık
        public static bool SorguCalistir(string sorgu)
        {
            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu,sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
                BaglantiKapat();
                return true;
            }
            catch (Exception)
            {
                BaglantiKapat();
                return false;
            }
        }

        // executescalar kullanarak sql üzerinden tek değer döndürmeyi sağlıyoruz
        public static string TekDegerAlString(string sorgu)
        {
            string deger = "";

            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu, sqlConnection);
            try
            {
                deger= sqlCommand.ExecuteScalar().ToString();
                BaglantiKapat();
                return deger;
            }
            catch (Exception)
            {
                BaglantiKapat();
                return deger;
            }
        }

        public static int TekDegerAlInt(string sorgu)
        {
            int deger = 0;

            BaglantiSagla();
            SqlCommand sqlCommand = new SqlCommand(sorgu, sqlConnection);
            try
            {
                deger = Convert.ToInt32(sqlCommand.ExecuteScalar(),null);
                BaglantiKapat();
                return deger;
            }
            catch (Exception)
            {
                BaglantiKapat();
                return deger;
            }
        }


        #endregion baglanti





        // burada kodları üzerinde bir kaç bir şey denemiştim ama çok gerekli bir metod değil
        #region denemeler
        /***BURADA STATIC METODLARDA DEĞER DÖNDÜRMENİN FARKLI BİR YOLUNU GÖRÜYORUZ***/
        // BURADAKİ VALUE DEĞİŞKENİNİ STATİK METODU NEREDE KULLANIYORSAK ORADA ATADIĞIMIZ DEĞERİ DÖNDÜRÜYOR
        /***
         * Class FrmLogin{
         * int a = 5;
         * Utils.KullaniciAdiAl = a;
         * ---> burada a=5 değeri yani static method içersindeki value değerine karşılık geliyor
         * ---> sonrada bunu ayrıca yukarıda tanımladığımız _kullaniciText değişkenine atayıp static metodumuzda return edebiliyoruz
         * } 
         ***/

        //private static string _kullaniciText;
        //private static string _sifreText;
        //static public string KullaniciAdiAl
        //{
        //    get
        //    {
        //        return _kullaniciText;
        //    }
        //    set
        //    {
        //        _kullaniciText = value;
        //    }

        //}

        //static public string SifreAl
        //{
        //    get
        //    {
        //        return _sifreText;
        //    }
        //    set
        //    {
        //        _sifreText = value;
        //    }
        //}
        #endregion denemeler

    }
}
