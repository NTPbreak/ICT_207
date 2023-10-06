using System;
/*using System.IO;*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        enum FacultyLevel { ASSISTANT, INSTRUCTOR, ASSOCIATE, FULLPROFESSOR };
        static void Main(string[] args)
        {
            //Afficher hello world
            int YearsOfExperience = 12;
            String s;
            double Salary = 100000;
            bool Isveteran = false;
            String FullName = "Razman A mezei";
            DateTime CurentDateTime = DateTime.Now;
            Console.WriteLine("Hello world !");
            Console.WriteLine("YearsOfExperience : " + YearsOfExperience + "\nSalary : " + Salary + "\nISveteran : " + Isveteran + "\nFullName : " + FullName + "\nCurentDateTime : " + CurentDateTime);
            Console.WriteLine("Veuillez entrer un nombre et je vous donnerais son factorielle");
            s = Console.ReadLine();
            int se = int.Parse(s);
            Console.WriteLine("factorielle de  " + s + " = " + recurence(se));
            FacultyLevel current = FacultyLevel.ASSISTANT;
            Console.WriteLine($"Faculty level : {current}");
        }
        static int recurence(int a)
        {
            if (a == 1)
            {
                return a;
            }
            else
            {
                return a * recurence(a - 1);
            }
        }
    }
}
