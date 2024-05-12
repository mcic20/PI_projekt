using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Mobility_Handler.Repositories;

namespace Student_Mobility_Handler
{
    public partial class FrmECTSView : Form
    {
        private Student selectedStudent;
        public FrmECTSView(Student a)
        {
            InitializeComponent();
            int i = a.Id;
            selectedStudent = a;
            StudentRepository studentRepository = new StudentRepository();
            Student current = studentRepository.GetStudentwithId(i);
            txtAddress.Text = current.Address;
            txtCity.Text = current.City;
            txtCountry.Text = current.Country;
            txtFirstName.Text = current.FirstName;
            txtLastName.Text = current.LastName;
            txtMotivation.Text = current.Motivation;
            txtPhoneNumber.Text = current.PhoneNumber;
            txtEmail.Text = current.Email;

        }

        private void btnECTS_Click(object sender, EventArgs e)
        {
            int i = selectedStudent.Id;
            string a = numECTS.Value.ToString();
            FPARepository repository = new FPARepository();
            repository.VerifyStudent(a, i);
            FrmFPAView frmFPAView = new FrmFPAView();
            Hide();
            frmFPAView.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmFPAView frmFPAView = new FrmFPAView();
            Hide();
            frmFPAView.ShowDialog();
            Close();
        }
    }
}
