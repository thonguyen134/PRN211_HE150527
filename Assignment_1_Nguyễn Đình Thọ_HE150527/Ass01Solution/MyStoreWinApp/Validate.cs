using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyStoreWinApp
{
    public class Validate
    {
        //check id
        public bool checkMemberId(string id) {

                if (id == null || id.Trim().Equals("")) {
                return false;
            }else if (int.TryParse(id, out int value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check string
        public bool checkString(string name) {
            Regex regex = new Regex(@"^[A-z][A-z|\.|\s]+$");
            if (regex.IsMatch(name)) {
                return true;
            }
            return false;
        }
        //check mail
        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }
        //check string and integer
        public bool checkStringAndInteger(string address)
        {
            Regex regex = new Regex("^(\\d{1,}) [a-zA-Z0-9\\s]+(\\,)? [a-zA-Z]+(\\,)? [A-Z]{2} [0-9]{5,6}$");
            if (regex.IsMatch(address))
            {
                return true;
            }
            return false;
        }
        //check pass word
        public bool checkPassword(string id)
        {
            if (id == null || id.Trim().Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
