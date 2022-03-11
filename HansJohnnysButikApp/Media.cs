using System;

namespace HansJohnnysButikApp
{
    public class Media
    {
        public const string _separator = ";";
        public int Id { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Length { get; set; }
        public double UserGrade { get; set; }
        public int Price { get; set; }

        public Random _randomizer = new Random();
    }
}
