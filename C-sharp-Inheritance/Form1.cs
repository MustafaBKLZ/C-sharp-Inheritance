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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        Person.Student student = new Person.Student();
        List<Person.Student> student_list = new List<Person.Student>();
        private void btn_studen_ekle_Click(object sender, EventArgs e)
        {
            student_list.Add(new Person.Student(txt_Student_Ad.Text, txt_Student_soyAd.Text, dt_Student_dogum_Tar.Value, txt_StStudent_cinsiyet.Text, txt_Student_okul.Text));
            MessageBox.Show("Eklendi");
            st_listele();
        }
        private void btn_student_liste_Click(object sender, EventArgs e)
        {
            st_listele();
        }
        void st_listele()
        {
            dataGridView1.DataSource = student.makeDataTable(student_list);
        }








        Person.Teacher teacher = new Person.Teacher();
        List<Person.Teacher> teacher_list = new List<Person.Teacher>();
        private void btn_teacher_ekle_Click(object sender, EventArgs e)
        {
            teacher_list.Add(new Person.Teacher(txt_teacher_ad.Text, txt_teacher_soyAd.Text, dt_teacher_dogum_Tar.Value, txt_teacher_cinsiyet.Text, txt_teacher_unvan.Text));
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

        private void btn_ucgen_alan_hesapla_Click(object sender, EventArgs e)
        {
            Cokgen.Ucgen ucgen = new Cokgen.Ucgen();
            txn_sonuc_uc.Text = ucgen.AlaniniBul(
                  Convert.ToDouble(txn_kenar_1_uc.Text)
                , Convert.ToDouble(txn_kenar_2_uc.Text)
                , Convert.ToDouble(txn_kenar_3_uc.Text)).ToString();
        }

        private void btn_kare_alan_hesapla_Click(object sender, EventArgs e)
        {
            Cokgen.Kare kare = new Cokgen.Kare();
            txn_sonuc_kare.Text = kare.AlaniniBul(
                  Convert.ToDouble(txn_kenar_kare.Text)).ToString();
        }

        private void btn_dd_alan_hesapla_Click(object sender, EventArgs e)
        {
            Cokgen.Dikdortgen dikdortgen = new Cokgen.Dikdortgen();
            txn_sonuc_dd.Text = dikdortgen.AlaniniBul(
                  Convert.ToDouble(txn_kenar_1_dd.Text)
                , Convert.ToDouble(txn_kenar_2_dd.Text)).ToString();
        }
    }
}
