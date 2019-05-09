using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HotelApp.Classes
{
    public class Rate
    {
        public string price = "";

        public Rate(decimal cost)
        {
            price = cost.ToString("C2", CultureInfo.CurrentCulture);
        }

    }
}
