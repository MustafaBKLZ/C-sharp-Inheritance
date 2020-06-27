using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace C_sharp_Inheritance.Person
{
    public class Teacher : Person //Teacher class'ı Person class'ından miras alıyor.
    {

        private string Unvan; //Teacher sınıfında kullanılmak üzere Unvan adında bir değişken tanımladık.

        /// <summary>
        /// Boş bir constructor metod.
        /// </summary>
        public Teacher() 
        {
            // constructor metod / yapıcı metod
        }

        /// <summary>
        ///  Parametre alan constructor metod.
        /// </summary>
        /// <param name="adi"></param>
        /// <param name="soyadi"></param>
        /// <param name="dogum_tarih"></param>
        /// <param name="cinsiyet"></param>
        /// <param name="unvan"></param>
        public Teacher(string adi, string soyadi, DateTime dogum_tarih, string cinsiyet, string unvan) 
        {
            // constructor metod / yapıcı metod
            this.Adı = adi;
            this.Soyadı = soyadi;
            this.Cinsiyeti = cinsiyet;
            this.DogumTarihi = dogum_tarih;
            this.Unvan = unvan;
        }


        /// <summary>
        /// Ben bir öğretmenim MessageBox'u üretir ve eklenen öğretmenin bilgilerini gösterir.
        /// </summary>
        public override void makeAction()
        {
            //Person sınıfında tanımlanan abstract metodu override ederek
            //metodun içini istediğimiz gibi doldurduk.
            MessageBox.Show("Ben bir öğretmenim" + Environment.NewLine
              + Environment.NewLine + this.Adı
              + Environment.NewLine + this.Soyadı
              + Environment.NewLine + this.DogumTarihi
              + Environment.NewLine + this.Cinsiyeti
              + Environment.NewLine + this.Unvan);
        }


        /// <summary>
        /// Gönderilen List nesnesinden DataTable Üretir.
        /// </summary>
        /// <param name="list">List<Teacher></param>
        /// <returns></returns>
        public DataTable makeDataTable(List<Teacher> list)
        {
            // Formda hazırladığımız List'i bu metoda gönderek bize bir DataTable üretmesini istiyoruz. 
            // bu metod bu Teacher Class'ına aittir.
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Adı");
            dt.Columns.Add("Soyadı");
            dt.Columns.Add("DogumTarihi");
            dt.Columns.Add("Cinsiyeti");
            dt.Columns.Add("Unvan");

            int sayac = 0;
            foreach (Teacher item in list)
            {
                DataRow userRow = dt.NewRow();
                sayac++;
                userRow["ID"] = sayac;
                userRow["Adı"] = item.Adı;
                userRow["Soyadı"] = item.Soyadı;
                userRow["DogumTarihi"] = item.DogumTarihi;
                userRow["Cinsiyeti"] = item.Cinsiyeti;
                userRow["Unvan"] = item.Unvan;
                dt.Rows.Add(userRow);
            }
            return dt;
        }
    }
}
