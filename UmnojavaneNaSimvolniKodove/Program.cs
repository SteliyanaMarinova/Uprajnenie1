using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnojavaneNaSimvolniKodove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bubedi na edin red dwa niza: ");
            string[] strings = Console.ReadLine().Split().ToArray();

            string string1 = strings[0];
            string string2 = strings[1];

            int MinLength = 1;
            int sum = 0;

            if (string1.Length > string2.Length)
            {
                MinLength = string2.Length;
                for (int i = MinLength; i < string1.Length; i++)
                {
                    sum += (int)string1[i];
                }
                   
            }
            else
            {
                MinLength = string1.Length;
                for (int i = MinLength; i < string2.Length; i++)
                {
                    sum += (int)string2[i];
                }
            }

            for (int i = 0; i < MinLength; i++)
            {
                sum += (int)string1[i] * (int)string2[i];
                //pokazwa na ediniq i na drugiq i nakraq obshtiq (razdeleni sa s cherti) :)
                Console.WriteLine("--------------");
                Console.WriteLine($"Result = {sum}");
            }
               
        }
    }
}
        
    

