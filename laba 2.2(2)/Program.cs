using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("Введіть назву диска");
            Disk disk = new Disk(Console.ReadLine());
            
            do
            {
                Console.WriteLine("Введіть назву пісні, довжину через кому і жанр");
                disk.AddSong(new song(Console.ReadLine(), double.Parse(Console.ReadLine()), Console.ReadLine()));
                
                Console.WriteLine("Ви хочете додати ще одну пісню?");
                n = Console.ReadLine();
            } while (n == "y");
            Console.WriteLine("Введіть проміжок часу для пошуку пісні");
            List<string> songs = disk.GetMusicByDiap(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine("Диск відсортовано по імені:");
            disk.SortByGenre();
            disk.Print();
            Console.ReadKey();
        }
        
    }
}
