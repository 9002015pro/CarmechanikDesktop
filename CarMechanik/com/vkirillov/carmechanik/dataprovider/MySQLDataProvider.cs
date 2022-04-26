using CarMechanik.com.vkirillov.carmechanik.obj;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanik.com.vkirillov.carmechanik.dataprovider
{
    public class MySQLDataProvider : IDataProvider
    {
       
        

        private MySqlConnection Conn;

        public MySQLDataProvider() { 
            try
            {
                Conn = new MySqlConnection(
                    "Server=home.Kolei.ru;Database=vkirillov;port=3306;UserId=vkirillov;password=130603;");

            }
             catch (Exception)
            {
                
            }
        }


        public async Task<bool> AddServise(Servise servise)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteServise(Servise servise)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditArrangedServise(ArrangedService arrangedService)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditServise(Servise servise)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ArrangedService>> GetAllArrangedServices()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Servise>> GetAllServises()
        {
            List<Servise> servises = new List<Servise>();
            string sql = "SELECT * FROM Service;";
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            var reader = await cmd.ExecuteReaderAsync();
            while (reader.Read())
            {
                Servise servise = new Servise();
                servise.ID = reader.GetInt32(0);
                servise.Name = reader.GetString(1);
                servise.Description = reader.GetString(2);
                servise.Price = reader.GetDecimal(3);
                servises.Add(servise);
            }
            Conn.Close();
            return servises;
        }

        public async Task<Staff> Login(string login, string password)
        {
            string sql = "SELECT * FROM Staff WHERE Login = @login";

            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.Parameters.AddWithValue("@login", login);
            var reader = await cmd.ExecuteReaderAsync();
            Staff staff = new Staff();
            if (reader.Read())
            {
                staff.ID = reader.GetInt32(0);
                staff.FirstName = reader.GetString(1);
                staff.MiddleName = reader.GetString(2);
                staff.LastName = reader.GetString(3);
                staff.Phone = reader.GetInt64(4);
                staff.Address = reader.GetString(5);
                staff.Passport = reader.GetInt64(6);
                staff.DateBirth = reader.GetDateTime(7);
                staff.Gender = reader.GetBoolean(8);
                staff.Login = reader.GetString(9);
                staff.Password = reader.GetString(10);
                if (!staff.Password.Equals(password)) staff = null;
            }
            else staff = null;
            Conn.Close();
            return staff;
        }
    }
}
