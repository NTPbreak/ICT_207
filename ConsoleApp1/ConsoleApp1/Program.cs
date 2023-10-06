using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 7, x = 12;
            Console.WriteLine("Bonjour je suis un noveau projet dans la -> memory "+s);
            Console.WriteLine("Petit addition de " + s + " et de " + x + " = " + add(s, x));
            Console.WriteLine("voulez-vous vous du travail ?:");
            String v = Console.ReadLine(); 
            if (v == "oui" || v == "o")
                {
                Accept();
            }
            else
            {
                Console.WriteLine("Domage j'avais de grand projet pour vous");
            }
            
        }
        static int add(int a , int b)
        {
            return a + b;
        }
        static void Accept()
        {
            Console.WriteLine("Vous avez accepter aaa \nBienvenue dans la secte coulloulou vous avez 24h pour tuer quelqu'un aaa\nsinon c'est nous qui vous tuerons");
        }

    }
}
