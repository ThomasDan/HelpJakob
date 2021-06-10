using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public interface ISendMessages
    {
        void SendMessage();
        void SendMessageToAll(string[] to);
    }
}
