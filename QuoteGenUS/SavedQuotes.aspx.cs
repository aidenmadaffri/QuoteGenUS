using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Hosting;

namespace QuoteGenUS
{
    public partial class SavedQuotes : System.Web.UI.Page
    {
        string username = "";
        int quoteNumber;
        int quote;
        string QuoteTextFileBase;
        List<string> QuoteTextFileSplit;
        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["usr"];
            quoteNumber = int.Parse(Request.QueryString["quote"]);
            int lineNumber = -1;
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/Users/SavedQuotes/" + username + ".txt")))
            {
                while (sr.ReadLine() != null) { lineNumber++; }
            }
            savedQuotesNumberText.InnerText = String.Format("You have {0} saved quotes!", lineNumber);
            if (quoteNumber == 0)
            {
                QuoteText.InnerText = "Press the button below to see your quotes!";
            }
            else
            {
                using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/Users/SavedQuotes/" + username + ".txt")))
                {
                    //To skip (Blank)'s Saved Quotes
                    sr.ReadLine();
                    for (int i = 0; i < quoteNumber; i++)
                    {
                        quote = int.Parse(sr.ReadLine());
                        
                    }
                }
                QuoteTextFileBase = Properties.Resources.QuoteTextFile;
                QuoteTextFileSplit = QuoteTextFileBase.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                QuoteText.InnerText = QuoteTextFileSplit[quote];
            }
        }

        protected void nextQuoteButton_Click(object sender, EventArgs e)
        {
            quoteNumber++;
            Response.Redirect(String.Format("SavedQuotes.aspx?usr={0}&quote={1}", username, quoteNumber));
        }
    }
}