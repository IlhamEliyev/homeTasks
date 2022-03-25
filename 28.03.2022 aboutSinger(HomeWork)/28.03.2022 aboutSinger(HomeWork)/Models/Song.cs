using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28._03._2022_aboutSinger_HomeWork_.Models
{
    class Song
    {
        private string songName;
        private string genre;
        private Singer singer;
        private int[] ratings = new int[0];

        public Song(string songName, string genre)
        {
            SongName = songName;
            Genre = genre;
        }

        public string SongName
        {
            get
            {
                return songName;
            }
            set
            {
                if (value.Length < 100)
                {
                    songName = value;
                }
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                string[] genreNames = {"Pop", "Rock", "Jazz", "Techno" };
                for (int i = 0; i < genreNames.Length; i++)
                {
                if (genreNames [i] == value)
                {
                    genre = value;
                }
                }
            }
        }
        public Singer Singer
        {
            get
            {
                return singer;
            }
            set
            {
                singer = value;
            }
        }

        public void AddRating(int rating)
        {
            if (rating >= 0 && rating<=5)
            {
                Array.Resize(ref ratings,ratings.Length + 1);
                ratings[ratings.Length - 1] = rating;
            }
        }
        public double GetAverageRating()
        {
            return Math.Round(ratings.Average(),1);
        }
    }
}
