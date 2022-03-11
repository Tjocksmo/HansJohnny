using System;
using System.Collections.Generic;
using System.Linq;

namespace HansJohnnysButikApp
{
    public class Albums : Media
    {
        public int AmountSongs { get; set; }
        public List<Songs> songs { get; set; }        
        public Albums(string fromAlbumCsv)
        {            
            string[] columns = fromAlbumCsv.Split(_separator);

            Id = Convert.ToInt32(columns[0]);
            Title = columns[1];
            Creator = columns[2];
            UserGrade = Convert.ToDouble(columns[3]);
            ReleaseDate = Convert.ToDateTime(columns[4]);
            Length = columns[5];
            AmountSongs = Convert.ToInt32(columns[6]);
            Price = _randomizer.Next(49, 259);
        }
        public static void PrintAlbums(List<Albums> albums)
        {
            IEnumerable<Albums> musicSortedByUserGrade = albums.OrderByDescending(p => p.UserGrade)
                                                    .ThenBy(p => p.Creator)
                                                    .ThenBy(p => p.Title)
                                                    .ToList();

            foreach (Albums album in musicSortedByUserGrade)
            {
                Console.WriteLine($"Album: {album.Title}: " +
                    $"{album.Creator}\n      " +
                    $"Rating: {album.UserGrade}\n      " +
                    $"Release datum: {album.ReleaseDate:yyyy-MM-dd} \n      " +
                    $"Speltid: {album.Length:hh:mm:ss} \n      " +
                    $"Antal låtar:{album.AmountSongs} \n      " +
                    $"Pris: {album.Price}:-\n");
            }
        }
        public static void ConnectAlbumsWithSongs(List<Albums> albums, List<Songs> songs)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                List<Songs> albumSongs = new List<Songs>();
                foreach (var song in songs)
                {
                    if (song.Id == albums[i].Id)
                    {
                        albumSongs.Add(song);
                    }
                }
                albums[i].songs = albumSongs;
            }
        }   
        internal static void PrintAlbumsWithSongs(List<Albums> albums)
        {
            IEnumerable<Albums> musicSortedByUserGrade = albums.OrderByDescending(p => p.UserGrade)
                                        .ThenBy(p => p.Creator)
                                        .ThenBy(p => p.Title)
                                        .ToList();

            foreach (var album in musicSortedByUserGrade)
            {
                Console.WriteLine($"\nAlbum: {album.Title}: " +
                    $"{album.Creator}\n      " +
                    $"Rating: {album.UserGrade}\n      " +
                    $"Release datum: {album.ReleaseDate:yyyy-MM-dd}\n      " +
                    $"Speltid: {album.Length:hh:mm:ss}\n      " +
                    $"Pris: {album.Price}:-\n");
                Songs.PrintSongs(album.songs);
                Console.WriteLine("________________________________________________________________________________");
            }
        }
    }    
}