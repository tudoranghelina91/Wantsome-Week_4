using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Defining_Classes.Classes
{
    public class MobilePhoneDevice : GSM
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }

        public MobilePhoneDevice()
        {
            // DEFAULT CONSTRUCTOR
        }

        public MobilePhoneDevice(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public MobilePhoneDevice(string model, string manufacturer, decimal price, 
            string batteryModel, decimal hoursIdle, 
            decimal hoursTalk, decimal screenSize, int numberOfColors)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            GSMBattery.Model = batteryModel;
            GSMBattery.HoursIdle = hoursIdle;
            GSMBattery.HoursTalk = hoursTalk;
            GSMDisplay.Size = screenSize;
            GSMDisplay.NumberOfColors = numberOfColors;
        }
    }
}
