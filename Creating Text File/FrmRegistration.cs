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

namespace Creating_Text_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            string studentNo = txtStudentNo.Text;
            string fileName = studentNo + ".txt"; 

           
            string[] registeredData =
            {
                "Full Name:" + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text + ".",
                "Program: " + cmbProgram.Text,
                "Gender: " + cmbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.:" + txtContactNo.Text
            };

            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(docPath, fileName);

       
                File.WriteAllLines(fullPath, registeredData);

              
                MessageBox.Show($"Registration file successfully created as '{fileName}' in My Documents.", "Success!");
            }
            catch (Exception ex)
            {
           
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

