using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactManagement
{
    internal class Contact
    {
        private int _id;
        private string _name;
        private string _phoneNumber;
        private string _email;

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                string pattern = @"[A-Z][a-z]{1,} [A-Z][a-z]{1,}";
                Regex re = new Regex(pattern);
                if (re.IsMatch(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("The value you assigned to name is invalid. Try to follow this formula -> Firstname Lastname");
                }
            }
        }
        public Contact(int id) : this(id, "Unknown", "Not provided", "Not provided")
        {


        }
        public Contact(int id, string name, string phoneNumber, string email)
        {
            _id = id;
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
        }


    }
}
