using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public static class PasswordStrength
    {
        public static int CalcPassStrength(string password)
        {
            int strength = 0;

            if (password.Length >= 8)
                strength += 2;
            else if (password.Length >= 5)
                strength += 1;


            if (password.Any(char.IsUpper))
                strength += 2;

            if (password.Any(char.IsLower))
                strength += 1;

            if (password.Any(char.IsDigit))
                strength += 2;

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
                strength += 2;

            if (password.Distinct().Count() >= password.Length * 0.7)
                strength += 1;

            return strength;

        }
    }
}
