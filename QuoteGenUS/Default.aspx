<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuoteGenUS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" >
        
        <h1 id="TitleHeader" runat="server" style="text-align:center">Quote Gen US</h1>
        <p class="lead" style="text-align:center">
            <asp:Button ID="SaveButton" runat="server" BackColor="Blue" Font-Bold="True" ForeColor="White" Text="Save this Quote" Width="298px" OnClick="SaveButton_Click" CausesValidation="False" />
        </p>
        <p class="lead" style="text-align:center">
            <asp:Button ID="GenerateQuoteButton" runat="server" BackColor="Blue" Font-Bold="True" ForeColor="White" Text="Generate a Quote" Width="298px" OnClick="GenerateQuoteButton_Click" CausesValidation="False" />
        </p>

    </div>


  

</asp:Content>
