using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    class Program //: Uksus
    {
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding();

            StreamReader from_file = new StreamReader(@"..\..\..\Esemed.txt");
            string text;
            List<Ese> esed = new List<Ese>();

            while ((text = from_file.ReadLine()) != null)
            {
                string[] words = text.Split(';');
                esed.Add(new Ese(words[0], int.Parse(words[1])));
            }
            from_file.Close();

            Tegelane asd = new Tegelane("Darwin");

            Console.Write(asd.printInfo() + ", " + asd.valjastaEsemed(esed, asd.lisaEse(0))); //+ asd.punktideArv(esed, asd.lisaEse(0))


            //Uksus obj = new Program();
            //obj.printInfo();
        }
        //int Uksus.punktideArv()
        //{
        //    return 0;
        //}
        //string Uksus.printInfo()
        //{

        //    Console.WriteLine();
        //    return "";
        //}
    }
}