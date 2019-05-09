using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Classes;
using HotelApp.Classes.AppHandling;
using Wantsome_Week_04.Handlers;

namespace HotelApp
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>();
            AppFlowHandling.MainMenu(hotels);
        }
    }
}
