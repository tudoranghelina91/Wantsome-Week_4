using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Wantsome_Week_04.Handlers;

namespace Telerik_Defining_Classes.Classes
{
    public class Call
    {
        public DateTime dateTime { get; set; } = new DateTime();
        public string DialedPhoneNumber { get; set; }
        public decimal Duration { get; set; }

        public Call(DateTime dateTimeCall, string dialedPhoneNumber, decimal duration)
        {
            dateTime = dateTimeCall;
            DialedPhoneNumber = dialedPhoneNumber;
            Duration = duration;
        }

        public void Print()
        {
            OutputHandling.Message($"Date and Time: {dateTime}");
            OutputHandling.Message($"Phone Number: {DialedPhoneNumber}");
            OutputHandling.Message($"Duration: {Duration}s");
        }
    }
}
