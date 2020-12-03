using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace Prac06
{
    public partial class PatientDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string patientID = Request.QueryString["id"];

                PatientBLL patientBLL = new PatientBLL();
                Patient patient = patientBLL.GetPatient(patientID);

                if (patient == null)
                {
                    lblMessage.Text = "Error in finding patient details";
                }
                else
                {
                    lblPatientID.Text = patient.PatientID.ToString();
                    lblPatientName.Text = patient.PatientName;
                    rblGender.SelectedValue = patient.Gender;
                    ddlCitizenship.SelectedValue = patient.Citizenship;
                    txtAddress.Text = patient.Address;
                    ddlCountry.SelectedValue = patient.Country;
                    lblPostal.Text = patient.PostalCode.ToString();
                    lblContact.Text = patient.Contact.ToString();
                    lblEmail.Text = patient.Email;
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientView.aspx");
        }
    }
}