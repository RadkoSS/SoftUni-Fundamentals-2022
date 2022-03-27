using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Songs
{
    internal class Program
    {
        class Song
        {
            public string typeList { get; set; }
            public string name { get; set; }
            public string time { get; set; }

        }
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currentSong = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string type = currentSong[0];
                string name = currentSong[1];
                string time = currentSong[2];

                Song song = new Song();
                song.name = name;
                song.time = time;
                song.typeList = type;

                songsList.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songsList)
                {
                    Console.WriteLine(song.name);
                }
            }

            else
            {
                foreach (Song song in songsList)
                {
                    if (song.typeList == typeList)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }
        }

    }
}
