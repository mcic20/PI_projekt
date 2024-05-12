using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;

namespace Student_Mobility_Handler
{
    public partial class FrmFinalRecommendationEOSM : Form
    {
        Student a;
        public FrmFinalRecommendationEOSM(Student student)
        {
            InitializeComponent();
            a = student;
            StudentChoiceRepository studentChoiceRepository = new StudentChoiceRepository();
            txtFirstName.Text = student.ToString();
            txtFaculty.Text = student.Faculty;
            txtFieldOfStudy.Text = student.FieldOfStudy;
            txtECTS.Text = student.ECTS;
            StudentChoice choice = new StudentChoice();
            choice = studentChoiceRepository.GetStudentChoice(student.Id);
            txtFirstChoice.Text = choice.FirstChoice;
            txtSecondChoice.Text = choice.SecondChoice;
            txtThirdChoice.Text = choice.ThirdChoice;
            List<string> choices = new List<string>();
            choices.Add("");
            choices.Add(choice.FirstChoice);
            choices.Add(choice.SecondChoice);
            choices.Add(choice.ThirdChoice);
            cboFinalChoice.DataSource = choices;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            FinalChoice finalChoice = new FinalChoice();
            Random random = new Random();
            finalChoice.Id = random.Next();
            finalChoice.Choice = cboFinalChoice.Text;
            finalChoice.IdStudent = a.Id;
            finalChoice.IdEOSM = FrmLogin.LoggedEOSM.Id;
            if(finalChoice!=null)
            {
                FinalChoiceRepository finalChoiceRepository = new FinalChoiceRepository();
                finalChoiceRepository.NewFinalChoice(finalChoice);
                FrmEOSMAdminView frmEOSMAdminView = new FrmEOSMAdminView();
                Hide();
                frmEOSMAdminView.ShowDialog();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmEOSMAdminView frmEOSMAdminView = new FrmEOSMAdminView();
            Hide();
            frmEOSMAdminView.ShowDialog();
            Close();
        }
    }
}
