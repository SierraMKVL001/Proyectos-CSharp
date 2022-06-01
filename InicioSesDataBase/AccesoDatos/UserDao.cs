using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace AccesoDatos
{
   public class UserDao:ConectionSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConection())
            {
                connection.Open();
                using (var command= new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select *from Users where LoginName =@user and Password=@pass";
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheInicioSes.UserId = reader.GetInt32(0);
                            CacheInicioSes.FirstName = reader.GetString(3);
                            CacheInicioSes.LastName = reader.GetString(4);
                            CacheInicioSes.Position = reader.GetString(5);
                            CacheInicioSes.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
