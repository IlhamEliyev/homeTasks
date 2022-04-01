using System;
using System.Collections.Generic;
using System.Text;

namespace _04._04._2022Bashir_sTask.Models
{
    class Room
    {
        private static int _id;
        private string _name;
        private double _price;
        private int _personCapacity;
        public bool IsAvailable { get; set; } = true;

        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            ID = PlusId();
        }

        public int PlusId()
        {
            _id++;
            return _id;
        }
        public int ID
        {

            get; set;
        }

        public string Name { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int PersonCapacity
        {
            get { return _personCapacity; }
            set
            {
                if (value > 0)
                {
                    _personCapacity = value;
                }
            }
        }
        public string ShowInfo()
        {
            return $@"----Room Information----
Name - {Name}
Price - {Price}
Person Capacity - {PersonCapacity}
Available - {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
