using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmStudentChoice : Form
    {
        public FrmStudentChoice()
        {
            InitializeComponent();
            lblError.Visible = false;
            RecommendationRepository repository = new RecommendationRepository();
            FacultyRepository facultyRepository = new FacultyRepository();
            EOSMAdminRepository adminRepository = new EOSMAdminRepository();
            StudentRecommendation recommendation = repository.GetRecommendation(FrmLogin.LoggedStudent.Id);
            txtEOSM.Text = adminRepository.GetAdminId(recommendation.IdEOSM).ToString();
            List<string> recommendations = new List<string>();
            if (facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.EightFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.EightFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty) == "0")
            { }
            else
                recommendations.Add(facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty));
            listboxSuggestions.DataSource = recommendations;
            List<string> first = new List<string>();
            first.Add(" ");
            if (facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.EightFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.EightFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty) == "0")
            { }
            else
                first.Add(facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty));
            cboFirstChoice.DataSource = first;
            List<string> second = new List<string>();
            second.Add(" ");
            if (facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.EightFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.EightFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty) == "0")
            { }
            else
                second.Add(facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty));
            cboSecondChoice.DataSource = second;
            List<string> third = new List<string>();
            third.Add(" ");
            if (facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.FirstFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.SecondFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.ThirdFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.FourthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.FifthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.SixthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.SeventhFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.EightFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.EightFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.NinthFaculty));
            if (facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty) == "0")
            { }
            else
                third.Add(facultyRepository.GetFacultyNamesId(recommendation.TenthFaculty));
            cboThirdChoice.DataSource = third;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentChoice studentChoice = new StudentChoice();
            studentChoice.FirstChoice = cboFirstChoice.Text;
            studentChoice.SecondChoice = cboSecondChoice.Text;
            studentChoice.ThirdChoice = cboThirdChoice.Text;
            studentChoice.IdStudent = FrmLogin.LoggedStudent.Id;
            if (studentChoice.FirstChoice == " " || studentChoice.SecondChoice == " ")
            {
                lblError.Visible = true;
            }
            else
            {
                StudentChoiceRepository studentChoiceRepository = new StudentChoiceRepository();
                studentChoiceRepository.NewChoice(studentChoice);
                FrmStudentView studentView = new FrmStudentView();
                Hide();
                studentView.ShowDialog();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmStudentView studentView = new FrmStudentView();
            Hide();
            studentView.ShowDialog();
            Close();
        }
    }
}
