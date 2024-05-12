using DBLayer;
using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Repositories
{
    public class RecommendationRepository
    {
        public void NewRecommendation(StudentRecommendation a, int idStudent, int idEOSM)
        {
            string sql = $"INSERT INTO dbo.Recommendation (First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth,Ninth,Tenth,IdStudent,IdEOSM)" +
                $" VALUES('{a.FirstFaculty}','{a.SecondFaculty}','{a.ThirdFaculty}','{a.FourthFaculty}','{a.FifthFaculty}','{a.SixthFaculty}','{a.SeventhFaculty}','{a.EightFaculty}','{a.NinthFaculty}','{a.TenthFaculty}','{idStudent}','{idEOSM}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public StudentRecommendation GetRecommendation(int a)
        {
            string sql = $"SELECT * FROM dbo.Recommendation WHERE IdStudent = '{a}'";
            return FetchRecommendation(sql);
        }

        private static StudentRecommendation FetchRecommendation(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            StudentRecommendation recommendation = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                recommendation = (StudentRecommendation)CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return recommendation;
        }

        private static StudentRecommendation CreateObject(SqlDataReader reader)
        {
            int idStudent = int.Parse(reader["IdStudent"].ToString());
            int first = int.Parse(reader["First"].ToString());
            int second = int.Parse(reader["Second"].ToString());
            int third = int.Parse(reader["Third"].ToString());
            int fourth = int.Parse(reader["Fourth"].ToString());
            int fifth = int.Parse(reader["Fifth"].ToString());
            int sixth = int.Parse(reader["Sixth"].ToString());
            int seventh = int.Parse(reader["Seventh"].ToString());
            int eighth = int.Parse(reader["Eighth"].ToString());
            int nighth = int.Parse(reader["Ninth"].ToString());
            int tenth = int.Parse(reader["Tenth"].ToString());
            int idEOSM = int.Parse(reader["IdEOSM"].ToString());
            var recommendation = new StudentRecommendation
            {
                 IdStudent = idStudent,
                 IdEOSM = idEOSM,
                 FirstFaculty = first,
                 SecondFaculty = second,
                 ThirdFaculty = third,
                 FourthFaculty = fourth,
                 FifthFaculty = fifth,
                 SixthFaculty= sixth,
                 SeventhFaculty = seventh,
                 EightFaculty = eighth,
                 NinthFaculty = nighth,
                 TenthFaculty = tenth
            };
            return recommendation;
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM dbo.Recommendation WHERE IdStudent = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }
    }
}
