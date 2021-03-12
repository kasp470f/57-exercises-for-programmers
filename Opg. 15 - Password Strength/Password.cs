using System.Text.RegularExpressions;

namespace Password_Strength
{
    public class Password
    {
        public static int passwordValidator(string password)
        {
            if (password.Length < 8 && int.TryParse(password, out _))
            {
                return 0;
            }
            else if (password.Length < 8 && Regex.IsMatch(password, @"^[a-zA-Z]+$"))
            {
                return 1;
            }
            else if (password.Length > 8 && Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                return 2;
            }
            return 3;
        }
    }
}
