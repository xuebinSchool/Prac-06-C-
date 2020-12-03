﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace DataAccessLayer
{
    public class Patient
    {
        private string _patientName, _gender, _citizenship, _address, _country, _email;
        private int _patientID, _postalCode, _contact;
        private string connStr = ConfigurationManager.ConnectionStrings["Prac06.Properties.Settings.dbConnection"].ConnectionString;

        public string PatientName
        {
            get
            {
                return _patientName;
            }

            set
            {
                _patientName = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string Citizenship
        {
            get
            {
                return _citizenship;
            }

            set
            {
                _citizenship = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public int PatientID
        {
            get
            {
                return _patientID;
            }

            set
            {
                _patientID = value;
            }
        }

        public int PostalCode
        {
            get
            {
                return _postalCode;
            }

            set
            {
                _postalCode = value;
            }
        }

        public int Contact
        {
            get
            {
                return _contact;
            }

            set
            {
                _contact = value;
            }
        }

        public Patient(string patientName, string gender, string citizenship, string address, string country, string email, int patientID, int postalCode, int contact)
        {
            PatientName = patientName;
            Gender = gender;
            Citizenship = citizenship;
            Address = address;
            Country = country;
            Email = email;
            PatientID = patientID;
            PostalCode = postalCode;
            Contact = contact;
        }

        //public Patient(string patientName, string gender, string citizenship, string address, string country, string email, int postalCode, int contact)
        //{
        //    PatientName = patientName;
        //    Gender = gender;
        //    Citizenship = citizenship;
        //    Address = address;
        //    Country = country;
        //    Email = email;
        //    PostalCode = postalCode;
        //    Contact = contact;
        //}




        //public int patientid
        //{
        //    get { return _patientID; }
        //    set { _patientID = value; }
        //}
        //public string patientname
        //{
        //    get { return _patientName; }
        //    set { _patientName = value; }
        //}
        //public string gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}
        //public string citizenship
        //{
        //    get { return _citizenship; }
        //    set { _citizenship = value; }
        //}
        //public string address
        //{
        //    get { return _address; }
        //    set { _address = value; }
        //}
        //public int postalcode
        //{
        //    get { return _postalCode; }
        //    set { _postalCode = value; }
        //}




        public int InsertPatient()
        {
            int results = 0;
            string queryString = "INSERT INTO Patient(PatientID, PatientName, Gender, Citizenship, Address, PostalCode, Country, ContactNo, Email)" +
                "values (@ID, @Name, @Gender, @Citizenship, @Address, @Postal, @Country, @Contact, @Email)";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryString, conn);

            cmd.Parameters.AddWithValue("@ID", PatientID.ToString());
            cmd.Parameters.AddWithValue("@Name", PatientName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Citizenship", Citizenship);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Postal", PostalCode.ToString());
            cmd.Parameters.AddWithValue("@Country", Country);
            cmd.Parameters.AddWithValue("@Contact", Contact.ToString());
            cmd.Parameters.AddWithValue("@Email", Email);

            conn.Open();
            results += cmd.ExecuteNonQuery();
            conn.Close();

            return results;
        }


    }
}
