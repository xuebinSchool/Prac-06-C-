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
    public partial class PatientView : System.Web.UI.Page
    {
        PatientBLL patBLL = new PatientBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Patient> patients = patBLL.GetAllPatient();

            gvPatient.DataSource = patients;
            gvPatient.DataBind();
        }
    }
}