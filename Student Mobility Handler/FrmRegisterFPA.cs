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
    public partial class FrmRegisterFPA : Form
    {
        public static FPA RegisteredFPA { get; set; }
        public FrmRegisterFPA()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FPA fpa = new FPA();
            Faculty faculty = new Faculty();
            Random random = new Random();
            FPARepository fPARepository = new FPARepository();
            FacultyRepository facultyRepository = new FacultyRepository();
            if (txtUsername.Text != null)
            {
                fpa.Id = random.Next();
                fpa.Username = txtUsername.Text;
                fpa.Password = txtPassword.Text;
                fpa.Role = "FPA";
                fpa.Email = txtEmail.Text;
                fpa.PhoneNumber = txtPhoneNumber.Text;
                fpa.FirstName = txtFirstName.Text;
                fpa.LastName = txtLastName.Text;
                fpa.Faculty = txtFaculty.Text;
                fpa.FieldOfStudy = txtFieldOfStudy.Text;
                if (fpa.Faculty != null)
                {
                    faculty.Id = random.Next();
                    faculty.University = txtUniversity.Text;
                    faculty.Name = txtFaculty.Text;
                    faculty.Address = txtFacultyAddress.Text;
                    faculty.Country = txtCountry.Text;
                    faculty.FieldOfStudy = txtFieldOfStudy.Text;
                    try
                    {
                        fPARepository.RegisterFPA(fpa);
                        RegisteredFPA = fpa;
                        facultyRepository.RegisterFaculty(faculty);
                        FrmFPAView frmFPAView = new FrmFPAView();
                        Hide();
                        frmFPAView.ShowDialog();
                        Close();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
