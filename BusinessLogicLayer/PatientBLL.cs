using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    public class PatientBLL
    {
        public string PatientInsert(string Id, string name, string gender, string citizenship, string address, string postalCode, string country, string contact, string email)
        {
            string msg = null;
            int results = 0;
            int iId, ipostal, icontact;
            Regex emailrx = new Regex("^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$");

            if (int.TryParse(Id, out iId) == false)
            {
                msg = "Id value is not an integer value. Please edit that!";
            }
            else if (int.TryParse(postalCode, out ipostal) == false)
            {
                msg = "Postal Code is not an integer value. Please edit that!";
            }
            else if (int.TryParse(contact, out icontact) == false)
            {
                msg = "Contact is not an integer value. Please edit that!";
            }
            else if (name == String.Empty)
            {
                msg = "Name cannot be empty";
            }
            else if (gender == String.Empty)
            {
                msg = "Gender cannot be empty";
            }
            else if (citizenship == String.Empty)
            {
                msg = "Citizenship cannot be empty";
            }
            else if (address == String.Empty)
            {
                msg = "Address cannot be empty";
            }
            else if (country == String.Empty)
            {
                msg = "Country cannot be empty";
            }
            else if (email == String.Empty)
            {
                msg = "Email cannot be empty";
            }
            else
            {
                Match match = emailrx.Match(email);
                if (match.Success == false)
                {
                    msg = "Email is in the wrong format";
                }
                else
                {
                    Patient pValue = new Patient(name, gender, citizenship, address, country, email, iId, ipostal, icontact);

                    results = pValue.InsertPatient();
                    if (results == 1)
                    {
                        msg = "Product is insert successfully!";
                    }
                    else
                    {
                        msg = "Error! Something bad has happened";
                    }
                }
            }
            return msg;
        }

    }
}
