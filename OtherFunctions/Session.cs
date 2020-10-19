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
