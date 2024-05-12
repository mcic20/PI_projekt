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
    public partial class FrmECTSEdit : Form
    {
        Student selectedStudent;
        public FrmECTSEdit(Student a)
        {
            InitializeComponent();
            this.Text ="Edit "+ a.ToString()+" ECTS";
            selectedStudent = a;
            txtAddress.Text = a.Address;
            txtCity.Text = a.City;
            txtCountry.Text = a.Country;
            txtFirstName.Text = a.FirstName;
            txtLastName.Text = a.LastName;
            txtMotivation.Text = a.Motivation;
            txtPhoneNumber.Text = a.PhoneNumber;
            txtEmail.Text = a.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmFPAView frmFPAView = new FrmFPAView();
            Hide();
            frmFPAView.ShowDialog();
            Close();
        }

        private void btnECTS_Click(object sender, EventArgs e)
        {
            StudentRepository studentRepository = new StudentRepository();
            int value = (int)numECTS.Value;
            studentRepository.UpdateStudentECTS(selectedStudent, value);
            FrmFPAView frmFPA = new FrmFPAView();
            Hide();
            frmFPA.ShowDialog();
            Close();
        }
    }
}
