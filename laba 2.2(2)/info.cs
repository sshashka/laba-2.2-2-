using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._2_2_
{
    class song
    {
        public string Named { get; set; }
        public double Lengh { get; set; }
        public string Genre { get; set; }
        public song(string name, double lengh, string genre)
        {
            this.Named = name;
            this.Lengh = lengh;
            this.Genre = genre;
        }
    }
}
