namespace C_sharp_Inheritance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_studen_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dt_Student_dogum_Tar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Student_okul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StStudent_cinsiyet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Student_soyAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Student_Ad = new System.Windows.Forms.TextBox();
            this.btn_student_liste = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_teacher_liste = new System.Windows.Forms.Button();
            this.dt_teacher_dogum_Tar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_teacher_unvan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_teacher_cinsiyet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_teacher_soyAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_teacher_ad = new System.Windows.Forms.TextBox();
            this.btn_teacher_ekle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_dd_alan_hesapla = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txn_kenar_2_dd = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_kenar_1_dd = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_sonuc_dd = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.btn_kare_alan_hesapla = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txn_kenar_kare = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_sonuc_kare = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.btn_ucgen_alan_hesapla = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txn_kenar_3_uc = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_kenar_2_uc = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_kenar_1_uc = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.txn_sonuc_uc = new C_sharp_Inheritance.TextBoxNumbersOnly();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Square = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_studen_ekle
            // 
            this.btn_studen_ekle.Location = new System.Drawing.Point(310, 6);
            this.btn_studen_ekle.Name = "btn_studen_ekle";
            this.btn_studen_ekle.Size = new System.Drawing.Size(95, 46);
            this.btn_studen_ekle.TabIndex = 0;
            this.btn_studen_ekle.Text = "Ekle";
            this.btn_studen_ekle.UseVisualStyleBackColor = true;
            this.btn_studen_ekle.Click += new System.EventHandler(this.btn_studen_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1234, 396);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 569);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btn_sil);
            this.tabPage1.Controls.Add(this.dt_Student_dogum_Tar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_Student_okul);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_StStudent_cinsiyet);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Student_soyAd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_Student_Ad);
            this.tabPage1.Controls.Add(this.btn_studen_ekle);
            this.tabPage1.Controls.Add(this.btn_student_liste);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(411, 6);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(95, 46);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dt_Student_dogum_Tar
            // 
            this.dt_Student_dogum_Tar.Location = new System.Drawing.Point(104, 58);
            this.dt_Student_dogum_Tar.Name = "dt_Student_dogum_Tar";
            this.dt_Student_dogum_Tar.Size = new System.Drawing.Size(200, 23);
            this.dt_Student_dogum_Tar.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Okul";
            // 
            // txt_Student_okul
            // 
            this.txt_Student_okul.Location = new System.Drawing.Point(104, 110);
            this.txt_Student_okul.Name = "txt_Student_okul";
            this.txt_Student_okul.Size = new System.Drawing.Size(200, 23);
            this.txt_Student_okul.TabIndex = 13;
            this.txt_Student_okul.Text = "aöf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cinsiyet";
            // 
            // txt_StStudent_cinsiyet
            // 
            this.txt_StStudent_cinsiyet.Location = new System.Drawing.Point(104, 84);
            this.txt_StStudent_cinsiyet.Name = "txt_StStudent_cinsiyet";
            this.txt_StStudent_cinsiyet.Size = new System.Drawing.Size(200, 23);
            this.txt_StStudent_cinsiyet.TabIndex = 11;
            this.txt_StStudent_cinsiyet.Text = "erkek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // txt_Student_soyAd
            // 
            this.txt_Student_soyAd.Location = new System.Drawing.Point(104, 32);
            this.txt_Student_soyAd.Name = "txt_Student_soyAd";
            this.txt_Student_soyAd.Size = new System.Drawing.Size(200, 23);
            this.txt_Student_soyAd.TabIndex = 7;
            this.txt_Student_soyAd.Text = "bükülmez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // txt_Student_Ad
            // 
            this.txt_Student_Ad.Location = new System.Drawing.Point(104, 6);
            this.txt_Student_Ad.Name = "txt_Student_Ad";
            this.txt_Student_Ad.Size = new System.Drawing.Size(200, 23);
            this.txt_Student_Ad.TabIndex = 5;
            this.txt_Student_Ad.Text = "mustafa";
            // 
            // btn_student_liste
            // 
            this.btn_student_liste.Location = new System.Drawing.Point(310, 89);
            this.btn_student_liste.Name = "btn_student_liste";
            this.btn_student_liste.Size = new System.Drawing.Size(95, 46);
            this.btn_student_liste.TabIndex = 2;
            this.btn_student_liste.Text = "Listele";
            this.btn_student_liste.UseVisualStyleBackColor = true;
            this.btn_student_liste.Click += new System.EventHandler(this.btn_student_liste_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btn_teacher_liste);
            this.tabPage2.Controls.Add(this.dt_teacher_dogum_Tar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_teacher_unvan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_teacher_cinsiyet);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_teacher_soyAd);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txt_teacher_ad);
            this.tabPage2.Controls.Add(this.btn_teacher_ekle);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher";
            // 
            // btn_teacher_liste
            // 
            this.btn_teacher_liste.Location = new System.Drawing.Point(310, 86);
            this.btn_teacher_liste.Name = "btn_teacher_liste";
            this.btn_teacher_liste.Size = new System.Drawing.Size(95, 46);
            this.btn_teacher_liste.TabIndex = 29;
            this.btn_teacher_liste.Text = "Listele";
            this.btn_teacher_liste.UseVisualStyleBackColor = true;
            this.btn_teacher_liste.Click += new System.EventHandler(this.btn_teacher_liste_Click);
            // 
            // dt_teacher_dogum_Tar
            // 
            this.dt_teacher_dogum_Tar.Location = new System.Drawing.Point(104, 57);
            this.dt_teacher_dogum_Tar.Name = "dt_teacher_dogum_Tar";
            this.dt_teacher_dogum_Tar.Size = new System.Drawing.Size(200, 23);
            this.dt_teacher_dogum_Tar.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ünvan";
            // 
            // txt_teacher_unvan
            // 
            this.txt_teacher_unvan.Location = new System.Drawing.Point(104, 109);
            this.txt_teacher_unvan.Name = "txt_teacher_unvan";
            this.txt_teacher_unvan.Size = new System.Drawing.Size(200, 23);
            this.txt_teacher_unvan.TabIndex = 26;
            this.txt_teacher_unvan.Text = "Bilişim ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cinsiyet";
            // 
            // txt_teacher_cinsiyet
            // 
            this.txt_teacher_cinsiyet.Location = new System.Drawing.Point(104, 83);
            this.txt_teacher_cinsiyet.Name = "txt_teacher_cinsiyet";
            this.txt_teacher_cinsiyet.Size = new System.Drawing.Size(200, 23);
            this.txt_teacher_cinsiyet.TabIndex = 24;
            this.txt_teacher_cinsiyet.Text = "erkek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Doğum Tarih";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Soyad";
            // 
            // txt_teacher_soyAd
            // 
            this.txt_teacher_soyAd.Location = new System.Drawing.Point(104, 31);
            this.txt_teacher_soyAd.Name = "txt_teacher_soyAd";
            this.txt_teacher_soyAd.Size = new System.Drawing.Size(200, 23);
            this.txt_teacher_soyAd.TabIndex = 21;
            this.txt_teacher_soyAd.Text = "bükülmez";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ad";
            // 
            // txt_teacher_ad
            // 
            this.txt_teacher_ad.Location = new System.Drawing.Point(104, 5);
            this.txt_teacher_ad.Name = "txt_teacher_ad";
            this.txt_teacher_ad.Size = new System.Drawing.Size(200, 23);
            this.txt_teacher_ad.TabIndex = 19;
            this.txt_teacher_ad.Text = "mustafa";
            // 
            // btn_teacher_ekle
            // 
            this.btn_teacher_ekle.Location = new System.Drawing.Point(310, 5);
            this.btn_teacher_ekle.Name = "btn_teacher_ekle";
            this.btn_teacher_ekle.Size = new System.Drawing.Size(95, 46);
            this.btn_teacher_ekle.TabIndex = 16;
            this.btn_teacher_ekle.Text = "Ekle";
            this.btn_teacher_ekle.UseVisualStyleBackColor = true;
            this.btn_teacher_ekle.Click += new System.EventHandler(this.btn_teacher_ekle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1234, 399);
            this.dataGridView2.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.btn_dd_alan_hesapla);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.txn_kenar_2_dd);
            this.tabPage3.Controls.Add(this.txn_kenar_1_dd);
            this.tabPage3.Controls.Add(this.txn_sonuc_dd);
            this.tabPage3.Controls.Add(this.btn_kare_alan_hesapla);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.txn_kenar_kare);
            this.tabPage3.Controls.Add(this.txn_sonuc_kare);
            this.tabPage3.Controls.Add(this.btn_ucgen_alan_hesapla);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txn_kenar_3_uc);
            this.tabPage3.Controls.Add(this.txn_kenar_2_uc);
            this.tabPage3.Controls.Add(this.txn_kenar_1_uc);
            this.tabPage3.Controls.Add(this.txn_sonuc_uc);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1240, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çokgen";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(863, 74);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 17);
            this.label31.TabIndex = 72;
            this.label31.Text = "cm";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(863, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 17);
            this.label30.TabIndex = 71;
            this.label30.Text = "cm";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(535, 45);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 17);
            this.label29.TabIndex = 70;
            this.label29.Text = "cm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(188, 103);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 17);
            this.label28.TabIndex = 69;
            this.label28.Text = "cm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(188, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 17);
            this.label27.TabIndex = 68;
            this.label27.Text = "cm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(188, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 17);
            this.label21.TabIndex = 68;
            this.label21.Text = "cm";
            // 
            // btn_dd_alan_hesapla
            // 
            this.btn_dd_alan_hesapla.Location = new System.Drawing.Point(748, 158);
            this.btn_dd_alan_hesapla.Name = "btn_dd_alan_hesapla";
            this.btn_dd_alan_hesapla.Size = new System.Drawing.Size(109, 46);
            this.btn_dd_alan_hesapla.TabIndex = 67;
            this.btn_dd_alan_hesapla.Text = "Hesapla";
            this.btn_dd_alan_hesapla.UseVisualStyleBackColor = true;
            this.btn_dd_alan_hesapla.Click += new System.EventHandler(this.btn_dd_alan_hesapla_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(928, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "cm2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(684, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 17);
            this.label23.TabIndex = 65;
            this.label23.Text = "Dikdörtgen Alanı";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(684, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 17);
            this.label24.TabIndex = 64;
            this.label24.Text = "Sonuç";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(658, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 17);
            this.label25.TabIndex = 63;
            this.label25.Text = "Kısa Kenar";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(658, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 17);
            this.label26.TabIndex = 62;
            this.label26.Text = "Uzun Kenar ";
            // 
            // txn_kenar_2_dd
            // 
            this.txn_kenar_2_dd.Location = new System.Drawing.Point(748, 71);
            this.txn_kenar_2_dd.Name = "txn_kenar_2_dd";
            this.txn_kenar_2_dd.NumbersOnly = true;
            this.txn_kenar_2_dd.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_2_dd.TabIndex = 61;
            this.txn_kenar_2_dd.Text = "0";
            // 
            // txn_kenar_1_dd
            // 
            this.txn_kenar_1_dd.Location = new System.Drawing.Point(748, 42);
            this.txn_kenar_1_dd.Name = "txn_kenar_1_dd";
            this.txn_kenar_1_dd.NumbersOnly = true;
            this.txn_kenar_1_dd.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_1_dd.TabIndex = 60;
            this.txn_kenar_1_dd.Text = "0";
            // 
            // txn_sonuc_dd
            // 
            this.txn_sonuc_dd.Location = new System.Drawing.Point(748, 129);
            this.txn_sonuc_dd.Name = "txn_sonuc_dd";
            this.txn_sonuc_dd.NumbersOnly = true;
            this.txn_sonuc_dd.Size = new System.Drawing.Size(174, 23);
            this.txn_sonuc_dd.TabIndex = 59;
            this.txn_sonuc_dd.Text = "0";
            // 
            // btn_kare_alan_hesapla
            // 
            this.btn_kare_alan_hesapla.Location = new System.Drawing.Point(420, 158);
            this.btn_kare_alan_hesapla.Name = "btn_kare_alan_hesapla";
            this.btn_kare_alan_hesapla.Size = new System.Drawing.Size(109, 46);
            this.btn_kare_alan_hesapla.TabIndex = 58;
            this.btn_kare_alan_hesapla.Text = "Hesapla";
            this.btn_kare_alan_hesapla.UseVisualStyleBackColor = true;
            this.btn_kare_alan_hesapla.Click += new System.EventHandler(this.btn_kare_alan_hesapla_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 57;
            this.label17.Text = "cm2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(356, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 56;
            this.label18.Text = "Karenin Alanı";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(356, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Sonuç";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(356, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 17);
            this.label22.TabIndex = 52;
            this.label22.Text = "Kenar";
            // 
            // txn_kenar_kare
            // 
            this.txn_kenar_kare.Location = new System.Drawing.Point(420, 42);
            this.txn_kenar_kare.Name = "txn_kenar_kare";
            this.txn_kenar_kare.NumbersOnly = true;
            this.txn_kenar_kare.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_kare.TabIndex = 49;
            this.txn_kenar_kare.Text = "0";
            // 
            // txn_sonuc_kare
            // 
            this.txn_sonuc_kare.Location = new System.Drawing.Point(420, 129);
            this.txn_sonuc_kare.Name = "txn_sonuc_kare";
            this.txn_sonuc_kare.NumbersOnly = true;
            this.txn_sonuc_kare.Size = new System.Drawing.Size(174, 23);
            this.txn_sonuc_kare.TabIndex = 48;
            this.txn_sonuc_kare.Text = "0";
            // 
            // btn_ucgen_alan_hesapla
            // 
            this.btn_ucgen_alan_hesapla.Location = new System.Drawing.Point(73, 158);
            this.btn_ucgen_alan_hesapla.Name = "btn_ucgen_alan_hesapla";
            this.btn_ucgen_alan_hesapla.Size = new System.Drawing.Size(109, 46);
            this.btn_ucgen_alan_hesapla.TabIndex = 47;
            this.btn_ucgen_alan_hesapla.Text = "Hesapla";
            this.btn_ucgen_alan_hesapla.UseVisualStyleBackColor = true;
            this.btn_ucgen_alan_hesapla.Click += new System.EventHandler(this.btn_ucgen_alan_hesapla_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(253, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "cm2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(9, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "Üçgenin Alanı (Heron formulü)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Sonuç";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Kenar 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Kenar 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Kenar 1";
            // 
            // txn_kenar_3_uc
            // 
            this.txn_kenar_3_uc.Location = new System.Drawing.Point(73, 100);
            this.txn_kenar_3_uc.Name = "txn_kenar_3_uc";
            this.txn_kenar_3_uc.NumbersOnly = true;
            this.txn_kenar_3_uc.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_3_uc.TabIndex = 40;
            this.txn_kenar_3_uc.Text = "0";
            // 
            // txn_kenar_2_uc
            // 
            this.txn_kenar_2_uc.Location = new System.Drawing.Point(73, 71);
            this.txn_kenar_2_uc.Name = "txn_kenar_2_uc";
            this.txn_kenar_2_uc.NumbersOnly = true;
            this.txn_kenar_2_uc.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_2_uc.TabIndex = 39;
            this.txn_kenar_2_uc.Text = "0";
            // 
            // txn_kenar_1_uc
            // 
            this.txn_kenar_1_uc.Location = new System.Drawing.Point(73, 42);
            this.txn_kenar_1_uc.Name = "txn_kenar_1_uc";
            this.txn_kenar_1_uc.NumbersOnly = true;
            this.txn_kenar_1_uc.Size = new System.Drawing.Size(109, 23);
            this.txn_kenar_1_uc.TabIndex = 38;
            this.txn_kenar_1_uc.Text = "0";
            // 
            // txn_sonuc_uc
            // 
            this.txn_sonuc_uc.Location = new System.Drawing.Point(73, 129);
            this.txn_sonuc_uc.Name = "txn_sonuc_uc";
            this.txn_sonuc_uc.NumbersOnly = true;
            this.txn_sonuc_uc.Size = new System.Drawing.Size(174, 23);
            this.txn_sonuc_uc.TabIndex = 37;
            this.txn_sonuc_uc.Text = "0";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.btn_Square);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.btn_Rectangle);
            this.tabPage4.Controls.Add(this.btn_circle);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1240, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Polymorphism / Interface";
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(194, 6);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(87, 39);
            this.btn_Square.TabIndex = 7;
            this.btn_Square.Text = "Square";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 452);
            this.listBox1.TabIndex = 6;
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Location = new System.Drawing.Point(101, 6);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(87, 39);
            this.btn_Rectangle.TabIndex = 5;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(8, 6);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(87, 39);
            this.btn_circle.TabIndex = 4;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 569);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_studen_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Student_okul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StStudent_cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Student_soyAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Student_Ad;
        private System.Windows.Forms.DateTimePicker dt_Student_dogum_Tar;
        private System.Windows.Forms.DateTimePicker dt_teacher_dogum_Tar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_teacher_unvan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_teacher_cinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_teacher_soyAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_teacher_ad;
        private System.Windows.Forms.Button btn_teacher_ekle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_student_liste;
        private System.Windows.Forms.Button btn_teacher_liste;
        private System.Windows.Forms.TabPage tabPage3;
        private TextBoxNumbersOnly txn_sonuc_uc;
        private TextBoxNumbersOnly txn_kenar_3_uc;
        private TextBoxNumbersOnly txn_kenar_2_uc;
        private TextBoxNumbersOnly txn_kenar_1_uc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_ucgen_alan_hesapla;
        private System.Windows.Forms.Button btn_kare_alan_hesapla;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private TextBoxNumbersOnly txn_kenar_kare;
        private TextBoxNumbersOnly txn_sonuc_kare;
        private System.Windows.Forms.Button btn_dd_alan_hesapla;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private C_sharp_Inheritance.TextBoxNumbersOnly txn_kenar_2_dd;
        private C_sharp_Inheritance.TextBoxNumbersOnly txn_kenar_1_dd;
        private C_sharp_Inheritance.TextBoxNumbersOnly txn_sonuc_dd;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_sil;
    }
}