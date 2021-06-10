using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class SMTP : Message, ISendMessages
    {
        public SMTP(string To, string From, string Body, string Subject, string Cc) : base(To, From, Body, Subject, Cc)
        {

        }
        public void SendMessage()
        {
            //her implementeres alt koden til at sende via Smtp
            // Illegal CWL for Testing purposes
            Console.WriteLine("SMTP Sent!");
        }
        public void SendMessageToAll(string[] to)
        {
            //her implementeres alt koden til at sende via Smtp
        }
    }
}
