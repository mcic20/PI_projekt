using DBLayer;
using Student_Mobility_Handler.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Repositories
{
    public class StudentChoiceRepository
    {
        public void NewChoice(StudentChoice a)
        {
            string sql = $"INSERT INTO dbo.StudentChoice (IdStudent,First,Second,Third)" +
                $" VALUES('{a.IdStudent}','{a.FirstChoice}','{a.SecondChoice}','{a.ThirdChoice}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public StudentChoice GetStudentChoice(int a)
        {
            string sql = $"SELECT * FROM dbo.StudentChoice WHERE IdStudent = '{a}'";
            return FetchStudentChoice(sql);
        }

        private static StudentChoice FetchStudentChoice(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            StudentChoice choice = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                choice = (StudentChoice)CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return choice;
        }

        private static StudentChoice CreateObject(SqlDataReader reader)
        {
            int idStudent = int.Parse(reader["IdStudent"].ToString());
            string first = reader["First"].ToString();
            string second = reader["Second"].ToString();
            string third = reader["Third"].ToString();
            var choice = new StudentChoice
            {
                IdStudent = idStudent,
                FirstChoice = first,
                SecondChoice = second,
                ThirdChoice = third,
            };
            return choice;
        }

        public void Delete(int id)
        {
            string sql = $"DELETE FROM dbo.StudentChoice WHERE IdStudent = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }
    }
}
