using Student_Mobility_Handler.Data;
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
    public partial class FrmStudentFinalChoice : Form
    {
        public FrmStudentFinalChoice()
        {
            InitializeComponent();
            FinalChoiceRepository finalChoiceRepository = new FinalChoiceRepository();
            EOSMAdminRepository adminRepository = new EOSMAdminRepository();
            FinalChoice finalChoice = new FinalChoice();
           finalChoice = finalChoiceRepository.GetFinalChoice(FrmLogin.LoggedStudent.Id);
            txtEOSM.Text = adminRepository.GetAdminId(finalChoice.IdEOSM).ToString();
            txtFinalChoice.Text = finalChoice.Choice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmStudentView studentView = new FrmStudentView();
            Hide();
            studentView.ShowDialog();
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FinalChoiceRepository finalChoice = new FinalChoiceRepository();
            finalChoice.Accept(FrmLogin.LoggedStudent.Id);
            FrmStudentView frmStudentView = new FrmStudentView();
            Hide();
            frmStudentView.ShowDialog();
            Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            FinalChoiceRepository reChoice = new FinalChoiceRepository();
            StudentChoiceRepository studentChoice = new StudentChoiceRepository();
            RecommendationRepository recommendation = new RecommendationRepository();
            reChoice.Delete(FrmLogin.LoggedStudent.Id);
            studentChoice.Delete(FrmLogin.LoggedStudent.Id);
            recommendation.Delete(FrmLogin.LoggedStudent.Id);
            FrmStudentView frmStudentView2 = new FrmStudentView();
            Hide();
            frmStudentView2.ShowDialog();
            Close(); 
        }
    }
}
