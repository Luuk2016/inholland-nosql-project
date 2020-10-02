using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFunctions
{
    public static class Session
    {
        public static int userID { get; set; }
        public static string name { get; set; }

        /*
         * Wipe the current session
         */
        public static void Wipe()
        {
            userID = 0;
            name = null;
        }
    }
}
