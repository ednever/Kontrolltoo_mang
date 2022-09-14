using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    public class Ese : IUksus
    {
        string ese;
        int points;

        public Ese(string ese, int points)
        {
            this.ese = ese;
            this.points = points;
        }

        public int punktideArv() {return points; }
        public string printInfo() { return ese; }
    }
}
