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
    public partial class FrmEOSMAdminView : Form
    {
        public FrmEOSMAdminView()
        {
            InitializeComponent();
            StudentRepository repository = new StudentRepository();
            if (FrmLogin.LoggedEOSM != null)
            {
                lblName.Text = FrmLogin.LoggedEOSM.ToString();
                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = repository.GetAllVerifiedStudents();
               
            }
        }

            private void btnRecommend_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            RecommendationRepository recommendationRepository = new RecommendationRepository();
            if (recommendationRepository.GetRecommendation(selectedStudent.Id) == null)
            {
                FrmFacultyRecommendation recommendation = new FrmFacultyRecommendation(selectedStudent);
                Hide();
                recommendation.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            FinalChoiceRepository finalChoiceRepository = new FinalChoiceRepository();
            RecommendationRepository recommendationRepository = new RecommendationRepository();
            StudentChoiceRepository studentChoiceRepository = new StudentChoiceRepository();
            if (studentChoiceRepository.GetStudentChoice(selectedStudent.Id) != null)
            {
                if (finalChoiceRepository.GetFinalChoice(selectedStudent.Id) == null)
                {
                    FrmFinalRecommendationEOSM frmFinal = new FrmFinalRecommendationEOSM(selectedStudent);
                    Hide();
                    frmFinal.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Student was already given final recommendation.", "Problem", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            List<Student> students = StudentRepository.SearchRequest(text);
            dgvStudents.DataSource = students;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAcceptedFinalRecommends frmAccepted = new FrmAcceptedFinalRecommends();
            frmAccepted.ShowDialog();
        }
    }
}
