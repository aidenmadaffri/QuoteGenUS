<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="QuoteGenUS.LogInPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center">Login</h1>

    <asp:Label ID="UsernameLabel" runat="server" Text="Username:  " Font-Size="12"></asp:Label>
    <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="UsernameRequiredValidator" runat="server" ControlToValidate="UsernameTextBox" ErrorMessage="RequiredFieldValidator" Font-Size="12pt" ForeColor="Red">REQUIRED</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="PasswordLabel" runat="server" Text="Password:  " Font-Size="12"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server" ControlToValidate="UsernameTextBox" ErrorMessage="RequiredFieldValidator" Font-Size="12pt" ForeColor="Red">REQUIRED</asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" Width="289px" />
    <br />
    
</asp:Content>
