using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace Telerik_Defining_Classes.Classes
{
    public class GSM
    {
        public Battery GSMBattery { get; set; } = new Battery();
        public Display GSMDisplay { get; set; } = new Display();
        public static MobilePhoneDevice Iphone = new MobilePhoneDevice("IPhone5s", "Apple", 800.36m, "Apple", 72.3m, 12.6m, 6.7m, 123);
        public List<Call> CallHistory { get; set; } = new List<Call>();

        public GSM(Battery gsmBattery, Display gsmDisplay)
        {
            GSMBattery = gsmBattery;
            GSMDisplay = gsmDisplay;
        }

        public GSM()
        {
            // DEFAULT CONSTRUCTOR
        }

        public void AddCall(string phoneNumber, decimal duration)
        {
            Random rnd = new Random();
            DateTime dateTime = DateTime.Now.AddDays(rnd.Next(0, 6));
            dateTime = DateTime.Now.AddHours(rnd.Next(0, 11));
            dateTime = DateTime.Now.AddMinutes(rnd.Next(0, 60));
            dateTime = DateTime.Now.AddSeconds(rnd.Next(0, 60));
            Call call = new Call(dateTime, phoneNumber, duration);
            CallHistory.Add(call);
        }

        public void RemoveCall(string phoneNumber)
        {
            foreach (Call call in CallHistory)
            {
                if (call.DialedPhoneNumber == phoneNumber)
                    CallHistory.Remove(call);
            }
        }

        public void RemoveCall()
        {
            // Determine max call length
            decimal maxDuration = 0m;
            foreach (Call call in CallHistory)
            {
                if (call.Duration > maxDuration)
                {
                    maxDuration = call.Duration;
                }
            }
            // Remove longest call
            foreach (Call call in CallHistory)
            {
                if (call.Duration == maxDuration)
                {
                    CallHistory.Remove(call);
                    break;
                }
            }
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            foreach (Call call in CallHistory)
            {
                totalPrice = totalPrice + (pricePerMinute * call.Duration);
            }

            return totalPrice;
        }

        public void Print()
        {
            GSMBattery.Print();
            GSMDisplay.Print();
        }
    }
}
