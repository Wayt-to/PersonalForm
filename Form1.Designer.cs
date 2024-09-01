namespace PersonalForm
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
            this.gb_personalInfo = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.mtb_id = new System.Windows.Forms.MaskedTextBox();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.gb_rel = new System.Windows.Forms.GroupBox();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.rb_married = new System.Windows.Forms.RadioButton();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.gb_foreign = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_langLevel = new System.Windows.Forms.TextBox();
            this.cb_foreignNumber = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rb_foreignNo = new System.Windows.Forms.RadioButton();
            this.rb_foreignYes = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.gb_gender = new System.Windows.Forms.GroupBox();
            this.rb_genderMale = new System.Windows.Forms.RadioButton();
            this.rb_genderFemale = new System.Windows.Forms.RadioButton();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_child = new System.Windows.Forms.ComboBox();
            this.cb_education = new System.Windows.Forms.ComboBox();
            this.cb_citizen = new System.Windows.Forms.ComboBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_birthplace = new System.Windows.Forms.TextBox();
            this.tb_fatherName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_personalInfo = new System.Windows.Forms.ListBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.gb_personalInfo.SuspendLayout();
            this.gb_rel.SuspendLayout();
            this.gb_foreign.SuspendLayout();
            this.gb_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_personalInfo
            // 
            this.gb_personalInfo.Controls.Add(this.btn_save);
            this.gb_personalInfo.Controls.Add(this.mtb_id);
            this.gb_personalInfo.Controls.Add(this.mtb_phone);
            this.gb_personalInfo.Controls.Add(this.gb_rel);
            this.gb_personalInfo.Controls.Add(this.tb_note);
            this.gb_personalInfo.Controls.Add(this.gb_foreign);
            this.gb_personalInfo.Controls.Add(this.label15);
            this.gb_personalInfo.Controls.Add(this.gb_gender);
            this.gb_personalInfo.Controls.Add(this.cb_department);
            this.gb_personalInfo.Controls.Add(this.tb_adress);
            this.gb_personalInfo.Controls.Add(this.label14);
            this.gb_personalInfo.Controls.Add(this.cb_child);
            this.gb_personalInfo.Controls.Add(this.cb_education);
            this.gb_personalInfo.Controls.Add(this.cb_citizen);
            this.gb_personalInfo.Controls.Add(this.tb_surname);
            this.gb_personalInfo.Controls.Add(this.label5);
            this.gb_personalInfo.Controls.Add(this.label4);
            this.gb_personalInfo.Controls.Add(this.label3);
            this.gb_personalInfo.Controls.Add(this.tb_birthplace);
            this.gb_personalInfo.Controls.Add(this.tb_fatherName);
            this.gb_personalInfo.Controls.Add(this.label13);
            this.gb_personalInfo.Controls.Add(this.tb_name);
            this.gb_personalInfo.Controls.Add(this.label10);
            this.gb_personalInfo.Controls.Add(this.label2);
            this.gb_personalInfo.Controls.Add(this.label9);
            this.gb_personalInfo.Controls.Add(this.label16);
            this.gb_personalInfo.Controls.Add(this.label8);
            this.gb_personalInfo.Controls.Add(this.label1);
            this.gb_personalInfo.Location = new System.Drawing.Point(14, 14);
            this.gb_personalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_personalInfo.Name = "gb_personalInfo";
            this.gb_personalInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_personalInfo.Size = new System.Drawing.Size(916, 416);
            this.gb_personalInfo.TabIndex = 1;
            this.gb_personalInfo.TabStop = false;
            this.gb_personalInfo.Text = "Personal Information";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_save.Location = new System.Drawing.Point(731, 347);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(159, 48);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save\r\n";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // mtb_id
            // 
            this.mtb_id.Location = new System.Drawing.Point(98, 114);
            this.mtb_id.Mask = "00000000000";
            this.mtb_id.Name = "mtb_id";
            this.mtb_id.Size = new System.Drawing.Size(145, 23);
            this.mtb_id.TabIndex = 8;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(402, 33);
            this.mtb_phone.Mask = "(999) 000-0000";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(165, 23);
            this.mtb_phone.TabIndex = 6;
            // 
            // gb_rel
            // 
            this.gb_rel.Controls.Add(this.rb_single);
            this.gb_rel.Controls.Add(this.rb_married);
            this.gb_rel.Location = new System.Drawing.Point(311, 200);
            this.gb_rel.Name = "gb_rel";
            this.gb_rel.Size = new System.Drawing.Size(256, 56);
            this.gb_rel.TabIndex = 7;
            this.gb_rel.TabStop = false;
            this.gb_rel.Text = "Relationship";
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(7, 22);
            this.rb_single.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(58, 19);
            this.rb_single.TabIndex = 3;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            this.rb_single.CheckedChanged += new System.EventHandler(this.rb_single_CheckedChanged);
            // 
            // rb_married
            // 
            this.rb_married.AutoSize = true;
            this.rb_married.Location = new System.Drawing.Point(76, 22);
            this.rb_married.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_married.Name = "rb_married";
            this.rb_married.Size = new System.Drawing.Size(70, 19);
            this.rb_married.TabIndex = 3;
            this.rb_married.Text = "Married";
            this.rb_married.UseVisualStyleBackColor = true;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(47, 270);
            this.tb_note.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(379, 96);
            this.tb_note.TabIndex = 4;
            // 
            // gb_foreign
            // 
            this.gb_foreign.Controls.Add(this.label11);
            this.gb_foreign.Controls.Add(this.tb_langLevel);
            this.gb_foreign.Controls.Add(this.cb_foreignNumber);
            this.gb_foreign.Controls.Add(this.label12);
            this.gb_foreign.Controls.Add(this.rb_foreignNo);
            this.gb_foreign.Controls.Add(this.rb_foreignYes);
            this.gb_foreign.Location = new System.Drawing.Point(574, 22);
            this.gb_foreign.Name = "gb_foreign";
            this.gb_foreign.Size = new System.Drawing.Size(316, 234);
            this.gb_foreign.TabIndex = 5;
            this.gb_foreign.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Foreign Language";
            // 
            // tb_langLevel
            // 
            this.tb_langLevel.Location = new System.Drawing.Point(129, 74);
            this.tb_langLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_langLevel.Multiline = true;
            this.tb_langLevel.Name = "tb_langLevel";
            this.tb_langLevel.Size = new System.Drawing.Size(172, 154);
            this.tb_langLevel.TabIndex = 4;
            this.tb_langLevel.Enter += new System.EventHandler(this.tb_langLevel_Enter);
            this.tb_langLevel.Leave += new System.EventHandler(this.tb_langLevel_Leave);
            // 
            // cb_foreignNumber
            // 
            this.cb_foreignNumber.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_foreignNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_foreignNumber.FormattingEnabled = true;
            this.cb_foreignNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cb_foreignNumber.Location = new System.Drawing.Point(12, 43);
            this.cb_foreignNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_foreignNumber.Name = "cb_foreignNumber";
            this.cb_foreignNumber.Size = new System.Drawing.Size(289, 22);
            this.cb_foreignNumber.TabIndex = 2;
            this.cb_foreignNumber.Text = "Number of languages ​​known (except native language)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Foreign Languages \r\nand Levels";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_foreignNo
            // 
            this.rb_foreignNo.AutoSize = true;
            this.rb_foreignNo.Location = new System.Drawing.Point(178, 19);
            this.rb_foreignNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_foreignNo.Name = "rb_foreignNo";
            this.rb_foreignNo.Size = new System.Drawing.Size(40, 19);
            this.rb_foreignNo.TabIndex = 3;
            this.rb_foreignNo.Text = "No";
            this.rb_foreignNo.UseVisualStyleBackColor = true;
            // 
            // rb_foreignYes
            // 
            this.rb_foreignYes.AutoSize = true;
            this.rb_foreignYes.Checked = true;
            this.rb_foreignYes.Location = new System.Drawing.Point(118, 18);
            this.rb_foreignYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_foreignYes.Name = "rb_foreignYes";
            this.rb_foreignYes.Size = new System.Drawing.Size(42, 19);
            this.rb_foreignYes.TabIndex = 3;
            this.rb_foreignYes.TabStop = true;
            this.rb_foreignYes.Text = "Yes";
            this.rb_foreignYes.UseVisualStyleBackColor = true;
            this.rb_foreignYes.CheckedChanged += new System.EventHandler(this.rb_foreignYes_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 270);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Note";
            // 
            // gb_gender
            // 
            this.gb_gender.Controls.Add(this.rb_genderMale);
            this.gb_gender.Controls.Add(this.rb_genderFemale);
            this.gb_gender.Location = new System.Drawing.Point(15, 200);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Size = new System.Drawing.Size(228, 56);
            this.gb_gender.TabIndex = 6;
            this.gb_gender.TabStop = false;
            this.gb_gender.Text = "Gender";
            // 
            // rb_genderMale
            // 
            this.rb_genderMale.AutoSize = true;
            this.rb_genderMale.Checked = true;
            this.rb_genderMale.Location = new System.Drawing.Point(7, 22);
            this.rb_genderMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_genderMale.Name = "rb_genderMale";
            this.rb_genderMale.Size = new System.Drawing.Size(53, 19);
            this.rb_genderMale.TabIndex = 3;
            this.rb_genderMale.TabStop = true;
            this.rb_genderMale.Text = "Male";
            this.rb_genderMale.UseVisualStyleBackColor = true;
            // 
            // rb_genderFemale
            // 
            this.rb_genderFemale.AutoSize = true;
            this.rb_genderFemale.Location = new System.Drawing.Point(68, 22);
            this.rb_genderFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_genderFemale.Name = "rb_genderFemale";
            this.rb_genderFemale.Size = new System.Drawing.Size(64, 19);
            this.rb_genderFemale.TabIndex = 3;
            this.rb_genderFemale.Text = "Female";
            this.rb_genderFemale.UseVisualStyleBackColor = true;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_department.Location = new System.Drawing.Point(278, 372);
            this.cb_department.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(148, 23);
            this.cb_department.TabIndex = 2;
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(403, 60);
            this.tb_adress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_adress.Multiline = true;
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(164, 77);
            this.tb_adress.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 375);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Department";
            // 
            // cb_child
            // 
            this.cb_child.FormattingEnabled = true;
            this.cb_child.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_child.Location = new System.Drawing.Point(403, 169);
            this.cb_child.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_child.Name = "cb_child";
            this.cb_child.Size = new System.Drawing.Size(164, 23);
            this.cb_child.TabIndex = 2;
            // 
            // cb_education
            // 
            this.cb_education.FormattingEnabled = true;
            this.cb_education.Items.AddRange(new object[] {
            "Primary Education",
            "Secondary Education",
            "Bachelor\'s Education",
            "Master Education",
            "Doctoral Education"});
            this.cb_education.Location = new System.Drawing.Point(403, 141);
            this.cb_education.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_education.Name = "cb_education";
            this.cb_education.Size = new System.Drawing.Size(164, 23);
            this.cb_education.TabIndex = 2;
            // 
            // cb_citizen
            // 
            this.cb_citizen.FormattingEnabled = true;
            this.cb_citizen.Items.AddRange(new object[] {
            "Turkish Citizen",
            "Foreign Citizen"});
            this.cb_citizen.Location = new System.Drawing.Point(98, 141);
            this.cb_citizen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_citizen.Name = "cb_citizen";
            this.cb_citizen.Size = new System.Drawing.Size(145, 23);
            this.cb_citizen.TabIndex = 2;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(98, 60);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(145, 23);
            this.tb_surname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birthplace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Citizenship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Number";
            // 
            // tb_birthplace
            // 
            this.tb_birthplace.Location = new System.Drawing.Point(98, 169);
            this.tb_birthplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_birthplace.Name = "tb_birthplace";
            this.tb_birthplace.Size = new System.Drawing.Size(145, 23);
            this.tb_birthplace.TabIndex = 1;
            // 
            // tb_fatherName
            // 
            this.tb_fatherName.Location = new System.Drawing.Point(98, 87);
            this.tb_fatherName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_fatherName.Name = "tb_fatherName";
            this.tb_fatherName.Size = new System.Drawing.Size(145, 23);
            this.tb_fatherName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Children";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(98, 33);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(145, 23);
            this.tb_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Education";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Father Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(937, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Saved Personal Files";
            // 
            // lb_personalInfo
            // 
            this.lb_personalInfo.FormattingEnabled = true;
            this.lb_personalInfo.ItemHeight = 15;
            this.lb_personalInfo.Location = new System.Drawing.Point(940, 45);
            this.lb_personalInfo.Name = "lb_personalInfo";
            this.lb_personalInfo.Size = new System.Drawing.Size(196, 379);
            this.lb_personalInfo.TabIndex = 10;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 433);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(55, 15);
            this.lbl_message.TabIndex = 11;
            this.lbl_message.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 633);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lb_personalInfo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gb_personalInfo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_personalInfo.ResumeLayout(false);
            this.gb_personalInfo.PerformLayout();
            this.gb_rel.ResumeLayout(false);
            this.gb_rel.PerformLayout();
            this.gb_foreign.ResumeLayout(false);
            this.gb_foreign.PerformLayout();
            this.gb_gender.ResumeLayout(false);
            this.gb_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_personalInfo;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_citizen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_married;
        private System.Windows.Forms.RadioButton rb_genderFemale;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.RadioButton rb_genderMale;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.TextBox tb_fatherName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_foreignNo;
        private System.Windows.Forms.RadioButton rb_foreignYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_education;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.ComboBox cb_child;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_foreignNumber;
        private System.Windows.Forms.TextBox tb_langLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.GroupBox gb_foreign;
        private System.Windows.Forms.GroupBox gb_gender;
        private System.Windows.Forms.GroupBox gb_rel;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.MaskedTextBox mtb_id;
        private System.Windows.Forms.TextBox tb_birthplace;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox lb_personalInfo;
        private System.Windows.Forms.Label lbl_message;
    }
}

