using _04._04._2022Bashir_sTask.Utility.MyException;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._04._2022Bashir_sTask.Models
{
    class Hotel
    {
        private string _name;
        private Room[] _rooms = new Room[0];
        

        public Hotel(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }

        public void Reserve(int? roomID)
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (_rooms[i].ID == roomID)
                {
                    if (_rooms[i].IsAvailable)
                    {
                        Console.WriteLine($"{_rooms[i].Name} Room has been successfully reserved!");
                        _rooms[i].IsAvailable = false;
                        break;
                    }
                    else throw new NotAvailableException();
                }
                else if (_rooms[i].ID != roomID && i == _rooms.Length - 1) { throw new NotFoundException(); }
            }
        }
        public Room this[int index]
        {
            get
            {
                return _rooms[index];
            }
            set
            {
                _rooms[index] = value;
            }
        }

    }
}
