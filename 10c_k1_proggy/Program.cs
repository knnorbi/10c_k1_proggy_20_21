using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10c_k1_proggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hany random szam legyen?");
            int randomSzamokSzama = int.Parse(Console.ReadLine());

            int[] szamok = new int[randomSzamokSzama];

            Random random = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 101);
            }

            Console.WriteLine("A tomb elemei:");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"[{i}] => {szamok[i]}");
            }

            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];                    // osszeg = osszeg + szamok[i];
            }

            Console.WriteLine($"A tomb osszege: {osszeg}.");

            Console.ReadLine();

        }
    }
}
