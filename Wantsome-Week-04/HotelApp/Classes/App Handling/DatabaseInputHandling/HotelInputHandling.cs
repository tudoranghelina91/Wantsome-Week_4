using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace HotelApp.Classes.AppHandling.DatabaseInputHandling
{
    class HotelInputHandling
    {
        public static string AddHotelName()
        {
            string hotelName = InputHandling.ReadString("Hotel Name: ");
            if (hotelName == "")
            {
                OutputHandling.Error("Hotel Name cannot be empty!");
                return AddHotelName();
            }

            return hotelName;
        }

        public static string AddHotelCity()
        {
            string hotelCity = InputHandling.ReadString("City: ");

            if (hotelCity == "")
            {
                OutputHandling.Error("Hotel Name cannot be empty!");
                return AddHotelCity();
            }

            return hotelCity;
        }

        public static void AddHotelRooms(Hotel hotel)
        {
            string roomName;
            decimal roomRate;
            int adults;
            int children;

            int numberOfRooms = InputHandling.ReadValue("Number of rooms: ");
            if (numberOfRooms > 0)
            {
                for (int i = 1; i <= numberOfRooms; i++)
                {
                    roomName = RoomInputHandling.AddRoomName(i);
                    roomRate = RoomInputHandling.AddRoomRate(i);
                    adults = RoomInputHandling.AddRoomAdults(i);
                    children = RoomInputHandling.AddRoomChildren(i);
                    Room room = new Room(roomRate, roomName, adults, children);
                    hotel.Rooms.Add(room);
                }
            }

            else
            {
                OutputHandling.Error("You can't have less than a room!");
                AddHotelRooms(hotel);
            }
        }
    }
}
