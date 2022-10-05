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
    public partial class Subject: System.Web.UI.Page
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
            dt = objSetup.LoadSubjectList();
            if (dt.Rows.Count > 0)
            {
                gvSubject.DataSource = dt;
                gvSubject.DataBind();
            }
            else
            {
                gvSubject.DataSource = null;
                gvSubject.DataBind();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int save = 0;

            if (btnSave.Text == "Save")
            {
                save = objSetup.SetupSubject_InsertUpdateDelete (1,0, txtSubject.Text, int.Parse(Session["UserId"].ToString()));
                if (save > 0)
                {
                    rmMsg.SuccessMessage = "Save done";
                    LoadGrid();
                    txtSubject.Text = "";
                }
            }
            else if (btnSave.Text == "Update")
            {
                save = objSetup.SetupSubject_InsertUpdateDelete (2, int.Parse(hdnUpdateSId.Value), txtSubject.Text, int.Parse(Session["UserId"].ToString()));
                if (save > 0)
                {
                    rmMsg.SuccessMessage = "Update done";
                    LoadGrid();
                    txtSubject.Text = "";
                    btnSave.Text = "Save";
                }
            }
        }

      

        protected void gvSubject_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowindex = int.Parse(e.CommandArgument.ToString());
            HiddenField hdnSubjectSId = (HiddenField)gvSubject.Rows[rowindex].FindControl("hdnSubjectSId");
            Label lblSubject = (Label)gvSubject.Rows[rowindex].FindControl("lblSubject");

            if (e.CommandName == "editc")
            {
                hdnUpdateSId.Value = hdnSubjectSId.Value;
                txtSubject.Text = lblSubject.Text;
                btnSave.Text = "Update";

            }
            else if (e.CommandName == "deletec")
            {
                int save1 = objSetup.SetupSubject_InsertUpdateDelete(3, int.Parse(hdnSubjectSId.Value), txtSubject.Text, int.Parse(Session["UserId"].ToString()));
                if (save1 > 0)
                {
                    rmMsg.SuccessMessage = "Delete done";
                    LoadGrid();
                    txtSubject.Text = "";
                }
            }
        }
    }
}