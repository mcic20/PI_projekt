using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmEditStudentInfo : Form
    {
        public FrmEditStudentInfo()
        {
            InitializeComponent();
            Student student = new Student();
            student = FrmLogin.LoggedStudent;
            if (student != null)
            {
                this.Text = student.ToString();
                txtAddress.Text = student.Address;
                txtCity.Text = student.City;
                txtCountry.Text = student.Country;
                txtEmail.Text = student.Email;
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtMotivation.Text = student.Motivation;
                txtPhoneNumber.Text = student.PhoneNumber;
            }
            else
            {
                student = FrmRegisterStudent.RegisteredStudent;
                this.Text = student.ToString();
                txtAddress.Text = student.Address;
                txtCity.Text = student.City;
                txtCountry.Text = student.Country;
                txtEmail.Text = student.Email;
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtMotivation.Text = student.Motivation;
                txtPhoneNumber.Text = student.PhoneNumber;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmStudentView frmStudentView = new FrmStudentView();
            Hide();
            frmStudentView.ShowDialog();
            Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student a = new Student();
            StudentRepository studentRepository = new StudentRepository();
            if (FrmLogin.LoggedStudent != null)
            {
                a.Id = FrmLogin.LoggedStudent.Id;
                a.Address = txtAddress.Text;
                a.City = txtCity.Text;
                a.Country = txtCountry.Text;
                a.Email = txtEmail.Text;
                a.FirstName = txtFirstName.Text;
                a.LastName = txtLastName.Text;
                a.PhoneNumber = txtPhoneNumber.Text;
                a.Motivation = txtMotivation.Text;
                studentRepository.UpdateStudent(a);
                FrmLogin.LoggedStudent.Address = a.Address;
                FrmLogin.LoggedStudent.FirstName = a.FirstName;
                FrmLogin.LoggedStudent.LastName = a.LastName;
                FrmLogin.LoggedStudent.PhoneNumber = a.PhoneNumber;
                FrmLogin.LoggedStudent.Motivation = a.Motivation;
                FrmLogin.LoggedStudent.City = a.City;
                FrmLogin.LoggedStudent.Country = a.Country;
                FrmLogin.LoggedStudent.Email = a.Email;
            }
            else
            {
                a.Id = FrmRegisterStudent.RegisteredStudent.Id;
                a.Address = txtAddress.Text;
                a.City = txtCity.Text;
                a.Country = txtCountry.Text;
                a.Email = txtEmail.Text;
                a.FirstName = txtFirstName.Text;
                a.LastName = txtLastName.Text;
                a.PhoneNumber = txtPhoneNumber.Text;
                a.Motivation = txtMotivation.Text;
                studentRepository.UpdateStudent(a);
                FrmRegisterStudent.RegisteredStudent.Address = a.Address;
                FrmRegisterStudent.RegisteredStudent.FirstName = a.FirstName;
                FrmRegisterStudent.RegisteredStudent.LastName = a.LastName;
                FrmRegisterStudent.RegisteredStudent.PhoneNumber = a.PhoneNumber;
                FrmRegisterStudent.RegisteredStudent.Motivation = a.Motivation;
                FrmRegisterStudent.RegisteredStudent.City = a.City;
                FrmRegisterStudent.RegisteredStudent.Country = a.Country;
                FrmRegisterStudent.RegisteredStudent.Email = a.Email;
            }
            FrmStudentView frmStudentView2 = new FrmStudentView();
            Hide();
            frmStudentView2.ShowDialog();
            Close();
        }
    }
}
