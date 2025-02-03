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

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                /*
                Examples of valid phone numbers:
                +1 234-567-8901
                (123) 456-7890
                123-456-7890
                1234567890
                 Invalid phone numbers:

                123-abc-7890 (contains letters)
                ++1234567 (multiple + signs)
                */
                string pattern = @"\+?\d{1,3}[\s-]?\(?\d{1,3}\)?[\s-]?\d{3}[\s-]?\d{4}";
                Regex re = new Regex(pattern);
                if (re.IsMatch(value))
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Please try to conform to these patterns - +1 234-567-8901, (123) 456-7890, 123-456-7890, 1234567890");
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
