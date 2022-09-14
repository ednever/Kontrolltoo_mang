using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    class Mang
    {
        Tegelane[] mangija;
        public Mang(Tegelane[] mangija)
        {
            this.mangija = mangija;
        }
        public List<Tegelane> suurimaEsemeteArvuga()
        {
            List<Tegelane> voitjad = new List<Tegelane>();
            Tegelane sorted = mangija[0];
            foreach (Tegelane tegelane in mangija)
            {
                int num = sorted.CompareTo(tegelane);
                if (num < 0)
                {
                    sorted = tegelane;
                    voitjad.Clear();
                }
                if (num == 0) voitjad.Add(tegelane);                
            }
            voitjad.Add(sorted);
            return voitjad;
        }
        public Tegelane suurimaPunktideArvuga()
        {
            int parim = 0;
            Tegelane voitja = mangija[0];
            foreach (var item in mangija)
            {
                int arv = item.punktideArv();
                if (arv > parim)
                {
                    parim = arv;
                    voitja = item;
                }
            }
            return voitja;
        }
    }
}
