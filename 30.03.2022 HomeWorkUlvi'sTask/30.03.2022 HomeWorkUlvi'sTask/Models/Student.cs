using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._2022_HomeWorkUlvi_sTask.Models
{
    class Student : Person
    {
        private int _iqRank;
        private int _languageRank;
        private int _age;

        public int Iqrank
        {
            get { return _iqRank; }
            set
            {
                if (value <= 100 && value>0 )
                {
                    _iqRank = value;
                }
            }
        }

        public int LanguageRank
        {
            get { return _languageRank; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _languageRank = value;
                }
            }
        }

        public override int Age
        {
            get { return _age; }
            set
            {
                if (value <= 18 && value >=6)
                {
                    _age = value;
                }
            }
        }

        public Student(string name, string surname, int age, int iqRank, int languageRank) : base(name,surname)
        {
            Age = age;
            Iqrank = iqRank;
            LanguageRank = languageRank;
        }
        public void ExamResults()
        {
            if (Age >= 6 && Age <= 20)
            {
                if (Iqrank + LanguageRank < 120)
                {
                    Console.WriteLine("Teessufki imtahandan kesilmisiniz");
                }
                Console.WriteLine("Tebrikler");
            }
        }
    }
}
