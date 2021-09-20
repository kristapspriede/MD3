using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Size Size { get; set; } = new Size();


        public string Call()
        {
            return "Ring-ring";
        }

        public string SendSMS()
        {
            return "Message sent!";
        }
    }
}
