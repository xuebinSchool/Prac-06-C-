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

        protected void gvPatient_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Auto generate with Event handler at properties

            int rowNum = int.Parse(e.CommandArgument.ToString());

            GridViewRow grRow = gvPatient.Rows[rowNum];
            string patientID = grRow.Cells[0].Text;

            if(e.CommandName == "Select")
            {
                Response.Redirect(String.Format("PatientDetails.aspx?id={0}", patientID));
            }
            else if (e.CommandName == "Update")
            {
                Response.Redirect(String.Format("PatientUpdate.aspx?id={0}", patientID));
            }
        }
    }
}