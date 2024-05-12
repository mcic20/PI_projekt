using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmRegisterStudent : Form
    {
        public static Student RegisteredStudent { get; set; }

        public FrmRegisterStudent()
        {
            InitializeComponent();
            FacultyRepository facultyRepository = new FacultyRepository();
            cboFaculty.DataSource = facultyRepository.GetFacultyNames();


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            StudentRepository repository = new StudentRepository();
            FacultyRepository facultyRepo = new FacultyRepository();
            Faculty faculty = new Faculty();
            faculty = facultyRepo.GetFacultyId(cboFaculty.Text);
            if (faculty != null)
            {
                Random rand = new Random();
                student.Id = rand.Next();
                student.FirstName = txtFirstName.Text;
                if (student.FirstName != null)
                {
                    student.LastName = txtLastName.Text;
                    student.Email = txtEmail.Text;
                    student.Address = txtAddress.Text;
                    student.City = txtCity.Text;
                    student.Role = "Student";
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.Country = txtCountry.Text;
                    student.Motivation = txtMotivation.Text;
                    student.Faculty = cboFaculty.Text;
                    student.Username = txtUsername.Text;
                    student.Password = txtPassword.Text;
                    student.FieldOfStudy = faculty.FieldOfStudy;
                    try
                    {
                        repository.RegisterStudent(student);
                        RegisteredStudent = student;
                        FrmStudentView frmStudentView = new FrmStudentView();
                        Hide();
                        frmStudentView.ShowDialog();
                        Close();
                    }
                    catch { }
                }
            }
        }

        private void cboFaculty_SelectedValueChanged(object sender, EventArgs e)
        {
            FacultyRepository facultyRepo = new FacultyRepository();
            Faculty faculty = new Faculty();
            faculty = facultyRepo.GetFacultyId(cboFaculty.Text);
            if (faculty != null)
            {
                txtFieldOfStudy.Text = faculty.FieldOfStudy;
            }
        }
    }
}
