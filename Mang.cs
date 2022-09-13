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
        public Tegelane suurimaEsemeteArvuga()
        {
            return mangija[0];
        }
        //public Tegelane suurimaPunktideArvuga()
        //{

        //}
    }
}
