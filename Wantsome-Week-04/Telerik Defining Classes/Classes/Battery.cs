using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace Telerik_Defining_Classes.Classes
{
    public class Battery
    {
        public string Model { get; set; } = null;
        public decimal HoursIdle { get; set; }
        public decimal HoursTalk { get; set; }
        public BatteryType Type { get; set; }

        public Battery()
        {
            // DEFAULT CONSTRUCTOR
        }

        public Battery(string model)
        {
            Model = model;
        }

        public Battery(string model, decimal hoursIdle, decimal hoursTalk)
        {
            Model = model;
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalk;
            Type = BatteryType.LiIon;
        }

        public enum BatteryType { LiIon, NiMH, NiCD };
        public void Print()
        {
            OutputHandling.Message($"Battery Model: {Model}");
            OutputHandling.Message($"Hours Idle: {HoursIdle}");
            OutputHandling.Message($"Hours Talk: {HoursTalk}");
            OutputHandling.Message($"Battery Type: {Type.ToString()}");
        }
    }
}
