using _28._03._2022_aboutSinger_HomeWork_.Models;
using System;

namespace _28._03._2022_aboutSinger_HomeWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add Singer's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please add Singer's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please add Singer's age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Singer singer = new Singer(name,surname,age);
            Console.WriteLine(singer.Name + " " + singer.Surname + " " + singer.Age);


            Console.WriteLine("Please add Song's name: ");
            string songName = Console.ReadLine();
            Console.WriteLine("Please add Song's genre: ");
            string genre = Console.ReadLine();
          

            Song song = new Song(songName,genre);

            Console.WriteLine(song.SongName + " " + song.Genre);

            song.AddRating(4);
            song.AddRating(2);

            Console.WriteLine(song.GetAverageRating());

        }
    }
}
