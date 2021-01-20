using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210120
{
    class Program
    {
        static void Main(string[] args)
        {
            // **************
            // Console.WriteLine(Directory.GetCurrentDirectory());
            // **************
            int[] szamok = new int[6];

            StreamReader sr = new StreamReader("valami.txt");

            string sor;
            int j = 0;
            while (j < szamok.Length && (sor = sr.ReadLine()) != null)
            {
                szamok[j++] = int.Parse(sor);
            }

            sr.Close();

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.ReadKey();
        }
    }
}
