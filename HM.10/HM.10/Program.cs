using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM._09
{
    public class Song
    {
        public readonly string SongName;
        public readonly int SongTime;
        public readonly string SongAuthor;
        public readonly int SongYear;
        public Song()
        {
            Console.WriteLine("Введите название песни");
            SongName = Console.ReadLine();
            Console.WriteLine("Введите длинну песни в минутах");
            SongTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите автора песни");
            SongAuthor = Console.ReadLine();
            Console.WriteLine("Введите год написания песни ");
            SongYear = Convert.ToInt32(Console.ReadLine());
        }
        public dynamic GetSongData(Song songM)
        {          
            var songAnon = new
            {
                songM.SongAuthor,
                songM.SongName,
                songM.SongTime,
                songM.SongYear
            };             
            Console.WriteLine
                ($"Песня {SongName} cоздана в {SongYear} году , автором песни является {SongAuthor},длительность песни {SongTime} минут ");
            return songAnon;
        }   
    }       

    class Program  
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            int songYear = song.SongYear;
            string songAut = song.SongAuthor;
            string songN = song.SongName;
            int songTime = song.SongTime;
            song.GetSongData(song);
           
            Console.ReadKey();
        }
    }
}
