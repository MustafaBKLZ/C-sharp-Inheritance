using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace C_sharp_Inheritance.Person
{
    public class Student : Person // Student class'ı Person class'ından miras aldığını belirtiyoruz.
    {
        private string Okul; //  Stundent nesnesinde kullanacağımız bir değişken tanımlıyoruz.

        /// <summary>
        /// Boş bir constructor metod.
        /// </summary>
        public Student()
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
        /// <param name="okul"></param>
        public Student(string adi, string soyadi, DateTime dogum_tarih, string cinsiyet, string okul) 
        {
            // constructor metod / yapıcı metod
            this.Adı = adi;
            this.Soyadı = soyadi;
            this.DogumTarihi = dogum_tarih;
            this.Cinsiyeti = cinsiyet;
            this.Okul = okul;
        }

        /// <summary>
        /// Ben bir öğrenciyim MessageBox'u üretir ve eklenen öğrencinin bilgilerini gösterir.
        /// </summary>
        public override void makeAction()
        {
            //Person sınıfında tanımlanan makeAction abstract metodu override ederek
            //metodun içini istediğimiz gibi doldurduk.
            MessageBox.Show("Ben bir öğrenciyim" + Environment.NewLine
                  + Environment.NewLine + this.Adı
                  + Environment.NewLine + this.Soyadı
                  + Environment.NewLine + this.DogumTarihi
                  + Environment.NewLine + this.Cinsiyeti
                  + Environment.NewLine + this.Okul);
        }

        /// <summary>
        /// Gönderilen List nesnesinden DataTable Üretir.
        /// </summary>
        /// <param name="list"> List<Student> </param>
        /// <returns></returns>
        public DataTable makeDataTable(List<Student> list)
        {
            // Formda hazırladığımız List'i bu metoda gönderek bize bir DataTable üretmesini istiyoruz. 
            // bu metod bu Student Class'ına aittir.
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Adı");
            dt.Columns.Add("Soyadı");
            dt.Columns.Add("DogumTarihi");
            dt.Columns.Add("Cinsiyeti");
            dt.Columns.Add("Okul");

            int sayac = 0;
            foreach (Student item in list)
            {
                DataRow userRow = dt.NewRow();
                sayac++;
                userRow["ID"] = sayac;
                userRow["Adı"] = item.Adı;
                userRow["Soyadı"] = item.Soyadı;
                userRow["DogumTarihi"] = item.DogumTarihi;
                userRow["Cinsiyeti"] = item.Cinsiyeti;
                userRow["Okul"] = item.Okul;
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
