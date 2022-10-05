using DAL;
using BLL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SchoolManagementSystem.Setup
{
    public partial class EmployeeInfo : System.Web.UI.Page
    {
        EmployeeBLL objEmpBLL = new EmployeeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CommonDAL.Fillddl(ddlDistrict, @"SELECT DistrictId, DistrictName FROM Con_District
                ORDER BY DistrictName", "DistrictName", "DistrictId");
                LoadGrid();
            }
        }

        protected void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonDAL.Fillddl(ddlUpazila, @"SELECT UpazilaId, UpazilaName FROM Con_Upazila
            WHERE (DistrictId = " + ddlDistrict.SelectedValue + ") ORDER BY UpazilaName", "UpazilaName", "UpazilaId");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFieldValue() == false)
            {
                Save();
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            //dt = objEmpBLL.SetupSp_GetEmolpyeeInfo();
            if (dt.Rows.Count > 0)
            {
                gvEmployee.DataSource = dt;
                gvEmployee.DataBind();
            }
            else
            {
                gvEmployee.DataSource = null;
                gvEmployee.DataBind();
            }
        }
        private void Save()
        {
            int save = 0;
            EInstitute objEIns = new EInstitute();



           
            objEIns.EntryBy = int.Parse(Session["UserId"].ToString());

            if (btnSave.Text == "Save")
            {
                objEIns.Action = 1;
                objEIns.InstituteId = 0;
            }
            else if (btnSave.Text == "Update")
            {
                objEIns.Action = 2;
                objEIns.InstituteId = int.Parse(hdnUpdateEmployeeId.Value);
            }

            //save = objInsBLL.InsertUpdateDelete_InstituteInfo(objEIns);
            if (save > 0)
            {
                rmMsg.SuccessMessage = btnSave.Text + " Successfull.";
                btnSave.Text = "Save";
            }

        }

        private void DeleteIns(int InstituteId)
        {
            int save = 0;
            EInstitute objEIns = new EInstitute();



            objEIns.EIIN_RegistrationNo = "";
            objEIns.InstituteName = "";
            objEIns.Email = "";
            objEIns.Phone = "";
            objEIns.Fax = "";
            objEIns.DistrictId = 0;
            objEIns.UpazilaId = 0;
            objEIns.Address = "";
            objEIns.SchoolType = "";
            objEIns.EntryBy = 0;
            objEIns.Action = 3;
            objEIns.InstituteId = InstituteId;


            //save = objInsBLL.InsertUpdateDelete_InstituteInfo(objEIns);
            if (save > 0)
            {
                rmMsg.SuccessMessage = "Delete Successfull.";
                LoadGrid();
            }

        }
        private bool CheckFieldValue()
        {
            bool IsReq = false;

            if (txtFirstName.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = "FirstName can't be empty";
            }
            else if (txtLastName.Text == "")
            {
                IsReq = true;
                rmMsg.SuccessMessage = "txtLastName Name can't be empty";
            }
            else if (txtEmail.Text == "")
            {
                IsReq = true;
                rmMsg.SuccessMessage = "Email can't be empty";
            }
            else if (txtPhone.Text == "")
            {
                IsReq = true;
                rmMsg.SuccessMessage = "Phone can't be empty";
            }
            else if (ddlDistrict.SelectedValue == "0")
            {
                IsReq = true;
                rmMsg.SuccessMessage = "Select District.";
            }
            else if (ddlUpazila.SelectedValue == "0" || ddlUpazila.SelectedIndex == -1)
            {
                IsReq = true;
                rmMsg.SuccessMessage = "Select Upazila.";
            }
            else if (txtAddress.Text == "")
            {
                IsReq = true;
                rmMsg.SuccessMessage = "Address can't be empty";
            }



            return IsReq;
        }

     

        protected void gvInstitute_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int rowindex = int.Parse(e.CommandArgument.ToString());
            HiddenField hdnInstituteId = (HiddenField)gvEmployee.Rows[rowindex].FindControl("hdnInstituteId");

            if (e.CommandName == "editc")
            {
                FillControl(int.Parse(hdnInstituteId.Value));
                btnSave.Text = "Update";

            }
            else if (e.CommandName == "deletec")
            {
                DeleteIns(int.Parse(hdnInstituteId.Value));
            }
        }
        private void FillControl(int InstituteId)
        {
            DataTable dt = new DataTable();
            //dt = objInsBLL.SetupSp_GetInstituteInfo(InstituteId);
            if (dt.Rows.Count > 0)
            {
                hdnUpdateEmployeeId.Value = InstituteId.ToString();
                //txtEIIN.Text = dt.Rows[0]["EIIN_RegistrationNo"].ToString();
                //txtInstituteName.Text = dt.Rows[0]["InstituteName"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                //txtFax.Text = dt.Rows[0]["Fax"].ToString();
                ddlDistrict.SelectedValue = dt.Rows[0]["DistrictId"].ToString();

                CommonDAL.Fillddl(ddlUpazila, @"SELECT UpazilaId, UpazilaName FROM Con_Upazila
                WHERE (DistrictId = " + ddlDistrict.SelectedValue + ") ORDER BY UpazilaName", "UpazilaName", "UpazilaId");

                ddlUpazila.SelectedValue = dt.Rows[0]["UpazilaId"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                //ddlInstituteType.SelectedValue = dt.Rows[0]["SchoolType"].ToString();
            }
        }
    }
}