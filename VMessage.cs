using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class VMessage : Message, ISendMessages
    {
        public VMessage(string To, string From, string Body, string Subject, string Cc) : base(To, From, Body, Subject, Cc)
        {

        }
        public void SendMessage()
        {
            //her implementeres alt koden til at sende via VMessage
            // Illegal CWL for Testing purposes
            Console.WriteLine("VMessage Sent!");
        }
        public void SendMessageToAll(string[] to)
        {
            //her implementeres alt koden til at sende via VMessage
        }
    }
}
