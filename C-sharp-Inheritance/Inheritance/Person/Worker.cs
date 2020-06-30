using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_sharp_Inheritance.Inheritance.Person
{
    public class Worker : Person // Worker class'ı Person class'ından miras alıyor.
    {

        private double Maas; //Worker sınıfında kullanılmak üzere Unvan adında bir değişken tanımladık.

        /// <summary>
        /// Boş bir constructor metod.
        /// </summary>
        public Worker()
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
        /// <param name="Maas"></param>
        public Worker(string adi, string soyadi, DateTime dogum_tarih, string cinsiyet, double Maas)
        {
            // constructor metod / yapıcı metod
            this.Adı = adi;
            this.Soyadı = soyadi;
            this.Cinsiyeti = cinsiyet;
            this.DogumTarihi = dogum_tarih;
            this.Maas = Maas;
        }


        /// <summary>
        /// Ben bir işçiyim MessageBox'u üretir ve eklenen işçinin bilgilerini gösterir.
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
              + Environment.NewLine + this.Maas);
        }


        /// <summary>
        /// Gönderilen List nesnesinden DataTable Üretir.
        /// </summary>
        /// <param name="list">List<Worker></param>
        /// <returns></returns>
        public DataTable makeDataTable(List<Worker> list)
        {
            // Formda hazırladığımız List'i bu metoda gönderek bize bir DataTable üretmesini istiyoruz. 
            // bu metod bu Teacher Class'ına aittir.
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Adı");
            dt.Columns.Add("Soyadı");
            dt.Columns.Add("DogumTarihi");
            dt.Columns.Add("Cinsiyeti");
            dt.Columns.Add("Maaş");

            int sayac = 0;
            foreach (Worker item in list)
            {
                DataRow userRow = dt.NewRow();
                sayac++;
                userRow["ID"] = sayac;
                userRow["Adı"] = item.Adı;
                userRow["Soyadı"] = item.Soyadı;
                userRow["DogumTarihi"] = item.DogumTarihi;
                userRow["Cinsiyeti"] = item.Cinsiyeti;
                userRow["Maas"] = item.Maas;
                dt.Rows.Add(userRow);
            }
            return dt;
        }

        public override void Calis()
        {
            MessageBox.Show("Çalıştım");
        }
        public override void SuIc()
        {
            MessageBox.Show("Su İçtim");
        }

        public override void Uyu()
        {
            MessageBox.Show("Uyudum");
        }

        public override void YemekYe()
        {
            MessageBox.Show("Yemek Yedim");
        }
    }
}
