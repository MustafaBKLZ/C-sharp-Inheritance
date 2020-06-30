using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_sharp_Inheritance
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Inheritance Student

        Inheritance.Person.Student student = new Inheritance.Person.Student();
        private void btn_studen_ekle_Click(object sender, EventArgs e)
        {
            student = new Inheritance.Person.Student(txt_Student_Ad.Text, txt_Student_soyAd.Text, dt_Student_dogum_Tar.Value, txt_StStudent_cinsiyet.Text, txt_Student_okul.Text);

            st_listele();
        }
        private void btn_student_liste_Click(object sender, EventArgs e)
        {
            st_listele();
        }
        void st_listele()
        {
            dataGridView1.DataSource = Inheritance.Person.Student.StudentDataTable;
        }
        #endregion






        #region Inheritance Teacher
        Inheritance.Person.Teacher teacher = new Inheritance.Person.Teacher();
        List<Inheritance.Person.Teacher> teacher_list = new List<Inheritance.Person.Teacher>();
        private void btn_teacher_ekle_Click(object sender, EventArgs e)
        {
            teacher_list.Add(new Inheritance.Person.Teacher(txt_teacher_ad.Text, txt_teacher_soyAd.Text, dt_teacher_dogum_Tar.Value, txt_teacher_cinsiyet.Text, txt_teacher_unvan.Text));
            MessageBox.Show("Eklendi");
            tc_listele();
        }
        private void btn_teacher_liste_Click(object sender, EventArgs e)
        {
            tc_listele();
        }
        void tc_listele()
        {
            dataGridView2.DataSource = teacher.makeDataTable(teacher_list);
        }
        #endregion





        #region Inheritance Cokgen
        private void btn_ucgen_alan_hesapla_Click(object sender, EventArgs e)
        {
            Inheritance.Cokgen.Ucgen ucgen = new Inheritance.Cokgen.Ucgen();
            txn_sonuc_uc.Text = ucgen.AlaniniBul(
                  Convert.ToDouble(txn_kenar_1_uc.Text)
                , Convert.ToDouble(txn_kenar_2_uc.Text)
                , Convert.ToDouble(txn_kenar_3_uc.Text)).ToString();
        }

        private void btn_kare_alan_hesapla_Click(object sender, EventArgs e)
        {
            Inheritance.Cokgen.Kare kare = new Inheritance.Cokgen.Kare();
            txn_sonuc_kare.Text = kare.AlaniniBul(
                  Convert.ToDouble(txn_kenar_kare.Text)).ToString();
        }

        private void btn_dd_alan_hesapla_Click(object sender, EventArgs e)
        {
            Inheritance.Cokgen.Dikdortgen dikdortgen = new Inheritance.Cokgen.Dikdortgen();
            txn_sonuc_dd.Text = dikdortgen.AlaniniBul(
                  Convert.ToDouble(txn_kenar_1_dd.Text)
                , Convert.ToDouble(txn_kenar_2_dd.Text)).ToString();
        }
        #endregion





        #region Polymorphism + Interface

        private void btn_Square_Click(object sender, EventArgs e)
        {
            // Polymorphism
            Polymorphism.MyShape s = new Polymorphism.MySquare(); // MySquare gibi davranan MyShape...             
            listBox1.Items.Add(s.Draw()); // Çalışan bu metot, MyShape sınıfında tanımlanan, MySquare sınıfında override edilen metottur.
            // Polymorphism


            // Interface
            listBox1.Items.Add(s.Save());   
            listBox1.Items.Add(s.Update()); 
            listBox1.Items.Add(s.Delete());
            // Bu metotlar, MyShape sınıfına uygulanan MyShapeWorks Interface 'den gelen metotlardır.
            // Interface,  MyShape sınıfında değilde MySquare sınıfında uygulanmış olsaydı bu şekilde kullanım yapamazdık..
            // MySquare, MyShape sınıfından miras alıyor. MySquare sınıfını, MyShape sınıfı üzerinden Polymorphism ile kullandığımız için
            // MyShape sınıfına uygulanan Interface metotlarına erişebiliyoruz

            // Interface
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            // Polymorphism
            Polymorphism.MyShape r = new Polymorphism.MyRectangle(); // MyRectangle gibi davranan MyShape...            
            listBox1.Items.Add(r.Draw()); // Çalışan bu metot, MyShape sınıfında tanımlanan, MyRectangle sınıfında override edilen metottur.
            // Polymorphism


            // Interface
            listBox1.Items.Add(r.Save());
            listBox1.Items.Add(r.Update());
            listBox1.Items.Add(r.Delete());
            // Interface
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            // Polymorphism
            Polymorphism.MyShape c = new Polymorphism.MyCircle(); // MyCircle gibi davranan MyShape...            
            listBox1.Items.Add(c.Draw());// Çalışan bu metot, MyShape sınıfında tanımlanan, MyCircle sınıfında override edilen metottur.
            // Polymorphism


            // Interface
            listBox1.Items.Add(c.Save());
            listBox1.Items.Add(c.Update());
            listBox1.Items.Add(c.Delete());
            // Interface
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                student.Delete(ID); // Bu delete işlemi SQLWorks Interface sayesinde oluyor. Sınıfa özel üretilmiş bir metod.
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bir satıra tıklamanız gerekiyor.");
            }
            dataGridView1.DataSource = Inheritance.Person.Student.StudentDataTable;
        }


        DataGridViewRow row;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                row = this.dataGridView1.Rows[e.RowIndex];
        }

        #endregion

    }
}
