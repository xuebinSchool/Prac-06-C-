using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace Prac06
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           PatientBLL prodBLL = new PatientBLL();
           string msg = prodBLL.PatientInsert(txtID.Text, txtName.Text, rblGender.Text, ddlCitizenship.Text, txtAddress.Text, txtPostal.Text, ddlCountry.Text, txtContact.Text, txtEmail.Text);

            lblMessage.Text = msg;
        }
    }
}