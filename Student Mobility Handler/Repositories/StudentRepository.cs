using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;

namespace Student_Mobility_Handler.Repositories
{
    public class StudentRepository
    {
        public void RegisterStudent(Student student)
        {
            string sql = $"INSERT INTO dbo.Student (Id,FirstName,LastName,Role,Country,City,Address,Email,PhoneNumber,Motivation,Faculty,FieldOfStudy,Username,Password)" +
               $"VALUES('{student.Id}','{student.FirstName}','{student.LastName}','{student.Role}','{student.Country}','{student.City}','{student.Address}','{student.Email}','{student.PhoneNumber}','{student.Motivation}','{student.Faculty}','{student.FieldOfStudy}','{student.Username}','{student.Password}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
            public Student GetStudentwithId(int a)
            {
                Student student = new Student();
                string sql = $"SELECT * FROM dbo.Student WHERE Id = '{a}'";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    student = (Student)CreateObject(reader);
                    
                }
                reader.Close();
                DB.CloseConnection();
                return student;
            }
        public List<Student> GetStudentsFromFacultyView(string a)
        {
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM dbo.Student WHERE Faculty = '{a}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var student = CreateObject(reader);
                students.Add((Student)student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public List<Student> GetAllVerifiedStudents()
        {
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM dbo.Student WHERE ECTS > 0";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var student = CreateObject(reader);
                students.Add((Student)student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        private static object CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastNAme"].ToString();
            string role = reader["Role"].ToString();
            string country = reader["Country"].ToString();
            string city = reader["City"].ToString();
            string address = reader["Address"].ToString();
            string email = reader["Email"].ToString();
            string phoneNumber = reader["PhoneNumber"].ToString();
            string motivation = reader["Motivation"].ToString();
            string faculty = reader["Faculty"].ToString();
            string ects = reader["ECTS"].ToString();
            string fieldOfStudy = reader["FieldOfStudy"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Role = role,
                Country = country,
                City = city,
                Address = address,
                Email = email,
                PhoneNumber = phoneNumber,
                Motivation = motivation,
                Faculty = faculty,
                ECTS = ects,
                FieldOfStudy = fieldOfStudy,
                Username = username,
                Password = password
            };
            return student;
        }
        public static List<Student> SearchRequestFPA(string text,string faculty)
        {
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM dbo.Student WHERE (FirstName LIKE '%{text}%' AND Faculty = '{faculty}') OR (LastName LIKE '%{text}%' AND Faculty = '{faculty}') OR (Address LIKE '%{text}%' AND Faculty = '{faculty}') OR (Email LIKE '%{text}%' AND Faculty = '{faculty}') OR (PhoneNumber LIKE '%{text}%' AND Faculty = '{faculty}') OR (Country LIKE '%{text}%' AND Faculty = '{faculty}')";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var student = CreateObject(reader);
                students.Add((Student)student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public static List<Student> SearchRequest(string text)
        {
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM dbo.Student WHERE (FirstName LIKE '%{text}%' AND ECTS IS NOT NULL) OR (LastName LIKE '%{text}%' AND ECTS IS NOT NULL) OR (Address LIKE '%{text}%' AND ECTS IS NOT NULL) OR (Email LIKE '%{text}%' AND ECTS IS NOT NULL) OR (PhoneNumber LIKE '%{text}%' AND ECTS IS NOT NULL) OR (Country LIKE '%{text}%' AND ECTS IS NOT NULL)";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var student = CreateObject(reader);
                students.Add((Student)student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public static Student GetStudent(string username)
        {
            string sql = $"SELECT * FROM dbo.Student WHERE Username = '{username}'";
            return FetchStudent(sql);
        }

        private static Student FetchStudent(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Student student = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                student =(Student) CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }

        public void UpdateStudent(Student student)
        {
            string sql = $"UPDATE dbo.Student SET FirstName = '{student.FirstName}',LastName = '{student.LastName}',Country='{student.Country}',City='{student.City}',Address='{student.Address}',Email='{student.Email}',PhoneNumber='{student.PhoneNumber}',Motivation='{student.Motivation}'" +
               $"WHERE Id='{student.Id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void UpdateStudentECTS(Student student,int a)
        {
            string sql = $"UPDATE dbo.Student SET ECTS = '{a}'" +
               $"WHERE Id='{student.Id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
