using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    class Tegelane : IUksus , IComparable<Tegelane>
    {
        string nimi;
        List<Ese> esed = new List<Ese>();
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public void lisaEse(Ese valik) 
        { 
            esed.Add(valik);
        }
        public void valjastaEsemed()
        {
            foreach (Ese item in esed)
            {
                Console.WriteLine($" <<<{item.printInfo()}>>> ");
            }
        }
        public int punktideArv()
        {
            int arv_sum = 0;
            foreach (Ese item in esed)
            {
                arv_sum += item.punktideArv();
            }
            return arv_sum;
        }
        public string printInfo()
        {
            string tegelase_info = nimi + ", " + esed.Count() + ", " + punktideArv();
            return tegelase_info;
        }
        public int CompareTo(Tegelane? muu)
        {
            if (muu == null) return 1;
            return this.esed.Count - muu.EsesKogus();
        }
        int EsesKogus() { return this.esed.Count; }
    }
}
