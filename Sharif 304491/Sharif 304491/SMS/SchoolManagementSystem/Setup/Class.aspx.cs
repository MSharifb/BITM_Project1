using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace SchoolManagementSystem.Setup
{
    public partial class Class : System.Web.UI.Page
    {
        SetupBLL objSetup = new SetupBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }
        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt = objSetup.LoadClassInfo();
            if (dt.Rows.Count > 0)
            {
                gvClass.DataSource = dt;
                gvClass.DataBind();
            }
            else
            {
                gvClass.DataSource = null;
                gvClass.DataBind();
            }
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {

            int save = 0;

            if (btnSave.Text == "Save")
            {
                save = objSetup.SetupClass_InsertUpdateDelete(1, 0, txtClass.Text, int.Parse(Session["UserId"].ToString()));
                if (save > 0)
                {
                    rmMsg.SuccessMessage = "Save done";
                    LoadGrid();
                    txtClass.Text = "";
                }
            }
            else if (btnSave.Text == "Update")
            {
                save = objSetup.SetupClass_InsertUpdateDelete(2, int.Parse(hdnUpdateClassId.Value), txtClass.Text, int.Parse(Session["UserId"].ToString()));
                if (save > 0)
                {
                    rmMsg.SuccessMessage = "Update done";
                    LoadGrid();
                    txtClass.Text = "";
                    btnSave.Text = "Save";
                }
            }

        }



        protected void gvClass_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowindex = int.Parse(e.CommandArgument.ToString());
            HiddenField hdnClassId = (HiddenField)gvClass.Rows[rowindex].FindControl("hdnClassId");
            Label lblClass = (Label)gvClass.Rows[rowindex].FindControl("lblClass");

            if (e.CommandName == "editc")
            {
                hdnUpdateClassId.Value = hdnClassId.Value;
                txtClass.Text = lblClass.Text;
                btnSave.Text = "Update";

            }
            else if (e.CommandName == "deletec")
            {
                int save1 = objSetup.SetupClass_InsertUpdateDelete(3, int.Parse(hdnClassId.Value), txtClass.Text, int.Parse(Session["UserId"].ToString()));
                if (save1 > 0)
                {
                    rmMsg.SuccessMessage = "Delete done";
                    LoadGrid();
                    txtClass.Text = "";
                }
            }
        }

      
    }
}