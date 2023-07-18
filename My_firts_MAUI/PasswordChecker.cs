using System;
namespace My_firts_MAUI
{
    public interface PasswordChecker
    {
        public static bool Check(User user, String password)
        {
            return user.Password == password;
        }
    }
}

