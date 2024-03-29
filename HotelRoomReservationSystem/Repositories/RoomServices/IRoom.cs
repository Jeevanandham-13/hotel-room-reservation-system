﻿using HotelRoomReservationSystem.Models;

namespace HotelRoomReservationSystem.Repositories.RoomServices
{
    namespace HotelManagement.Repositories
    {
        public interface IRoom
        {
            public IEnumerable<Room> GetRoom();
            public Room GetRoomById(int RoomId);
            public Room PostRoom(Room room);
            public Room PutRoom(int RoomId, Room room);
            public Room DeleteRoom(int RoomId);
        }
    }
    }
