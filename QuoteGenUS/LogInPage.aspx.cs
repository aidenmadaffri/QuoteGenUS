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
    public partial class LogInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            int linesDown = 0;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool validUsername = false;
            bool validPassword = false;
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/AccountUsernames.txt")))
            {
                while (sr.EndOfStream == false)
                {
                    linesDown++;
                    string line = sr.ReadLine();
                    line = line.ToLower();
                    if (line != null)
                    {
                        if (line == username.ToLower())
                        {
                            validUsername = true;
                        }
                    }
                }
                
            }
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(@"~/App_Data/AccountPasswords.txt")))
            {
                for (int i = 0; i < linesDown; i++)
                {
                    string line = sr.ReadLine();
                    line = line.ToLower();
                    
                    if (line == password.ToLower())
                    {
                        validPassword = true;
                    }
                }

            }
            
            if ((validUsername == true) && (validPassword == true))
            {
                Response.Redirect("SavedQuotes.aspx?usr=" + username);
            }
            else
            {
                if (validUsername == false)
                {
                    UsernameInvalidLabel.Visible = true;
                }
                if (validPassword == false)
                {
                    PasswordInvalidLabel.Visible = true;
                }
            }
        }
    }
}