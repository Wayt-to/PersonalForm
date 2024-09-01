using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace PersonalForm
{
    public partial class Form1 : Form
    {
        string genderSelection;
        string relationSelection;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "C:/Users/61vah/Desktop/Personal Information Forms";
            tb_langLevel.Text = "English - C1 etc...";
            tb_langLevel.ForeColor = Color.Gray;
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo item in files)
            {
                lb_personalInfo.Items.Add(item.Name + "\n");

            }
        }

        private void tb_langLevel_Enter(object sender, EventArgs e)
        {
            if (tb_langLevel.Text == "English - C1 etc...")
            {
                tb_langLevel.Text = "";
                tb_langLevel.ForeColor = Color.Black;
            }
        }

        private void tb_langLevel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_langLevel.Text))
            {
                tb_langLevel.Text = "English - C1 etc...";
                tb_langLevel.ForeColor = Color.Gray;
            }
        }

        private void rb_foreignYes_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_foreignYes.Checked)
            {
                cb_foreignNumber.Enabled = false;
                tb_langLevel.Enabled = false;

            }
            else
            {
                cb_foreignNumber.Enabled = true;
                tb_langLevel.Enabled = true;
            }
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            //Checking if all fields are filled
            if (tb_name.Text!=""&&tb_surname.Text!=""&&tb_fatherName.Text!=""&&mtb_id.Text!= "___________"&&cb_citizen.Text!=""&&mtb_phone.Text!= "(___)___-____"&&tb_adress.Text!=""&&cb_education.Text!=""&&cb_child.Text!=""&&cb_department.Text!="")
            {   
                string path = "C:/Users/61vah/Desktop/Personal Information Forms";
                if (rb_genderMale.Checked)
                {
                    genderSelection = "Male";
                }
                if (rb_genderFemale.Checked)
                {
                    genderSelection = "Female";
                }

                if (rb_single.Checked)
                {
                    relationSelection = "Single";
                }
                if (rb_married.Checked)
                {
                    relationSelection = "Married";
                }

                string text = $"Name: {tb_name.Text}\nSurname: {tb_surname.Text}\nFather Name : {tb_fatherName.Text}\nID Number : {mtb_id.Text} \nCitizenship: {cb_citizen.SelectedItem}\nBirshplace: {tb_birthplace.Text}\nGender: {genderSelection}\nPhone Number : {mtb_phone.Text}\nAdress: {tb_adress.Text}\nEducation Level : {cb_education.SelectedItem}\nRelationship: {relationSelection}\nChildren: {cb_child.SelectedItem}";
                if (rb_foreignYes.Checked && tb_langLevel.Text != "English - C1 etc...")
                {
                    text += $"\nThe personal knows {cb_foreignNumber.SelectedItem} foreign languages.\nForeign Languages and Levels:\n{tb_langLevel.Text}";
                }
                text += $"\nDepartment : {cb_department.SelectedItem}\n\nInspector's note: {tb_note.Text}\n";

                //Creating and opening the personal info file
                using (FileStream fs = new FileStream(path + $"/{tb_name.Text} {tb_surname.Text}_{mtb_id.Text}.txt", FileMode.OpenOrCreate))
                {
                    byte[] textByte = Encoding.ASCII.GetBytes(text);//Filling information .txt file.
                    fs.Write(textByte, 0, textByte.Length);
                    lbl_message.Text = "Created AND Wroted";
                    DirectoryInfo di = new DirectoryInfo(path + $"/{tb_name.Text} {tb_surname.Text}_{mtb_id.Text}.txt");
                    lb_personalInfo.Items.Add(di.Name + "\n");
                }
            }
            else
            {
                lbl_message.Text = "Her alanı doldurduğunuzdan emin olun.";
            }
            
            #region lbl text

            //lbl_infoTotal.Text = $"Name : {tb_name.Text}\nSurname : {tb_surname.Text}\nFather Name : {tb_fatherName.Text}\nID Number : {mtb_id.Text} \nCitizenship : {cb_citizen.SelectedItem}\nBirshplace : {tb_birthplace.Text}\nGender : {genderSelection}\nPhone Number : {mtb_phone.Text}\nAdress : {tb_adress.Text}\nEducation Level : {cb_education.SelectedItem}\nRelationship : {relationSelection}\nChildren : {cb_child.SelectedItem}";
            //if (rb_foreignYes.Checked && tb_langLevel.Text!="English - C1 etc...")
            //{
            //    lbl_infoTotal.Text += $"\nThe personal knows {cb_foreignNumber.SelectedItem} foreign languages.\nForeign Languages and Levels:\n{tb_langLevel.Text}";
            //}
            //lbl_infoTotal.Text += $"\nDepartment : {cb_department.SelectedItem}\n\nInspector's note: {tb_note.Text}\n";
            #endregion
        }

        private void rb_single_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_single.Checked)
            {
                relationSelection = "Single";
            }
            if (rb_married.Checked)
            {
                relationSelection = "Married";
            }
        }
    }
}
