<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.cs" Inherits="QuoteGenUS.Register" Title="Register"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="text-align:center">Register</h1>
    
    <asp:Label ID="UsernameLabel" runat="server" Text="Username:  " Font-Size="12"></asp:Label>
    <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="UsernameRequiredValidator" runat="server" ControlToValidate="UsernameTextBox" ErrorMessage="RequiredFieldValidator" Font-Size="12pt" ForeColor="Red">REQUIRED</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="PasswordLabel" runat="server" Text="Password:  " Font-Size="12"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server" ControlToValidate="UsernameTextBox" ErrorMessage="RequiredFieldValidator" Font-Size="12pt" ForeColor="Red">REQUIRED</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Password:  " Font-Size="12"></asp:Label>
    <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
    <asp:Label runat="server" Text="(Confirm)" Font-Size="12"></asp:Label>
    <asp:RequiredFieldValidator ID="ConfirmPasswordRequiredValidator" runat="server" ControlToValidate="UsernameTextBox" ErrorMessage="RequiredFieldValidator" Font-Size="12pt" ForeColor="Red">REQUIRED</asp:RequiredFieldValidator>
    <br />
    
    <asp:Button ID="RegisterButton" runat="server" Text="Register" Width="299px" Font-Size="12" OnClick="RegisterButton_Click"  />


    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="CompareValidator" Font-Size="12pt" ForeColor="Red" ControlToCompare="ConfirmPasswordTextBox" ControlToValidate="PasswordTextBox">PASSWORD AND CONFIRM PASSWORD NEED TO BE THE SAME</asp:CompareValidator>
    

    </asp:Content>
