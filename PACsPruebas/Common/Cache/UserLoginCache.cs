using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int idEmp { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string LoginName { get; set; }
        public static string Pass { get; set; }
        public static string Email { get; set; }
        public static int idPuesto { get; set; }
    }
}
