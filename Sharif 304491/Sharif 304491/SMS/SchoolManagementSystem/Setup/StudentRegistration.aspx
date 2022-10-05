<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="SchoolManagementSystem.Setup.StudentRegistration" %>

<%@ Register Src="~/ResponseMessage.ascx" TagPrefix="uc1" TagName="ResponseMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <div class="container">
            <!-- general form elements -->
            <div class="card card-primary">
                <div class="card-header">
                    <h3 class="card-title">Create New Student Profile</h3>
                </div>
                <uc1:ResponseMessage runat="server" ID="ResponseMessage" />
                <!-- /.card-header -->
                <!-- form start -->
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Registration No </label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>

                            </div>

                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">First Name</label>
                                <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter Institute Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Last Name</label>
                                <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter Institute Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Contact No </label>
                                <asp:TextBox ID="txtContact" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Father Name </label>
                                <asp:TextBox ID="txFatherName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Father Contact No </label>
                                <asp:TextBox ID="txtFatherContactNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Father Occupation </label>
                                <asp:TextBox ID="txtFatherOccupation" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>



                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Mother Name </label>
                                <asp:TextBox ID="txtMotherName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Mother Contact No </label>
                                <asp:TextBox ID="txtMotherContactNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Mother Occupation </label>
                                <asp:TextBox ID="MotherOccupationstxt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>


                        <div class="col-md-4">
                            <div class="form-group ">
                                <label class="form-label">Address</label>
                                <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Institute Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

    

                        <div class="col-md-2">
                            <div class="form-group ">
                                <label class="form-label">&nbsp;</label>
                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary form-control" Text="Save"  />
                            </div>

                        </div>
                    </div>


                </div>

                <div class="card-header ">
                    <h3 class="card-title text-center">Institute List</h3>
                </div>
            <!-- /.card -->
        </div>
    </div>
</asp:Content>
