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
        public static UserModel user { get; set; }

        public static void Wipe()
        {
            user = null;
        }
    }
}
