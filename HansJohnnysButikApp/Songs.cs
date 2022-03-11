using System;
using System.Collections.Generic;
namespace HansJohnnysButikApp
{
    public class Songs : Media
    {
        public string Featuring { get; set; }
        public Songs(string fromSongsCsv)
        {
            string[] columns = fromSongsCsv.Split(_separator);

            Id = Convert.ToInt32(columns[0]);
            Title = columns[1];
            Featuring = columns[2];
            Length = columns[3];
        }
        public static void PrintSongs(IEnumerable<Songs> songs)
        {            
            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Title,37} {song.Featuring,30} {song.Length,10:hh:mm:ss}");
            }
        }
    }
}
