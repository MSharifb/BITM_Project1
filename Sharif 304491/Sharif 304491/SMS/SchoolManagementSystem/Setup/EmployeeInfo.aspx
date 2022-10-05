<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="SchoolManagementSystem.Setup.EmployeeInfo" %>

<%@ Register Src="~/ResponseMessage.ascx" TagPrefix="uc1" TagName="ResponseMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <div class="container">
            <!-- general form elements -->
            <div class="card card-primary">
                <div class="card-header">
                    <h3 class="card-title">Employee Information</h3>
                </div>
                <uc1:ResponseMessage runat="server" ID="rmMsg" />
                <!-- /.card-header -->
                <!-- form start -->
                <div class="card-body">
                    <div class="row">

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Employee Type </label>
                                <asp:DropDownList ID="ddlEmployeeType" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>

                            </div>

                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">First Name</label>
                                <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter Institute Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Last Name</label>
                                <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter First Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Designation </label>
                                <asp:DropDownList ID="ddlDesignation" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>

                            </div>

                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Starting Salary</label>
                                <asp:TextBox ID="txtStartSalary" runat="server" placeholder="Enter Institute Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Nationality</label>
                                <asp:TextBox ID="txtNationality" runat="server" placeholder="Enter Nationality" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">NID</label>
                                <asp:TextBox ID="txtNid" runat="server" placeholder="Enter Nid" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Date of Birth</label>
                                <asp:TextBox ID="txtDateOfBirth" runat="server" placeholder="Birth Date" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Date of Joining</label>
                                <asp:TextBox ID="txtDateOfJoining" runat="server" placeholder="Joining Date" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>


                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Gender</label>
                                <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Relegion</label>
                                <asp:DropDownList ID="ddlRelegion" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">District </label>
                                <asp:DropDownList ID="ddlDistrict" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Upazila </label>
                                <asp:DropDownList ID="ddlUpazila" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-8">
                            <div class="form-group ">
                                <label class="form-label">Address</label>
                                <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Address" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Last Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Contact No-</label>
                                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>

                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="form-group ">
                                <label class="form-label">Blood Group</label>
                                <asp:DropDownList ID="ddlBloodGroup" runat="server"  CssClass="form-control">
                                    <asp:ListItem Value="0">Select... </asp:ListItem>
                                    <asp:ListItem Value="1">A+</asp:ListItem>
                                    <asp:ListItem Value="2">A- </asp:ListItem>
                                    <asp:ListItem Value="3">B+</asp:ListItem>
                                    <asp:ListItem Value="4">B-</asp:ListItem>
                                    <asp:ListItem Value="5">O+</asp:ListItem>
                                    <asp:ListItem Value="6">O-</asp:ListItem>
                                </asp:DropDownList>

                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="form-group ">
                                <label class="form-label">&nbsp;</label>
                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary form-control" Text="Save" OnClick="btnSave_Click" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div>
            div class="card-header ">
            <h3 class="card-title text-center">Institute List</h3>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-md-12" style="overflow: scroll">
                    <div class="form-group ">
                        <asp:HiddenField ID="hdnUpdateEmployeeId" runat="server" />

                        <asp:GridView ID="gvEmployee" runat="server" CssClass="table table-bordered table-striped"
                            AutoGenerateColumns="false" Width="100%" >

                            <Columns>
                                <asp:BoundField DataField="EIIN_RegistrationNo" HeaderText="EIIN/Registration No" />
                                <asp:BoundField DataField="InstituteName" HeaderText="Employee Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                <asp:BoundField DataField="Fax" HeaderText="Fax" />
                                <asp:BoundField DataField="DistrictName" HeaderText="District" />
                                <asp:BoundField DataField="UpazilaName" HeaderText="Upazila" />
                                <asp:BoundField DataField="SchoolType" HeaderText="Institute Type" />
                                <asp:BoundField DataField="Address" HeaderText="Address" />


                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnInstituteId" runat="server" Value='<%# Eval("InstituteId") %>' />
                                        <asp:ImageButton ID="imgEdit" runat="server" ImageUrl="~/assets/site/images/ico_information.png" CommandName="editc" CommandArgument='<%# Container.DataItemIndex %>' Width="25px" />
                                        <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/assets/img/cancel.png" CommandName="deletec" CommandArgument='<%# Container.DataItemIndex %>' OnClientClick="if ( ! ConfirmationMsg()) return false;" meta:resourcekey="imgDelete" Width="25px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>


                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- /.card -->   
</asp:Content>
