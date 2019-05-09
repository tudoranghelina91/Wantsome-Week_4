using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace HotelApp.Classes
{
    public class RoomInputHandling
    {
        public static string AddRoomName(int i = 0)
        {
            string name = InputHandling.ReadString("Room Name: " + i, "Room Name cannot be empty");
            if (name == "")
            {
                OutputHandling.Error("Room name cannot be empty!");
                return AddRoomName(i);
            }

            return name;
        }

        public static decimal AddRoomRate(int i = 0)
        {
            decimal price = InputHandling.ReadValueD("Rate: ");

            if (price <= 0m)
            {
                OutputHandling.Error("Room rate cannot be empty!");
                return AddRoomRate(i);
            }

            return price;
        }

        public static int AddRoomAdults(int i = 0)
        {
            int adults = InputHandling.ReadValue("Adults: ");
            if (adults <= 0)
            {
                OutputHandling.Error("A room can't have less than one adult");
                return AddRoomAdults(i);
            }

            return adults;
        }

        public static int AddRoomChildren(int i = 0)
        {
            int children = InputHandling.ReadValue("Children: ", "Must be an integer!");

            if (children < 0)
            {
                OutputHandling.Error("A room can't have less than 0 children");
                return AddRoomChildren(i);
            }

            return children;
        }
    }
}
