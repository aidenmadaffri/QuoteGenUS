using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Hosting;


namespace QuoteGenUS
{
    public class Login
    {

        public static void SaveLogin(string username, string password)
        {
            using (StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath(@"~/App_Data/AccountUsernames.txt"), true))
            {
                sw.WriteLine(username);
            }
            using (StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath(@"~/App_Data/AccountPasswords.txt"), true))
            {
                sw.WriteLine(password);
            }
            using (StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath(@"~/App_Data/Users/SavedQuotes/" + username + ".txt"), true))
            {
                sw.WriteLine(username + "'s Saved Quotes");
                sw.WriteLine("");
            }
          

        }

    }
}