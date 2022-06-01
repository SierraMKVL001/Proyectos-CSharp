using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain.Modelos
{
    public class UserModel
    {
        private int idEmp;
        private string Nombres;
        private string Apellidos;
        private string LogName;
        private string Pass;
        private string Email;

        UserDao userDao = new UserDao();

        public UserModel(int idEmp, string nombres, string apellidos, string logName, string pass, string email)
        {
            this.idEmp = idEmp;
            Nombres = nombres;
            Apellidos = apellidos;
            LogName = logName;
            Pass = pass;
            Email = email;

        }
        public UserModel()
        {

        }

        public string editUserProfile()
        {
            try
            {
                userDao.editProfile(idEmp, Nombres, Apellidos, LogName, Pass, Email);
                LoginUser(LogName, Pass);
                return "Tu perfil se ha actualizado correctamente!!!";
            }
            catch (Exception ex)
            {
                return "Ha habido un problema al editar tu perfil, ingtenta de nuevo";
            }

        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string recoverPass(string userRequest)
        {
            return userDao.recoveryPassword(userRequest);
        }
    }
}
