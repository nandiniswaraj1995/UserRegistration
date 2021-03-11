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
        public bool isValidEmail(string email)
        {
            string Regex_email = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

            Regex regex = new Regex(Regex_email);
            if (regex.IsMatch(email))
                return true;
            else
                return false;

        }
        public bool isValidMobileNumber(string mobileNumber)
        {
            string Regex_mobile = "^(0|91[ ])?[7-9][0-9]{9}$";

            Regex regex = new Regex(Regex_mobile);
            if (regex.IsMatch(mobileNumber))
                return true;
            else
                return false;

        }

        public bool isValidPassword(string password)
        {
            string Regex_password = "^[A-Z][a-zA-Z0-9]{7,}$";

            Regex regex = new Regex(Regex_password);
            if (regex.IsMatch(password))
                return true;
            else
                return false;

        }



    }
}
