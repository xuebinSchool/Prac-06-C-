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

        //For file upload
        //protected void btn_Insert_Click(object sender, EventArgs e)
        //{
        //    ProductBLL prodBLL = new ProductBLL();
        //    string image = "";

        //    if (fileUpload.HasFile == true)
        //    {
        //        image = "Images\\" + fileUpload.FileName;
        //    }

        //    string msg = prodBLL.ProductInsert(tb_ProductName.Text, tb_ProductDesc.Text, tb_UnitPrice.Text, fileUpload.FileName, tb_StockLevel.Text);

        //    if (msg == "Prodict has been Inserted successfully")
        //    {
        //        string saveimg = Server.MapPath(" ") + "\\" + image;
        //        lbl_Result.Text = saveimg.ToString();
        //        fileUpload.SaveAs(saveimg);
        //    }

        //    lbl_Result.Text = msg;
        //}
    }
}