using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    class Tegelane : Uksus //, IComparable<Tegelane>
    {
        string nimi;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }

        public int lisaEse(int valik)
        {
            return valik;
        }

        public void valjastaEsemed(List<Ese> list, int valik)
        {
            Ese zxc = list[valik];
            Console.WriteLine(zxc.printInfo());
        }
        public int punktideArv() //List<Ese> list, int valik
        {
            //Ese zxc = list[valik];        
            return 0; //zxc.punktideArv();
        }
        public string printInfo()
        {
            return nimi;
        }

        //public int CompareTo(Tegelane? other)
        //{
        //    if (other == null) return 1;
        //    return m_value.CompareTo(other.m_value);
        //}
    }
}
