using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HotelApp.Classes
{
    class Rate
    {
        static decimal rate;
        string price = rate.ToString("C2", CultureInfo.CurrentCulture);
    }
}
