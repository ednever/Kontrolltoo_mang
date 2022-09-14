using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StreamReader from_file = new StreamReader(@"..\..\..\Esemed.txt");
            string text;
            List<Ese> esed = new List<Ese>();

            while ((text = from_file.ReadLine()) != null)
            {
                string[] words = text.Split(';');
                esed.Add(new Ese(words[0], int.Parse(words[1])));
            }
            from_file.Close();

            Tegelane tegelane = new Tegelane("Darwin");
            Tegelane tegelane2 = new Tegelane("Keld");

            tegelane.lisaEse(esed[0]);
            tegelane.lisaEse(esed[1]);            
            Console.WriteLine(tegelane.printInfo());
            tegelane.valjastaEsemed();

            tegelane2.lisaEse(esed[2]);
            tegelane2.lisaEse(esed[3]);
            Console.WriteLine(tegelane2.printInfo());
            tegelane2.valjastaEsemed();

            Tegelane[] mangijad = new Tegelane[2] { tegelane, tegelane2 };
            Mang uusMang = new Mang(mangijad);
            Tegelane voitja = uusMang.suurimaPunktideArvuga();
            voitja.printInfo();
            


        }
    }
}