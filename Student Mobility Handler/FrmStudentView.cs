using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmStudentView : Form
    {
        public FrmStudentView()
        {
            InitializeComponent();
            if (FrmLogin.LoggedStudent != null)
            {
                StudentChoiceRepository studentChoiceRepository = new StudentChoiceRepository();
                RecommendationRepository recommendation = new RecommendationRepository();
                FinalChoiceRepository choiceRepository = new FinalChoiceRepository();
                lblName.Text = FrmLogin.LoggedStudent.ToString();
                lblFaculty.Text = FrmLogin.LoggedStudent.Faculty;
                StudentChoice choice = new StudentChoice();
                choice = studentChoiceRepository.GetStudentChoice(FrmLogin.LoggedStudent.Id);
                StudentRecommendation studentRecommendation = new StudentRecommendation();
                studentRecommendation = recommendation.GetRecommendation(FrmLogin.LoggedStudent.Id);
                FinalChoice finalChoice = new FinalChoice();
                finalChoice = choiceRepository.GetFinalChoice(FrmLogin.LoggedStudent.Id);
                if (studentRecommendation != null)
                {
                    lblWait.Visible = false;
                    btnFinal.Enabled = false;
                    if (choice != null)
                    {
                        btnPossibleFaculties.Enabled = false;
                        btnChoices.Enabled = true;
                        if (finalChoice != null) {
                            btnFinal.Enabled = true;
                            if(finalChoice.Accepted == "y") {
                                btnFinal.Enabled = false;
                                lblWait.Visible = true;
                                lblWait.Text = "Congratulations! You will be going to " + finalChoice.Choice + ".";
                            }
                        }
                    }
                    if (choice == null)
                    {
                        btnPossibleFaculties.Enabled = true;
                        btnChoices.Enabled = false;
                        btnFinal.Enabled = false;
                    }
                }
                else
                {
                    lblWait.Visible = true;
                    btnPossibleFaculties.Enabled = false;
                    btnChoices.Enabled = false;
                    btnFinal.Enabled = false;
                }
            }
            else
            {
                lblName.Text = FrmRegisterStudent.RegisteredStudent.ToString();
                lblFaculty.Text = FrmRegisterStudent.RegisteredStudent.Faculty;
                lblWait.Visible = true;
                btnPossibleFaculties.Enabled = false;
                btnChoices.Enabled = false;
                btnFinal.Enabled = false;

            }
        }

        private void btnPossibleFaculties_Click(object sender, EventArgs e)
        {
            FrmStudentChoice studentChoice = new FrmStudentChoice();
            Hide();
            studentChoice.ShowDialog();
            Close();
        }

        private void btnChoices_Click(object sender, EventArgs e)
        {
            FrmStudentChoiceView frmStudentChoiceView = new FrmStudentChoiceView();
            frmStudentChoiceView.ShowDialog();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            FrmStudentFinalChoice finalChoice = new FrmStudentFinalChoice();
            Hide();
            finalChoice.ShowDialog();
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditStudentInfo frmEditStudentInfo = new FrmEditStudentInfo();
            Hide();
            frmEditStudentInfo.ShowDialog();
            Close();
        }
    }
}
