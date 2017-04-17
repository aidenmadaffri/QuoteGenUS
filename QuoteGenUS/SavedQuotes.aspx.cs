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
        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["usr"];
            int lineNumber = 0;
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/Users/SavedQuotes/" + username + ".txt")))
            {
                while (sr.ReadLine() != null) { lineNumber++; }
            }
            savedQuotesNumberText.InnerText = String.Format("You have {0} saved quotes!", lineNumber);
            QuoteText.InnerText = "Press the button below to see your quotes!";
        }

        protected void nextQuoteButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/Users/SavedQuotes/" + username + ".txt")))
            {
                //To skip "(Blank)'s Saved Quotes"
                sr.ReadLine();
                while(sr.EndOfStream == false)
                {

                }
            }
        }
    }
}