using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;

namespace Student_Mobility_Handler
{
    public partial class FrmDetailStudentInfo : Form
    {
        public FrmDetailStudentInfo(Student student)
        {
            InitializeComponent();
            this.Text = student.ToString();
            txtAddress.Text = student.Address;
            txtCity.Text = student.City;
            txtCountry.Text = student.Country;
            txtECTS.Text = student.ECTS;
            txtEmail.Text = student.Email;
            txtFieldOfStudy.Text = student.FieldOfStudy;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtMotivation.Text = student.Motivation;
            txtFaculty.Text = student.Faculty;
            txtPhoneNumber.Text = student.PhoneNumber;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
