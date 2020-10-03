using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace OtherFunctions
{
    public static class Session
    {
        public static string userID { get; set; }
        public static string name { get; set; }
        public static string email { get; set; }

        public static void Wipe()
        {
            userID = null;
            name = null;
            email = null;
        }
    }
}
