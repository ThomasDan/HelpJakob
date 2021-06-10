using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Email service!\nWho is it to?");
            string to = Console.ReadLine();
            Console.WriteLine("Do you want to CC anyone? (Leave blank if no)");
            string cc = Console.ReadLine();
            Console.WriteLine("Who is it from?");
            string from = Console.ReadLine();
            Console.WriteLine("What is the subject?");
            string subject = Console.ReadLine();
            Console.WriteLine("What is the body?");
            string body = Console.ReadLine();

            Message m;
            Console.WriteLine("Which format would you like?\n0 for SMTP | 1 for VMessage");
            if (Convert.ToBoolean(Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString())))
            {
                m = new VMessage(to, from, body, subject, cc);
                Console.WriteLine("VMessage!");
            }
            else
            {
                m = new SMTP(to, from, body, subject, cc);
                Console.WriteLine("SMTP!");
            }

            Console.WriteLine("Do you want to convert the body to HTML?\n0 for No | 1 for Yes");
            if (Convert.ToBoolean(Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString())))
            {
                m.ConvertBodyToHTML();
                Console.WriteLine("Converted to HTML!");
            }

            ISendMessages ism = (ISendMessages)m;
            ism.SendMessage();

            Console.WriteLine("To: " + m.To + " CC: " + m.Cc + " From: " + m.From + "\nSubject: " + m.Subject + "\n\n" + m.Body);

            Console.ReadKey();
        }
    }
}
