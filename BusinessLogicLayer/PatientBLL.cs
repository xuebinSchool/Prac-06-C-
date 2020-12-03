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

        public List<Patient> GetAllPatient()
        {
            List<Patient> allPatients = new List<Patient>();
            Patient patients = new Patient();

            allPatients = patients.GetAllPatient();

            return allPatients;
        }

        private string ValidateInput(string Id, string name, string gender, string citizenship, string address, string postalCode, string country, string contact, string email)
        {
            //StringBuilder messageBuilder = new StringBuilder();
            //IsNullOrEmpty and check length
            //messageBuilder.Append("Text more text <br/>")
            //return messageBuilder.ToString();

            return null;
        }
        
        public string UpdatePatient(string Id, string name, string gender, string citizenship, string address, string postalCode, string country, string contact, string email)
        {
            string returnString;

            //Validate here with ValidateInput()
            //if ValidateInput() = message.Length == 0 == no errors on ValidateInput()
            int iID = int.Parse(Id);
            int iPostal = int.Parse(postalCode);
            int iContact = int.Parse(contact);

            Patient updateValues = new Patient(name, gender, citizenship, address, country, email, iID, iPostal, iContact);

           int results = updateValues.UpdatePatient();

            if(results == 1)
            {
                returnString = "Patient is updated";
            }
            else
            {
                returnString = "Error";
            }

            return returnString;
        }
        
        public Patient GetPatient(string patientID)
        {
            Patient singlePatient = new Patient();
            return singlePatient.GetPatient(patientID);
        } 
    }
}
