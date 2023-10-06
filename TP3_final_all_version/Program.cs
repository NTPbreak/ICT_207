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
            private static String mot_de_passe = "652665402";
            private static String NomAdmin = "Negoue Tchinda Patrick";
            private int date_now = DateTime.Now.Year;
            private static int Nbr_Employer=0 ;
            public Salaire(String NomEmployer,String Sexe, double SalaireEmployer, DateTime Annee_de_recrutement, String Poste)
            {
              
                
                    this.NomEmployer = NomEmployer;
                    this.Sexe = Sexe;
                    this.SalaireEmployer = SalaireEmployer;
                    this.Annee_de_recrutement = Annee_de_recrutement;
                    this.Poste = Poste;
                    Nbr_Employer++;
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
            public static int  get_Nbr_Employer()
            {
                return Nbr_Employer;
            }
            public void Creer_nouvelle_Admin(String Mot_de_passe, String nomAdmin)
            {
                mot_de_passe = Mot_de_passe;
                NomAdmin = nomAdmin;

            }
           
            public static int identification_admin(string Mot_de_passe, string nomAdmin)
            {
                if(mot_de_passe == Mot_de_passe && NomAdmin == nomAdmin)
                {
                    return 1;
                }
                return 0;
            }

     
        }
        static void Main(string[] args)
        {
            String NomEmployer;
            String Sexe;
            DateTime Annee_de_recrutement;
            String date_transition;
            double SalaireEmployer;
            String Poste;
            String pass;
            String name;
            Console.WriteLine("Donner le nom de l'administrateur: ");
            name = Console.ReadLine();
            Console.WriteLine("Donner le mot de passe: ");
            pass = Console.ReadLine();
            int verification = Salaire.identification_admin(pass,name);
            if(verification == 0)
            {
                Not_identification();
            }
            Console.Clear();


            
                Console.WriteLine("Entrer le nombre d'employer: ");
                String n1 =  Console.ReadLine();
                int n = int.Parse(n1);
                Salaire[] Employer = new Salaire[n];
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine($"Donner le nom de l'employer {i + 1} : ");
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
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    info_eleve();
                    Console.WriteLine($"---------Employers {i + 1}----------");
                    Employer[i].Afficher_information_Employer();
                }
                int NombreEmployer = Salaire.get_Nbr_Employer();
                Console.WriteLine($"Nombre d'employer restant : {NombreEmployer}");
            
          
           
        }
        public static void info_eleve()
        {
            Console.WriteLine("Negoue Tchinda Patrick 22V2365");
        }
        public static void Not_identification()
        {
            throw new Exception("Compte non existant");
        }
    }
}
