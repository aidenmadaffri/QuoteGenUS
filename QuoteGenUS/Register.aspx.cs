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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == PasswordTextBox.Text)
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;
                Login.SaveLogin(username, password);

            }
        }
    }
}