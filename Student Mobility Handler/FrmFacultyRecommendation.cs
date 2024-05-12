using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmFacultyRecommendation : Form
    {
        Student a;
        public FrmFacultyRecommendation(Student student)
        {
            InitializeComponent();
            a = student;
            txtFirstName.Text = student.ToString();
            txtFieldOfStudy.Text = student.FieldOfStudy;
            txtFaculty.Text = student.Faculty;
            txtECTS.Text = student.ECTS;
            FacultyRepository faculty = new FacultyRepository();
            cboFirst.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboSecond.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboThird.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboFourth.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboFifth.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboSixth.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboSeventh.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboEight.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboNinth.DataSource = faculty.GetFaculties(student.FieldOfStudy);
            cboTenth.DataSource = faculty.GetFaculties(student.FieldOfStudy);
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            StudentRecommendation studentRecommendation = new StudentRecommendation();
            FacultyRepository faculty = new FacultyRepository();
            RecommendationRepository repository = new RecommendationRepository();

            Faculty one = new Faculty();
            one = faculty.GetFacultyId(cboFirst.Text.Split(',')[0]);
            if (one != null)
            {
                studentRecommendation.FirstFaculty = one.Id;
            }
            Faculty two = new Faculty();
            two = faculty.GetFacultyId(cboSecond.Text.Split(',')[0]);
            if (two != null)
            {
                studentRecommendation.SecondFaculty = two.Id;
            }
            Faculty three = new Faculty();
            three = faculty.GetFacultyId(cboThird.Text.Split(',')[0]);
            if (three != null)
            {
                studentRecommendation.ThirdFaculty = three.Id;
            }
            Faculty four = new Faculty();
            four = faculty.GetFacultyId(cboFourth.Text.Split(',')[0]);
            if (four != null)
            {
                studentRecommendation.FourthFaculty = four.Id;
            }
            Faculty five = new Faculty();
            five = faculty.GetFacultyId(cboFifth.Text.Split(',')[0]);
            if (five != null)
            {
                studentRecommendation.FifthFaculty = five.Id;
            }
            Faculty six = new Faculty();
            six = faculty.GetFacultyId(cboSixth.Text.Split(',')[0]);
            if (six != null)
            {
                studentRecommendation.SixthFaculty = six.Id;
            }
            Faculty seven = new Faculty();
            seven = faculty.GetFacultyId(cboSeventh.Text.Split(',')[0]);
            if (seven != null)
            {
                studentRecommendation.SeventhFaculty = seven.Id;
            }
            Faculty eight = new Faculty();
            eight = faculty.GetFacultyId(cboEight.Text.Split(',')[0]);
            if (eight != null)
            {
                studentRecommendation.EightFaculty = eight.Id;
            }
            Faculty nine = new Faculty();
            nine = faculty.GetFacultyId(cboNinth.Text.Split(',')[0]);
            if (nine != null)
            {
                studentRecommendation.NinthFaculty = nine.Id;
            }
            Faculty ten = new Faculty();
            ten = faculty.GetFacultyId(cboTenth.Text.Split(',')[0]);
            if (ten != null)
            {
                studentRecommendation.TenthFaculty = ten.Id;
            }
            repository.NewRecommendation(studentRecommendation, a.Id, FrmLogin.LoggedEOSM.Id);
            FrmEOSMAdminView frmEOSMAdminView = new FrmEOSMAdminView();
            Hide();
            frmEOSMAdminView.ShowDialog();
            Close();

        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            FrmDetailStudentInfo frmDetailStudentInfo = new FrmDetailStudentInfo(a);
            frmDetailStudentInfo.ShowDialog();
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
