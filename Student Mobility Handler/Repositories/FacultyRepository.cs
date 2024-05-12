using DBLayer;
using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mobility_Handler.Repositories
{
    public class FacultyRepository
    {
        public void RegisterFaculty(Faculty faculty)
        {
            string sql = $"INSERT INTO dbo.Faculty (Id,University,Name,Address,Country,FieldOfStudy)" +
            $"VALUES('{faculty.Id}','{faculty.University}','{faculty.Name}','{faculty.Address}','{faculty.Country}','{faculty.FieldOfStudy}');";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            string sql = $"SELECT * FROM dbo.Faculty";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var faculty = CreateObject(reader);
                faculties.Add((Faculty)faculty);
            }
            reader.Close();
            DB.CloseConnection();
            return faculties;
        }
        public Faculty GetFacultyId(string a)
        {
            string sql = $"SELECT * FROM dbo.Faculty WHERE Name = '{a}'";
            return FetchFaculty(sql);
        }

        private static Faculty FetchFaculty(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Faculty faculty = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                faculty = (Faculty)CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return faculty;
        }        

        public List<String> GetFaculties(string a)
        {
            List<string> faculties = new List<String>();
            string sql = $"SELECT * FROM dbo.Faculty WHERE FieldOfStudy = '{a}' OR Id = '0'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var faculty = CreateObjectNames(reader);
                faculties.Add(faculty.ToString());
            }
            reader.Close();
            DB.CloseConnection();
            return faculties;
        }
        private static object CreateObjectNames(SqlDataReader reader)
        {
            string name = reader["Name"].ToString();
            string country = reader["Country"].ToString();
            string a;
            var faculty = new Faculty
            {
                Name = name,
                Country = country
            };
            if (faculty.Name != "0")
            {
                a = faculty.Name + ", " + faculty.Country;
            }
            else
            {
                a = "";
            }
            return a;
        }

        public List<string> GetFacultyNames()
        {
            List<string> faculties = new List<string>();
            string sql = $"SELECT * FROM dbo.Faculty";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var faculty = CreateNameObject(reader);
                faculties.Add(faculty.ToString());
            }
            reader.Close();
            DB.CloseConnection();
            return faculties;
        }

        public string GetFacultyNamesId(int a)
        {
            string sql = $"SELECT * FROM dbo.Faculty WHERE Id = '{a}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            string name = null;
            while (reader.Read())
            {
                var faculty = CreateNameObject(reader);
                name = faculty.ToString();
            }
            reader.Close();
            DB.CloseConnection();
            return name;
        }
        private static object CreateNameObject(SqlDataReader reader)
        {
            string name = reader["Name"].ToString();
            var faculty = new Faculty();
            if (name != "0")
            {
                faculty.Name = name;
                
            }
            else
            {
                faculty.Name = " ";
            }
            return faculty.Name;
        }

        private static object CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string university = reader["University"].ToString();
            string address = reader["Address"].ToString();
            string country = reader["Country"].ToString();
            string fieldOfStudy = reader["FieldOfStudy"].ToString();
            var faculty = new Faculty
            {
               Id = id,
               Name = name,
               University = university,
               Address = address,
               Country = country,
               FieldOfStudy = fieldOfStudy
            };
            return faculty;
        }
    }
}
