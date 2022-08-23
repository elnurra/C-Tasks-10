using System;
using System.Collections.Generic;
using System.Text;
using TaskForExceptionIndexer.Utilies;

namespace TaskForExceptionIndexer.Models
{
    class Hotel
    {
        private Room[] _rooms;
        private int _counts=0;
        public string Name{ get; set; }

        public Hotel( string name, int length)
        {
            _rooms = new Room[length];
            Name = name;
        }

        public Room this[int roomId]
        {
            get
            {
                if (roomId < _rooms.Length)
                {
                    return _rooms[roomId];
                }
                throw new Exception();
            }
            set
            {
                if (roomId < _rooms.Length)
                {
                    _rooms[roomId] = value;
                    return;
                }
                throw new Exception();

            }
        }

            public void AddRoom(Room room) 
        {
            if (_counts<_rooms.Length)
            {
                _rooms[_counts] = room;
                _counts++;
            }
            else
            {
                Console.WriteLine("You cant add new room: ");
            }
        }
        public void Reserve(int? roomId)
        {
            foreach (Room room in _rooms)
            {
                if (room.Id==roomId)
                {
                    if (room._isAvailable)
                    {
                        Console.WriteLine("Reserving...");
                        room._isAvailable = false;
                        Console.WriteLine("Room is reserved.");
                        return;
                    }
                    throw new NotAvailableException();
                }
                
                
            }
            throw new NotFoundException();

        }

        }


    }

