using DBLayer;
using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Repositories
{
    public class EOSMAdminRepository
    {
        public static EOSMAdmin GetAdmin(string username)
        {
            string sql = $"SELECT * FROM dbo.EOSMAdmin WHERE Username = '{username}'";
            return FetchAdmin(sql);
        }
        public EOSMAdmin GetAdminId(int a)
        {
            string sql = $"SELECT * FROM dbo.EOSMAdmin WHERE Id = '{a}'";
            return FetchAdmin(sql);
        }

        private static EOSMAdmin FetchAdmin(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            EOSMAdmin admin = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                admin = (EOSMAdmin)CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return admin;
        }

        private static EOSMAdmin CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var admin = new EOSMAdmin
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
            };
            return admin;
        }
    }
}
