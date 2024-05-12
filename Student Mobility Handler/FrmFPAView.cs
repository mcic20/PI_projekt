using Student_Mobility_Handler.Models;
using Student_Mobility_Handler.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmFPAView : Form
    {
        public FrmFPAView()
        {
            InitializeComponent();
            StudentRepository repository = new StudentRepository();
            if (FrmLogin.LoggedFPA != null)
            {
                lblName.Text = FrmLogin.LoggedFPA.ToString();
                lblFaculty.Text = FrmLogin.LoggedFPA.Faculty;
                string faculty = FrmLogin.LoggedFPA.Faculty;
                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = repository.GetStudentsFromFacultyView(faculty);
                if (dgvStudents.Rows.Count == 0)
                {
                    btnAddECTS.Enabled = false;
                    btnEdit.Enabled = false;
                    btnMoreInfo.Enabled = false;
                }
            }
            else
            {
                lblName.Text = FrmRegisterFPA.RegisteredFPA.ToString();
                lblFaculty.Text = FrmRegisterFPA.RegisteredFPA.Faculty;
                string faculty = FrmRegisterFPA.RegisteredFPA.Faculty;
                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = repository.GetStudentsFromFacultyView(faculty);
                if (dgvStudents.Rows.Count == 0)
                {
                    btnAddECTS.Enabled = false;
                    btnEdit.Enabled = false;
                    btnMoreInfo.Enabled = false;
                }
            }


        }

        private void btnAddECTS_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent.ECTS == "")
            {
                FrmECTSView frmECTSView = new FrmECTSView(selectedStudent);
                Hide();
                frmECTSView.ShowDialog();
                Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (FrmLogin.LoggedFPA != null) {
                List<Student> students = StudentRepository.SearchRequestFPA(text, FrmLogin.LoggedFPA.Faculty);
                dgvStudents.DataSource = students;
            }
            else
            {
                List<Student> students = StudentRepository.SearchRequestFPA(text, FrmRegisterFPA.RegisteredFPA.Faculty);
                dgvStudents.DataSource = students;
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            FrmDetailStudentInfo frmDetailStudentInfo = new FrmDetailStudentInfo(selectedStudent);
            frmDetailStudentInfo.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent.ECTS != "")
            {
                FrmECTSEdit frmECTSEdit = new FrmECTSEdit(selectedStudent);
                Hide();
                frmECTSEdit.ShowDialog();
                Close();
            }

        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            FrmEditFPAInfo frmEditinfo = new FrmEditFPAInfo();
            Hide();
            frmEditinfo.ShowDialog();
            Close();
        }
    }
}
