using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaModulzaro2
{
    class ABKivetel : Exception
    {
        string originalMessage;

        public string OriginalMessage { get => originalMessage; /*set => originalMessage = value;*/ }

        public ABKivetel(string message, string originalMessage) : base(message)
        {
            this.originalMessage = originalMessage;
        }
    }
}
