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
        class product
        {
            public String ProductName;
            public String Description;
            public double Price;
            public DateTime ManufacturindDate;
            public double weight;
            public void ChangePrice(double NewPrice)
            {
                Price = NewPrice;
            }
        }
        enum FacultyLevel { ASSISTANT, INSTRUCTOR, ASSOCIATE, FULLPROFESSOR };
        static void Main(string[] args)
        {
            //Afficher hello world
            int YearsOfExperience = 12;
            String  s ;
            double Salary = 100000;
            bool Isveteran = false;
            String FullName = "Razman A mezei";
            DateTime CurentDateTime = DateTime.Now;
            Console.WriteLine("Hello world !");
            Console.WriteLine("YearsOfExperience : " + YearsOfExperience + "\nSalary : " + Salary + "\nISveteran : " + Isveteran + "\nFullName : " + FullName + "\nCurentDateTime : " + CurentDateTime);
            Console.WriteLine("Veuillez entrer un nombre et je vous donnerais son factorielle");
            s = Console.ReadLine();
            int se = int.Parse(s);
            Console.WriteLine("factorielle de  "+s+" = " + recurence(se));
            FacultyLevel current = FacultyLevel.ASSISTANT;
            Console.WriteLine($"Faculty level : {current}");
            product produit1 = new product();
            produit1.ProductName = "Orange";
            produit1.Description = "Fruit";
            produit1.Price = 100;
            Console.WriteLine($"Ancien prix = {produit1.Price} ");
            produit1.ManufacturindDate = DateTime.Parse("29/09/2023 00:00:00");
            produit1.weight = 10;
            produit1.ChangePrice(150);
            Console.WriteLine($"produit prix {produit1.Price} \nDate: {produit1.ManufacturindDate.Year}"); 
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
