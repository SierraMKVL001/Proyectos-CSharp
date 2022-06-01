using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao:ConexionDB
    {

        public void editProfile(int id, string nombres,string apellidos,string logName,string password, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Empleados set Nombres=@nombre,Apellidos=@apellido,LogName=@user,Pass=@pass,Email=@mail where idEmp=@id";
                    command.Parameters.AddWithValue("@nombre",nombres);
                    command.Parameters.AddWithValue("@apellido",apellidos);
                    command.Parameters.AddWithValue("@user", logName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id",id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command =new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Empleados where LogName=@user and Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()){
                            UserLoginCache.idEmp = reader.GetInt32(0);
                            UserLoginCache.Nombres = reader.GetString(1);
                            UserLoginCache.Apellidos = reader.GetString(2);
                            UserLoginCache.LoginName = reader.GetString(3);
                            UserLoginCache.Pass = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.idPuesto = reader.GetInt32(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public string recoveryPassword(string userRequest)
        {
                using (var connection = GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Empleados where LogName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequest);
                    command.Parameters.AddWithValue("@mail", userRequest);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string username = reader.GetString(1) + " " + reader.GetString(2);
                        string usermail = reader.GetString(5);
                        string acountPass = reader.GetString(4);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Recuperacion contraseña del Sistema",
                            body: "Hola " + username + "\nTu pediste cambiar tu contraseña.\n" +
                            "Tu contraseña es: " + acountPass + "\n Te recomendamos cambiar la contraseña \nuna vez hayas entrado al Sistema para evitar futuros problemas",
                            recipientMail: new List<string> { usermail }
                            );
                        return "Hola " + username + "\nTu pediste cambiar tu contraseña.\n" +
                            "Por favor revisa tu correo" + usermail +
                            "\nTe recomendamos cambiar la contraseña una vez \nhayas entrado al Sistema para evitar futuros problemas";
                    }
                    else
                        return "Lo sentimos el Usuario o el Correo electronico no se encuentran en el Sistema";
                }
            }
        }
    }
}
