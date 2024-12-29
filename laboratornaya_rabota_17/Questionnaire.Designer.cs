using System.Drawing;
using System.Windows.Forms;

namespace wword
{
    partial class FormQuestionnaire
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtRegistrationAddress = new System.Windows.Forms.TextBox();
            this.txtLivingAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.nudChildrenCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEducation = new System.Windows.Forms.TextBox();
            this.txtSalaryExpectation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnGenerateWord = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDomphone = new System.Windows.Forms.TextBox();
            this.txtMobPhone = new System.Windows.Forms.TextBox();
            this.txtPasportVydan = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.datetimeDataVydachi = new System.Windows.Forms.DateTimePicker();
            this.ИНН = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.Отсрочка = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSemPolozh = new System.Windows.Forms.TextBox();
            this.txtOgrPoZd = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLichTr = new System.Windows.Forms.TextBox();
            this.dateTimePristKRab = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.rbMilitaryYes = new System.Windows.Forms.CheckBox();
            this.rbMilitaryNo = new System.Windows.Forms.CheckBox();
            this.slyzhilRadioBtn = new System.Windows.Forms.CheckBox();
            this.neSlyzhilRadioBtn = new System.Windows.Forms.CheckBox();
            this.otstEst = new System.Windows.Forms.CheckBox();
            this.otstNet = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(44, 45);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(204, 45);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(366, 45);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(144, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(526, 8);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(135, 106);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 6;
            this.pbPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(526, 118);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(135, 24);
            this.btnUploadPhoto.TabIndex = 7;
            this.btnUploadPhoto.Text = "Загрузить фото";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Место рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес регистрации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Адрес проживания";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(267, 74);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(169, 20);
            this.dtpBirthDate.TabIndex = 12;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(267, 96);
            this.txtBirthPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBirthPlace.Multiline = true;
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(169, 38);
            this.txtBirthPlace.TabIndex = 13;
            // 
            // txtRegistrationAddress
            // 
            this.txtRegistrationAddress.Location = new System.Drawing.Point(267, 136);
            this.txtRegistrationAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistrationAddress.Multiline = true;
            this.txtRegistrationAddress.Name = "txtRegistrationAddress";
            this.txtRegistrationAddress.Size = new System.Drawing.Size(169, 40);
            this.txtRegistrationAddress.TabIndex = 14;
            // 
            // txtLivingAddress
            // 
            this.txtLivingAddress.Location = new System.Drawing.Point(267, 178);
            this.txtLivingAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLivingAddress.Multiline = true;
            this.txtLivingAddress.Name = "txtLivingAddress";
            this.txtLivingAddress.Size = new System.Drawing.Size(169, 39);
            this.txtLivingAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Военнообязанный?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Состояние здоровья";
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(154, 405);
            this.txtHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(158, 20);
            this.txtHealth.TabIndex = 20;
            // 
            // nudChildrenCount
            // 
            this.nudChildrenCount.Location = new System.Drawing.Point(156, 374);
            this.nudChildrenCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudChildrenCount.Name = "nudChildrenCount";
            this.nudChildrenCount.Size = new System.Drawing.Size(158, 20);
            this.nudChildrenCount.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 377);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Количество детей";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 562);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Образование";
            // 
            // tbEducation
            // 
            this.tbEducation.Location = new System.Drawing.Point(330, 562);
            this.tbEducation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEducation.Name = "tbEducation";
            this.tbEducation.Size = new System.Drawing.Size(158, 20);
            this.tbEducation.TabIndex = 24;
            // 
            // txtSalaryExpectation
            // 
            this.txtSalaryExpectation.Location = new System.Drawing.Point(154, 504);
            this.txtSalaryExpectation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalaryExpectation.Name = "txtSalaryExpectation";
            this.txtSalaryExpectation.Size = new System.Drawing.Size(158, 20);
            this.txtSalaryExpectation.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 504);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Зарплатные ожидания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 469);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Должность";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(154, 467);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(158, 20);
            this.txtPosition.TabIndex = 28;
            // 
            // btnGenerateWord
            // 
            this.btnGenerateWord.Location = new System.Drawing.Point(270, 604);
            this.btnGenerateWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateWord.Name = "btnGenerateWord";
            this.btnGenerateWord.Size = new System.Drawing.Size(135, 32);
            this.btnGenerateWord.TabIndex = 29;
            this.btnGenerateWord.Text = "Создать анкету";
            this.btnGenerateWord.UseVisualStyleBackColor = true;
            this.btnGenerateWord.Click += new System.EventHandler(this.btnGenerateWord_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(86, 235);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "домашний";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(327, 235);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "мобильный";
            // 
            // txtDomphone
            // 
            this.txtDomphone.Location = new System.Drawing.Point(155, 233);
            this.txtDomphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomphone.Name = "txtDomphone";
            this.txtDomphone.Size = new System.Drawing.Size(158, 20);
            this.txtDomphone.TabIndex = 33;
            // 
            // txtMobPhone
            // 
            this.txtMobPhone.Location = new System.Drawing.Point(407, 233);
            this.txtMobPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMobPhone.Name = "txtMobPhone";
            this.txtMobPhone.Size = new System.Drawing.Size(150, 20);
            this.txtMobPhone.TabIndex = 34;
            // 
            // txtPasportVydan
            // 
            this.txtPasportVydan.Location = new System.Drawing.Point(155, 266);
            this.txtPasportVydan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasportVydan.Multiline = true;
            this.txtPasportVydan.Name = "txtPasportVydan";
            this.txtPasportVydan.Size = new System.Drawing.Size(158, 36);
            this.txtPasportVydan.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 276);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Паспорт";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(100, 276);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "выдан";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(327, 276);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "дата выдачи";
            // 
            // datetimeDataVydachi
            // 
            this.datetimeDataVydachi.Location = new System.Drawing.Point(407, 276);
            this.datetimeDataVydachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimeDataVydachi.Name = "datetimeDataVydachi";
            this.datetimeDataVydachi.Size = new System.Drawing.Size(150, 20);
            this.datetimeDataVydachi.TabIndex = 40;
            // 
            // ИНН
            // 
            this.ИНН.AutoSize = true;
            this.ИНН.Location = new System.Drawing.Point(113, 316);
            this.ИНН.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ИНН.Name = "ИНН";
            this.ИНН.Size = new System.Drawing.Size(31, 13);
            this.ИНН.TabIndex = 41;
            this.ИНН.Text = "ИНН";
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(155, 314);
            this.txtINN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(159, 20);
            this.txtINN.TabIndex = 43;
            // 
            // Отсрочка
            // 
            this.Отсрочка.AutoSize = true;
            this.Отсрочка.Location = new System.Drawing.Point(444, 367);
            this.Отсрочка.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Отсрочка.Name = "Отсрочка";
            this.Отсрочка.Size = new System.Drawing.Size(55, 13);
            this.Отсрочка.TabIndex = 48;
            this.Отсрочка.Text = "Отсрочка";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 350);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Семейное положение";
            // 
            // txtSemPolozh
            // 
            this.txtSemPolozh.Location = new System.Drawing.Point(156, 348);
            this.txtSemPolozh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSemPolozh.Name = "txtSemPolozh";
            this.txtSemPolozh.Size = new System.Drawing.Size(158, 20);
            this.txtSemPolozh.TabIndex = 50;
            // 
            // txtOgrPoZd
            // 
            this.txtOgrPoZd.Location = new System.Drawing.Point(154, 436);
            this.txtOgrPoZd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOgrPoZd.Name = "txtOgrPoZd";
            this.txtOgrPoZd.Size = new System.Drawing.Size(158, 20);
            this.txtOgrPoZd.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 438);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Ограничения по здоровью";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(327, 438);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 13);
            this.label22.TabIndex = 53;
            this.label22.Text = "Наличие личного транспорта";
            // 
            // txtLichTr
            // 
            this.txtLichTr.Location = new System.Drawing.Point(494, 436);
            this.txtLichTr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLichTr.Name = "txtLichTr";
            this.txtLichTr.Size = new System.Drawing.Size(147, 20);
            this.txtLichTr.TabIndex = 54;
            // 
            // dateTimePristKRab
            // 
            this.dateTimePristKRab.Location = new System.Drawing.Point(330, 536);
            this.dateTimePristKRab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePristKRab.Name = "dateTimePristKRab";
            this.dateTimePristKRab.Size = new System.Drawing.Size(160, 20);
            this.dateTimePristKRab.TabIndex = 55;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(136, 536);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(186, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Когда можете приступить к работе";
            // 
            // rbMilitaryYes
            // 
            this.rbMilitaryYes.AutoSize = true;
            this.rbMilitaryYes.Location = new System.Drawing.Point(424, 330);
            this.rbMilitaryYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMilitaryYes.Name = "rbMilitaryYes";
            this.rbMilitaryYes.Size = new System.Drawing.Size(41, 17);
            this.rbMilitaryYes.TabIndex = 57;
            this.rbMilitaryYes.Text = "Да";
            this.rbMilitaryYes.UseVisualStyleBackColor = true;
            // 
            // rbMilitaryNo
            // 
            this.rbMilitaryNo.AutoSize = true;
            this.rbMilitaryNo.Location = new System.Drawing.Point(494, 330);
            this.rbMilitaryNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMilitaryNo.Name = "rbMilitaryNo";
            this.rbMilitaryNo.Size = new System.Drawing.Size(45, 17);
            this.rbMilitaryNo.TabIndex = 58;
            this.rbMilitaryNo.Text = "Нет";
            this.rbMilitaryNo.UseVisualStyleBackColor = true;
            // 
            // slyzhilRadioBtn
            // 
            this.slyzhilRadioBtn.AutoSize = true;
            this.slyzhilRadioBtn.Location = new System.Drawing.Point(425, 350);
            this.slyzhilRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.slyzhilRadioBtn.Name = "slyzhilRadioBtn";
            this.slyzhilRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.slyzhilRadioBtn.TabIndex = 59;
            this.slyzhilRadioBtn.Text = "Служил";
            this.slyzhilRadioBtn.UseVisualStyleBackColor = true;
            // 
            // neSlyzhilRadioBtn
            // 
            this.neSlyzhilRadioBtn.AutoSize = true;
            this.neSlyzhilRadioBtn.Location = new System.Drawing.Point(494, 350);
            this.neSlyzhilRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neSlyzhilRadioBtn.Name = "neSlyzhilRadioBtn";
            this.neSlyzhilRadioBtn.Size = new System.Drawing.Size(80, 17);
            this.neSlyzhilRadioBtn.TabIndex = 60;
            this.neSlyzhilRadioBtn.Text = "Не служил";
            this.neSlyzhilRadioBtn.UseVisualStyleBackColor = true;
            // 
            // otstEst
            // 
            this.otstEst.AutoSize = true;
            this.otstEst.Location = new System.Drawing.Point(424, 383);
            this.otstEst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otstEst.Name = "otstEst";
            this.otstEst.Size = new System.Drawing.Size(50, 17);
            this.otstEst.TabIndex = 61;
            this.otstEst.Text = "Есть";
            this.otstEst.UseVisualStyleBackColor = true;
            // 
            // otstNet
            // 
            this.otstNet.AutoSize = true;
            this.otstNet.Location = new System.Drawing.Point(494, 383);
            this.otstNet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otstNet.Name = "otstNet";
            this.otstNet.Size = new System.Drawing.Size(45, 17);
            this.otstNet.TabIndex = 62;
            this.otstNet.Text = "Нет";
            this.otstNet.UseVisualStyleBackColor = true;
            // 
            // FormQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 670);
            this.Controls.Add(this.otstNet);
            this.Controls.Add(this.otstEst);
            this.Controls.Add(this.neSlyzhilRadioBtn);
            this.Controls.Add(this.slyzhilRadioBtn);
            this.Controls.Add(this.rbMilitaryNo);
            this.Controls.Add(this.rbMilitaryYes);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dateTimePristKRab);
            this.Controls.Add(this.txtLichTr);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtOgrPoZd);
            this.Controls.Add(this.txtSemPolozh);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Отсрочка);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.ИНН);
            this.Controls.Add(this.datetimeDataVydachi);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPasportVydan);
            this.Controls.Add(this.txtMobPhone);
            this.Controls.Add(this.txtDomphone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGenerateWord);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSalaryExpectation);
            this.Controls.Add(this.tbEducation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudChildrenCount);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLivingAddress);
            this.Controls.Add(this.txtRegistrationAddress);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormQuestionnaire";
            this.Text = "Задание №17 выполнила: Грачева Н.С.; Анкета";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private PictureBox pbPhoto;
        private Button btnUploadPhoto;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private TextBox txtBirthPlace;
        private TextBox txtRegistrationAddress;
        private TextBox txtLivingAddress;
        private Label label8;
        private Label label9;
        private TextBox txtHealth;
        private NumericUpDown nudChildrenCount;
        private Label label10;
        private Label label11;
        private TextBox tbEducation;
        private TextBox txtSalaryExpectation;
        private Label label12;
        private Label label13;
        private TextBox txtPosition;
        private Button btnGenerateWord;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtDomphone;
        private TextBox txtMobPhone;
        private TextBox txtPasportVydan;
        private Label label17;
        private Label label18;
        private Label label19;
        private DateTimePicker datetimeDataVydachi;
        private Label ИНН;
        private TextBox txtINN;
        private Label Отсрочка;
        private Label label20;
        private TextBox txtSemPolozh;
        private TextBox txtOgrPoZd;
        private Label label21;
        private Label label22;
        private TextBox txtLichTr;
        private DateTimePicker dateTimePristKRab;
        private Label label23;
        private CheckBox rbMilitaryYes;
        private CheckBox rbMilitaryNo;
        private CheckBox slyzhilRadioBtn;
        private CheckBox neSlyzhilRadioBtn;
        private CheckBox otstEst;
        private CheckBox otstNet;
    }
}
