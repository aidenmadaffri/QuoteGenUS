<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuoteGenUS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" >
        
        <h1 id="TitleHeader" runat="server" >Quote Gen US</h1>
        <p class="lead">
            <asp:Button ID="GenerateQuoteButton" runat="server" BackColor="Blue" Font-Bold="True" ForeColor="White" Text="Generate a Quote" Width="298px" OnClick="GenerateQuoteButton_Click" CausesValidation="False" />
        </p>

    </div>


  

</asp:Content>
