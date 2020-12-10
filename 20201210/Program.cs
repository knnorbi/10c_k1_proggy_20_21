using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201210
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello World!";
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();


            string modositott = a.Substring(6);
            Console.WriteLine(modositott);

            modositott = a.Substring(6, 5);
            Console.WriteLine(modositott);

            modositott = a.ToUpper();
            Console.WriteLine(modositott);

            modositott = a.ToLower();
            Console.WriteLine(modositott);

            string b = "        alma        ";
            modositott = b.Trim();
            Console.WriteLine(modositott);
            modositott = b.TrimEnd();
            Console.WriteLine(modositott);
            modositott = b.TrimStart();
            Console.WriteLine(modositott);

            bool vane = a.Contains("world");
            Console.WriteLine(vane);
            vane = a.Contains("World");
            Console.WriteLine(vane);

            vane = a.ToLower().Contains("world");
            Console.WriteLine(vane);

            modositott = a.Replace("Hello", "Hi");
            Console.WriteLine(modositott);

            modositott = ("Hello " + a).Replace("Hello", "Hi");
            Console.WriteLine(modositott);

            vane = a.StartsWith("Fine");
            Console.WriteLine(vane);
            
            vane = a.EndsWith("d!");
            Console.WriteLine(vane);

            Console.WriteLine(a.Insert(1, "e"));
            Console.WriteLine(a.Remove(1));
            Console.WriteLine(a.Remove(1, 2));

            int darab = 42;
            

            Console.WriteLine("Az osztalyban " + darab + " tanulo van.");

            string szoveg = string.Format("Az osztalyban {0} tanulo van.", darab);
            Console.WriteLine(szoveg);

            Console.WriteLine("Az osztalyban {0} tanulo van.", darab);

            szoveg = $"Az osztalyban {darab} tanulo van.";
            Console.WriteLine(szoveg);

            Console.WriteLine($"Az osztalyban {darab} tanulo van. {{asd}}.");



            Console.ReadLine();
        }
    }
}
