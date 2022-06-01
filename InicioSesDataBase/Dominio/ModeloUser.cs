using System;
using AccesoDatos;
using Common.Cache;

namespace Dominio
{
    public class ModeloUser
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user,pass);
        }
        
    }
}
