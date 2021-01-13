using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                    // Ezt be kell irni!!

namespace _20210113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = new string[2];
            for (int i = 0; i < sorok.Length; i++)
            {
                sorok[i] = Console.ReadLine();
            }

            StreamWriter sw = new StreamWriter(@"c:\Users\Norbi\source\repos\10c_k1_proggy\20210113\bin\Debug\5sor.txt");

            for (int i = 0; i < sorok.Length; i++)
            {
                sw.WriteLine(sorok[i]);
            }

            sw.Close();



            StreamReader sr = new StreamReader("5sor.txt");
            bool vanSor = true;
            while (vanSor)
            {
                string sor = sr.ReadLine();
                if (sor == null)
                {
                    vanSor = false;
                }
                else
                {
                    Console.WriteLine(sor);
                }
            }
            sr.Close();

            StreamReader sr2 = new StreamReader("5sor.txt");
            string sor2;
            while ((sor2 = sr.ReadLine()) != null)
            {
                Console.WriteLine(sor2);
            }
            sr.Close();

            Console.ReadLine();
        }
    }
}
