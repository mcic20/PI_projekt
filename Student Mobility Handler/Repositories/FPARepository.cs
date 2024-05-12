using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using Student_Mobility_Handler.Models;

namespace Student_Mobility_Handler.Repositories
{
    public class FPARepository
    {
        public void RegisterFPA(FPA fpa)
        {  
                string sql = $"INSERT INTO dbo.FPA (Id,FirstName,LastName,Role,Email,PhoneNumber,Faculty,FieldOfStudy,Username,Password)" +
                $"VALUES('{fpa.Id}','{fpa.FirstName}','{fpa.LastName}','{fpa.Role}','{fpa.Email}','{fpa.PhoneNumber}','{fpa.Faculty}','{fpa.FieldOfStudy}','{fpa.Username}','{fpa.Password}');";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
        }

        public static FPA GetFPA(string username)
        {
            string sql = $"SELECT * FROM dbo.FPA WHERE Username = '{username}'";
            return FetchFPA(sql);
        }

        private static FPA FetchFPA(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            FPA fpa = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                fpa = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return fpa;
        }
        private static FPA CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string phoneNumber = reader["PhoneNumber"].ToString();
            string email = reader["Email"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string faculty = reader["Faculty"].ToString();
            var fpa = new FPA
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
                Username = username,
                Password = password,
                Faculty = faculty
            };
            return fpa;
        }

        public void VerifyStudent(string a,int id)
        {
            string sql = $"UPDATE dbo.Student SET ECTS = '{a}' WHERE Id = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public void UpdateInfo(FPA a)
        {
            string sql = $"UPDATE dbo.FPA SET FirstName = '{a.FirstName}',LastName = '{a.LastName}',Email = '{a.Email}',PhoneNumber = '{a.PhoneNumber}' WHERE Id = '{a.Id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
