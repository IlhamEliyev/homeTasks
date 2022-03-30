using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._2022_HomeWorkUlvi_sTask.Models
{
    abstract class Person
    {
        private string _name;
        private string _surname;

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract int Age { get; set; }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
            }
        }

    }
}
