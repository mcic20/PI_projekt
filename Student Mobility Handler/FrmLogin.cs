using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmLogin : Form
    {
        public static FPA LoggedFPA { get; set; }
        public static Student LoggedStudent { get; set; }
        public static EOSMAdmin LoggedEOSM { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is not entered!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is not entered!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                LoggedFPA = FPARepository.GetFPA(txtUsername.Text);
                LoggedStudent = StudentRepository.GetStudent(txtUsername.Text); 
                LoggedEOSM = EOSMAdminRepository.GetAdmin(txtUsername.Text);
                if (LoggedFPA != null && LoggedFPA.CheckPassword(txtPassword.Text))
                {
                    FrmFPAView students = new FrmFPAView();
                    Hide();
                    students.ShowDialog();
                    Close();
                }
               if(LoggedStudent != null && LoggedStudent.CheckPassword(txtPassword.Text))
                {
                    FrmStudentView student = new FrmStudentView();
                    Hide();
                    student.ShowDialog();
                    Close();
                }
                if (LoggedEOSM != null && LoggedEOSM.CheckPassword(txtPassword.Text))
                {
                    FrmEOSMAdminView eosm = new FrmEOSMAdminView();
                    Hide();
                    eosm.ShowDialog();
                    Close();
                }

                else
                {
                  MessageBox.Show("Wrong credentials!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string a = cboRole.Text;
            if (a=="Student")
            {
                FrmRegisterStudent student = new FrmRegisterStudent();
                Hide();
                student.ShowDialog();
                Close();
            }
            if (a == "FP Administrator")
            {
                FrmRegisterFPA admin = new FrmRegisterFPA();
                Hide();
                admin.ShowDialog();
                Close();
            }
        }
    }  
}
