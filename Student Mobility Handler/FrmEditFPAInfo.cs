using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmEditFPAInfo : Form
    {
        public FrmEditFPAInfo()
        {
            InitializeComponent();
            FPA fPA = new FPA();
            fPA = FrmLogin.LoggedFPA;
            if (fPA != null)
            {
                txtEmail.Text = fPA.Email;
                txtFirstName.Text = fPA.FirstName;
                txtLastName.Text = fPA.LastName;
                txtPhoneNumber.Text = fPA.PhoneNumber;
            }
            else
            {
                fPA = FrmRegisterFPA.RegisteredFPA;
                txtEmail.Text = fPA.Email;
                txtFirstName.Text = fPA.FirstName;
                txtLastName.Text = fPA.LastName;
                txtPhoneNumber.Text = fPA.PhoneNumber;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmFPAView frmFPAView = new FrmFPAView();
            Hide();
            frmFPAView.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            FPA fPA = new FPA();
            fPA.Email = txtEmail.Text;
            fPA.FirstName = txtFirstName.Text;
            fPA.LastName = txtLastName.Text;
            fPA.PhoneNumber = txtPhoneNumber.Text;
            if (FrmLogin.LoggedFPA != null)
            {
                fPA.Id = FrmLogin.LoggedFPA.Id;
                FrmLogin.LoggedFPA.FirstName = fPA.FirstName;
                FrmLogin.LoggedFPA.LastName = fPA.LastName;
                FrmLogin.LoggedFPA.Email = fPA.Email;
                FrmLogin.LoggedFPA.PhoneNumber = fPA.PhoneNumber;
            }
            else
            {
                fPA.Id = FrmRegisterFPA.RegisteredFPA.Id;
                FrmRegisterFPA.RegisteredFPA.FirstName = fPA.FirstName;
                FrmRegisterFPA.RegisteredFPA.LastName = fPA.LastName;
                FrmRegisterFPA.RegisteredFPA.PhoneNumber= fPA.PhoneNumber;
                FrmRegisterFPA.RegisteredFPA.Email = fPA.Email;
            }
            FPARepository repository = new FPARepository();
            repository.UpdateInfo(fPA);
            FrmFPAView frmFPA = new FrmFPAView();
            Hide();
            frmFPA.ShowDialog();
            Close();
        }
    }
}
