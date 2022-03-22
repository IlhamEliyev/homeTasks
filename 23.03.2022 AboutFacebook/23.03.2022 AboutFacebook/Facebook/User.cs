using System;
using System.Collections.Generic;
using System.Text;

namespace _23._03._2022_AboutFacebook.Facebook
{
    class User
    {
        public string name;
        public string surname;
        public string email;
        public string dateOfBirth;
        public string isSingle;
        public Post[] posts;

        public User()
        {
                
        }
        public User(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public User(string name, string surname, string email) : this(name,surname)
        {
            this.email = email;
        }
    }
}
