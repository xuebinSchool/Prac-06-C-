using System;
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

        public Patient()
        {
        }


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

        public List<Patient> GetAllPatient()
        {
            List<Patient> PatientAll = new List<Patient>();
            int patId, postal, contact;
            string patName, gender, citizenship, address, country, email;

            string query = "SELECT * FROM Patient Order By PatientName";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                patId = int.Parse(dr["PatientID"].ToString());
                patName = dr["PatientName"].ToString();
                gender = dr["Gender"].ToString();
                citizenship = dr["Citizenship"].ToString();
                address = dr["Address"].ToString();
                postal = int.Parse(dr["PostalCode"].ToString());
                country = dr["Country"].ToString();
                contact = int.Parse(dr["ContactNo"].ToString());
                email = dr["Email"].ToString();

                PatientAll.Add(new Patient(patName, gender, citizenship, address, country, email, patId, postal, contact));
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return PatientAll;
        }

        public int UpdatePatient()
        {
            string query = "UPDATE Patient SET PatientName = @patName, Gender = @gender , Citizenship = @citizenship,  " +
                "Address = @address, PostalCode = @postal, Country = @country, ContactNo = @contact, Email = @email WHERE PatientID = @Id";

            int numofRows = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", PatientID.ToString());
                    cmd.Parameters.AddWithValue("@patName", PatientName);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@citizenship", Citizenship);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@postal", PostalCode.ToString());
                    cmd.Parameters.AddWithValue("@country", Country);
                    cmd.Parameters.AddWithValue("@contact", Contact.ToString());
                    cmd.Parameters.AddWithValue("@email", Email);


                    conn.Open();
                    numofRows = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return numofRows;
        }

        public Patient GetPatient(string patientID)
        {
            Patient patient = null;
            string query = "SELECT * FROM Patient WHERE PatientID = @ID";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", patientID);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string patName = dr["PatientName"].ToString();
                        string gender = dr["Gender"].ToString();
                        string citizenship = dr["Citizenship"].ToString();
                        string address = dr["Address"].ToString();
                        int postal = int.Parse(dr["PostalCode"].ToString());
                        string country = dr["Country"].ToString();
                        int contact = int.Parse(dr["ContactNo"].ToString());
                        string email = dr["Email"].ToString();

                        patient = new Patient(patName,gender,citizenship,address,country,email,int.Parse(patientID),postal,contact);
                    }

                    conn.Close();
                    dr.Close();
                    dr.Dispose();
                }
            }

            return patient;
        }

    }
}
