using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace C_sharp_Inheritance.Inheritance.Person
{
    public class Student : Person, Interface.SQLWorks
    /* Student Class'a -- Interface.SQLWorks Interface(Arayüz) -- uyguluyoruz. 
     *  Class'ın en altında Interface'den gelen ve mecburi eklenmesi gereken metodlar var.*/
    {
        public override void makeAction() { }
        public Student() { makeDataTable(); }

        private DataRow datarow;
        public static DataTable StudentDataTable = new DataTable();
        // datatable static olmazsa class her çalıştırıldığında yeniden create edileceğinden datagridview'e sadece son eklenen satır gelir.
        // Static olunca formda class tanımlandığı için form açılmadan create edilir ve bir form tekrar açılana kadar tekrar create edilmez.
        private void makeDataTable() // datatable'a kolonları ekler.
        {
            StudentDataTable.Columns.Add("ID");
            StudentDataTable.Columns.Add("Adı");
            StudentDataTable.Columns.Add("Soyadı");
            StudentDataTable.Columns.Add("DogumTarihi");
            StudentDataTable.Columns.Add("Cinsiyeti");
            StudentDataTable.Columns.Add("Okul");
        }


        private int ID; //  Stundent nesnesinde kullanacağımız bir değişken tanımlıyoruz.
        private string Okul; //  Stundent nesnesinde kullanacağımız bir değişken tanımlıyoruz.

        public Student(string adi, string soyadi, DateTime dogum_tarih, string cinsiyet, string okul, int ID = 0) // varsyılan değerli parametre. Dışarıdan gönderilmesi zorunlu değildir.
        {
            this.Adı = adi;
            this.Soyadı = soyadi;
            this.DogumTarihi = dogum_tarih;
            this.Cinsiyeti = cinsiyet;
            this.Okul = okul;
            if (ID == 0) // ID 0 geliyorsa inserttir
                try
                {
                    this.ID = Convert.ToInt32(StudentDataTable.Rows[StudentDataTable.Rows.Count - 1]["ID"]) + 1; // sıradaki ID'yi istedik.
                }
                catch (IndexOutOfRangeException)
                {
                    this.ID = 1; // Eğer DataTable boş ise 1 verecek
                }
            else
                this.ID = ID; // Dışarıdan ID bilgisi gelmişse onu kullanacağız.

            datarow = CreateDrow(this); // gelen verilerden bir datarow ürettik
            StudentDataTable.Rows.Add(datarow); // datarow'u datatable'a ekledik.
        }


        private DataRow CreateDrow(Student item) // Datatable için bir datarow üretir.
        {
            DataRow userRow = StudentDataTable.NewRow();
            userRow["ID"] = item.ID;
            userRow["Adı"] = item.Adı;
            userRow["Soyadı"] = item.Soyadı;
            userRow["DogumTarihi"] = item.DogumTarihi;
            userRow["Cinsiyeti"] = item.Cinsiyeti;
            userRow["Okul"] = item.Okul;
            return userRow;
        }

        // Miras Alınan Sınıftan gelen metodlar
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
        // Miras Alınan Sınıftan gelen metodlar



        // SQLWorks Interface / Arayüzünden gelen metodlar. Eklenmesi zorunludur. 
        public object Save()
        {
            return null;
        }

        public object Update()
        {
            return null;
        }

        public object Delete(int id)
        {
            var query = StudentDataTable.AsEnumerable().Where(r => r.Field<string>("ID") == id.ToString());
            foreach (var row in query.ToList()) row.Delete();
            StudentDataTable.AcceptChanges();
            return true;
        }
        // SQLWorks Interface / Arayüzünden gelen metodlar. Eklenmesi zorunludur. 
    }
}
