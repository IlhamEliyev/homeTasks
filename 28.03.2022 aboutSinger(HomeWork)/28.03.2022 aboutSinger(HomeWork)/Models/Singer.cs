using System;
using System.Collections.Generic;
using System.Text;

namespace _28._03._2022_aboutSinger_HomeWork_.Models
{
    class Singer
    {
        private string name;
        private string surname;
        private int age;

        public Singer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 100)
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value.Length < 100)
                {
                    surname = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 170)
                {
                    age = value;
                }
            }
        }

    }
}
