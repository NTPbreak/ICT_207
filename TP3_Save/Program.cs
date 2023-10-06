using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Program
    {
        class Salaire
        {
            private String NomEmployer ;
            private String Sexe;
            private double SalaireEmployer ;
            private DateTime Annee_de_recrutement;
            private String Poste;
            private int date_now = DateTime.Now.Year;
            public Salaire(String NomEmployer,String Sexe, double SalaireEmployer, DateTime Annee_de_recrutement, String Poste)
            {
               this.NomEmployer = NomEmployer;
                this.Sexe = Sexe;
                this.SalaireEmployer = SalaireEmployer;
                this.Annee_de_recrutement = Annee_de_recrutement;
                this.Poste = Poste;
            }
            public double CalculSalaire()
            {

                
                int ans = this.date_now - this.Annee_de_recrutement.Year;
                double Salaire_Employer_annee = prix_salaire(ans, this.SalaireEmployer);
                return Salaire_Employer_annee;
                   
            }
            public double prix_salaire(int difference_Annee,double salaire_initiale )
            {

                if (difference_Annee == 0)
                {
                    return salaire_initiale;
                }
                else
                {
                    double sal_actu = salaire_initiale + (salaire_initiale * 0.02);
                    return prix_salaire(difference_Annee - 1,sal_actu);
                }
            }
            public void Afficher_information_Employer()
            {

                Console.WriteLine($"Nom : {this.NomEmployer}\nSexe : {this.Sexe}\nDate de recrutement : {this.Annee_de_recrutement}\nSalaire : {this.SalaireEmployer}FCFA\nPoste : {this.Poste}");
                Console.WriteLine($"Salaire Actuel : {CalculSalaire():0.00}FCFA");
            }
        }
        static void Main(string[] args)
        {
            /*Salaire*/
           /* DateTime date = DateTime.Parse("27/01/2022 12:22:00");
            DateTime date2 = DateTime.Parse("05/06/2018 5:14:00");
            DateTime date3 = DateTime.Parse("15/09/2019 6:26:00");*/
           /* Console.WriteLine($"{date.Year}");*/
            /*Salaire Employer1 = new Salaire("ELondo Ebassa yannick", "M", 90000,date, "Secretaire");
            Salaire Employer2 = new Salaire("Negoue Tchinda Patrick", "M", 200000,date2, "informaticien");
            Salaire Employer3 = new Salaire("Kemzang Teumena Bryan", "M", 100000,date3, "Comptable");
            double salaire_annuelle = Employer1.CalculSalaire();
            Employer1.Afficher_information_Employer();
            Employer2.Afficher_information_Employer();
            Employer3.Afficher_information_Employer();*/
            /*Console.WriteLine($"Salaire actuelle : {salaire_annuelle}");*/
            String NomEmployer;
            String Sexe;
            DateTime Annee_de_recrutement;
            String date_transition;
            double SalaireEmployer;
            String Poste;
            int n = 1;
            Salaire[] Employer = new Salaire[n];
            Console.WriteLine("Negoue Tchinda Patrick 22V2365");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Donner le nom de l'employer {i+1} : ");
                NomEmployer = Console.ReadLine();
                Console.WriteLine("Donner le sexe de l'employer (notation: M ou F ): ");
                Sexe = Console.ReadLine();
                Console.WriteLine("Donner la date de recrutement de l'employer (format: 27/09/2023 20:10:00) :");
                date_transition = Console.ReadLine();
                Annee_de_recrutement = DateTime.Parse(date_transition);
                Annee_de_recrutement.AddHours(12).AddMinutes(00).AddMilliseconds(10);
                Console.WriteLine("Donner le salaire de l'employer: ");
                String Salaire_transition = Console.ReadLine();
                SalaireEmployer = int.Parse(Salaire_transition);
                Console.WriteLine("Donner le Poste de l'employer au seins de l'entreprise : ");
                Poste = Console.ReadLine();
                Employer[i] = new Salaire(NomEmployer, Sexe, SalaireEmployer, Annee_de_recrutement, Poste);
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"---------Employers {i+1}----------");
                Employer[i].Afficher_information_Employer();
            }
        }
    }
}
