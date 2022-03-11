using System;
using System.IO;

namespace HansJohnnysButikApp
{
    public class MediaReader
    {
        public string _movie;
        public string _music;
        public string _song;        
        public MediaReader()
        {
            _movie = ReadFromMoviesCsv("Movies.csv");
            _music = ReadFromMusicCsv("Albums.csv");
            _song = ReadFromSongsCsv("Songs.csv");
        }
        public static string ReadFromMoviesCsv(string csvFileReadMovies)
        {
            bool isNotNull = true;
            string movieCsvDataSet = "";
            try
            {
                using (FileStream fileStream = File.Open(csvFileReadMovies, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            movieCsvDataSet = fileStreamReader.ReadLine();
                            if (movieCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.MovieList.Add(new Movies(movieCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return movieCsvDataSet;
        }
        public static string ReadFromMusicCsv(string csvFileReadMusic)
        {
            bool isNotNull = true;
            string musicCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileReadMusic, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            musicCsvDataSet = fileStreamReader.ReadLine();
                            if (musicCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.AlbumList.Add(new Albums(musicCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return musicCsvDataSet;
        }
        public static string ReadFromSongsCsv(string csvFileReadSongs)
        {
            bool isNotNull = true;
            string songCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileReadSongs, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            songCsvDataSet = fileStreamReader.ReadLine();
                            if (songCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.SongList.Add(new Songs(songCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return songCsvDataSet;
        }
    }
}
