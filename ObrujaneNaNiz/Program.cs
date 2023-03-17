using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrujaneNaNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi niz: ");
            string input = Console.ReadLine();

            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {

                output += input[i];

            }

            Console.WriteLine($"Oburnatiq niz e: {output}");
        }
    }     //v islovieto pishe metod, no e se seshtam kak da go napravq :)
}
