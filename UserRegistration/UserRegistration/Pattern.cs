using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{

    class Pattern
    {
        public  bool isValidFirstName(string userName)
        {
            string userNameRegex = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(userNameRegex);
            if (regex.IsMatch(userName))
                return true;
            else
                return false;

        }
        public bool isValidLastName(string userName)
        {
            string userNameRegex = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(userNameRegex);
            if (regex.IsMatch(userName))
                return true;
            else
                return false;

        }

    }
}
