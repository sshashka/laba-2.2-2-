using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._2_2_
{
    class Disk
    {
        private string name;
        public Disk(string disk)
        {
            this.name = disk;
        }
        private static int Comparer(song sg1, song sg2)
        {
            string s1 = sg1.Genre.ToLower();
            string s2 = sg2.Genre.ToLower();


            for (int i = 0; i<Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] == s2[i]) continue;
                if (s1[i] > s2[i]) return 1;
                else return -1;
            
            }
            if (s1.Length > s2.Length) return 1;
            else return -1;

        }
        private List<song> infolen = new List<song>();
        public void SortByGenre()
        {
            infolen.Sort(Comparer);
        }
        public void AddSong(song sogn)
        {
            infolen.Add(sogn);
        }
        public void Print()
        {
            foreach (song s in infolen)
            {
                Console.WriteLine("Name: " + s.Named + " Genre: " + s.Genre);
            }
        }

        public List<string> GetMusicByDiap(double a, double b)
        {
            List<string> result = new List<string>();
            foreach (song info in infolen)
            {
                if (info.Lengh<= b && info.Lengh>= a)
                {
                    result.Add(info.Named);
                }
            }

            return result;
        }
    }
}
