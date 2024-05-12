using DBLayer;
using Student_Mobility_Handler.Data;
using Student_Mobility_Handler.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Mobility_Handler.Repositories
{
    public class FinalChoiceRepository
    {
        public void NewFinalChoice(FinalChoice a) { 
            string sql = $"INSERT INTO dbo.FinalChoice (Id,Choice,IdStudent,IdEOSM,Accepted)" +
                $" VALUES('{a.Id}','{a.Choice}','{a.IdStudent}','{a.IdEOSM}','n')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public FinalChoice GetFinalChoice(int a)
        {
            string sql = $"SELECT * FROM dbo.FinalChoice WHERE IdStudent = '{a}'";
            return FetchFinalChoice(sql);
        }

        public List<FinalChoice> GetFinalChoiceList()
        {
            List<FinalChoice> finalChoices = new List<FinalChoice>();
            string sql = $"SELECT * FROM dbo.FinalChoice WHERE Accepted = 'y'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var final = CreateObject(reader);
                finalChoices.Add((FinalChoice)final);
            }
            reader.Close();
            DB.CloseConnection();
            return finalChoices;
        }
        private static FinalChoice FetchFinalChoice(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            FinalChoice finalChoice = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                finalChoice = (FinalChoice)CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return finalChoice;
        }
        private static FinalChoice CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            int idStudent = int.Parse(reader["IdStudent"].ToString());
            string choice = reader["Choice"].ToString();
            int idEOSM = int.Parse(reader["IdEOSM"].ToString());
            string accepted = reader["Accepted"].ToString();
            var finalChoice = new FinalChoice
            {
                Id = id,
                IdStudent = idStudent,
                Choice = choice,
                IdEOSM = idEOSM,
                Accepted = accepted
            };
            return finalChoice;
        }
        public void Accept(int id)
        {
            string sql = $"UPDATE dbo.FinalChoice SET Accepted = 'y' WHERE IdStudent = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM dbo.FinalChoice WHERE IdStudent = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
