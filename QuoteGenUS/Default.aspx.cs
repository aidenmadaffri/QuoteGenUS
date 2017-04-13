using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuoteGenUS
{

    public partial class _Default : Page
    {
        string QuoteTextFileBase;
        List<string> QuoteTextFileSplit;
        List<int> usedQuotes = new List<int>(); //store quotes that have been used via quote numbers

        protected void Page_Load(object sender, EventArgs e)
        {
            QuoteTextFileBase = Properties.Resources.QuoteTextFile;
            QuoteTextFileSplit = QuoteTextFileBase.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            

        }

        protected void GenerateQuoteButton_Click(object sender, EventArgs e)
        {
            int quoteCount = QuoteTextFileSplit.Count();
            if (usedQuotes.Count >= 50)
            {
                usedQuotes.RemoveAt(0); //If there are more than 50 quotes that have been used it will delete the oldest used quotes from the list
            }
            string quoteText = "";
            GenerateQuoteButton.Text = "Generate Another Quote!";
            Random RNG = new Random(); //Random Number Generator
            int quoteNumber = RNG.Next(1, quoteCount); //Sets quote number to a random number
            foreach (int quote in usedQuotes)
            {
                if (quoteNumber == quote)
                {
                    quoteNumber = RNG.Next(1, quoteCount); // For each used quote, make sure it is not a quote that will be outputed
                }
            }
            quoteText = QuoteTextFileSplit[quoteNumber];

            TitleHeader.InnerText = quoteText;




        }
    }
}