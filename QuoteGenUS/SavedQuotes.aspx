<%@ Page Title="Saved Quotes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SavedQuotes.aspx.cs" Inherits="QuoteGenUS.SavedQuotes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" >
        <h1 id="savedQuotesNumberText" runat="server" style="text-align:center">You have ___ saved quotes</h1>
        <h1 id="QuoteText" runat="server" style="text-align:center">(INSERT QUOTE)</h1>

        <p class="lead" style="text-align:center">
            <asp:Button ID="nextQuoteButton" runat="server" BackColor="Blue" Font-Bold="True" ForeColor="White" Text="Next Saved Quote" Width="298px" OnClick="nextQuoteButton_Click" CausesValidation="False" />
        </p>

    </div>
</asp:Content>
