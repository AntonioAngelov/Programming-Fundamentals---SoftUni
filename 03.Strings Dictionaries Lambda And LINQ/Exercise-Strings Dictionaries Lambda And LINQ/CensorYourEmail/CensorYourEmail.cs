using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorYourEmail
{
    public class CensorYourEmail
    {
        public static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var text = Console.ReadLine();
            string[] nameAndDomain = email.Split('@');
            string username = nameAndDomain[0];
            string domain = nameAndDomain[1];
            string astesks = new string('*', username.Length);
            string replace = astesks + "@" + domain;
            text = text.Replace(email, replace);
            Console.WriteLine(text);

             
        }
    }
}
