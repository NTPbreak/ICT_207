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
            private static int Nbr_Employer=0 ;
            public Salaire(String NomEmployer,String Sexe, DateTime Annee_de_recrutement, String Poste)
            {    
                    this.NomEmployer = NomEmployer;
                    this.Sexe = Sexe;
                    this.Annee_de_recrutement = Annee_de_recrutement;
                    this.Poste = Poste;
                    Nbr_Employer++;
                
                if(this.Poste == "INFORMATICIEN" || this.Poste == "INFORMATICIENNE") this.SalaireEmployer = 200000;
                else if(this.Poste == "COMPTABLE")  this.SalaireEmployer = 100000;
                else this.SalaireEmployer = 90000;
            }
            public void  CalculSalaire()
            {   
                int ans = this.date_now - this.Annee_de_recrutement.Year;
                double sal = (this.SalaireEmployer * 0.02) * ans;
                this.SalaireEmployer = this.SalaireEmployer +  sal ;                   
            }
  
            public void Afficher_information_Employer()
            {

                Console.WriteLine($"Nom : {this.NomEmployer}\n\nSexe : {this.Sexe}\n\nDate de recrutement : {this.Annee_de_recrutement}\n\nSalaire : {this.SalaireEmployer:0}FCFA\n\nPoste : {this.Poste}\n");            }
            public static int  get_Nbr_Employer()
            {
                return Nbr_Employer;
            }
        }
        static void Main(string[] args)
        {
            String NomEmployer;
            String Sexe;
            DateTime Annee_de_recrutement;
            //String date_transition;
            String choix="1";
            String Poste;
            //String jour;
            //String mois;
            //String Annee;
            bool no;
            Console.Clear();
            int n=0;
          
           
            
           
            n = control_nbr_employer();

            Console.Clear();
            Salaire[] Employer = new Salaire[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Donner le nom de l'employer {i + 1} : ");
                NomEmployer = Console.ReadLine();
                NomEmployer = control_name(NomEmployer, i);
                Console.WriteLine("\nDonner le sexe de l'employer (notation: M ou F ): ");
                Sexe = Console.ReadLine();
                Sexe = control_sexe(Sexe);
               
                Annee_de_recrutement = control_date();
                Console.WriteLine("\nChoississez votre poste: \n(1) pour Informaticien \n(2) pour Comptable \n(3) pour Secretaire\n");
                choix = Console.ReadLine();
                while (choix != "1" && choix != "2" && choix != "3")
                {
                    Console.WriteLine("\nVeuillez-donnez un choix compris entre 1 et 3 \nChoississez votre poste: \n(1) pour Informaticien \n(2) pour Comptable \n(3) pour Secretaire\n");
                    choix = Console.ReadLine();
                }
                if (choix == "1")
            {
                if(Sexe == "M")
                {
                    Poste = "Informaticien".ToUpper();
                }
                else
                {
                    Poste = "Informaticienne".ToUpper();
                }
            }
                else if(choix == "2")
            {
                Poste = "Comptable".ToUpper();
            }
                else
            {
                Poste = "Secretaire".ToUpper();
            }
            Employer[i] = new Salaire(NomEmployer, Sexe, Annee_de_recrutement, Poste);
            Employer[i].CalculSalaire();
            Console.Clear();
                }
            info_eleve();
            for (int i = 0; i < n; i++)
                {
                    
                    Console.WriteLine($"---------Employers {i + 1}----------\n");
                    Employer[i].Afficher_information_Employer();
                }
             int NombreEmployer = Salaire.get_Nbr_Employer();
             Console.WriteLine($"Nombre d'employer au total : {NombreEmployer}\n");
        }
        public static void info_eleve()
        {
            Console.WriteLine("-------Nom de l'etudiant--------\n\nNegoue Tchinda Patrick 22V2365\n");
        }
        public static String control_name(String name,int i)
        {
            while(name == "" || name.Substring(0) == "0" || name.Substring(0) == "1" || name.Substring(0) == "2" || name.Substring(0) == "3" ||
                 name.Substring(0) == "4" || name.Substring(0) == "5" || name.Substring(0) == "6" ||
                 name.Substring(0) == "7" || name.Substring(0) == "8" ||  name.Substring(0) == "9")
            {
                Console.WriteLine($"\nVous n'avez pas donner le nom de l'employer veuillez le saisir\n\nNom de l'employer {i+1}: ");
                name = Console.ReadLine();
            }
       
            return name;
        }
        public static DateTime control_date()
        {
            String jour, mois, Annee, date_transition;
            Console.WriteLine("\nDonner la date de recrutement de l'employer\n\nJour :");
            jour = Console.ReadLine();
            int n = 0;
            bool no;
            while (!int.TryParse(jour, out n))
            {
                Console.WriteLine("Veuillez entrer des entiers \njour: ");
                jour = Console.ReadLine();
            }
            //if(DateTime.MaxValue.CompareTo(jour) < 0)
            if (int.Parse(jour) < 1 || int.Parse(jour) > DateTime.MaxValue.Day)
            {
                //Console.WriteLine("no:" + no);
                while ( int.Parse(jour) < 1 || int.Parse(jour) > DateTime.MaxValue.Day || !int.TryParse(jour,out n))
                { 
                    Console.WriteLine("Erreur jour non valide\njour: ");
                    jour = Console.ReadLine();
                    while (!int.TryParse(jour, out n))
                    {
                        Console.WriteLine("Veuillez entrer des entiers \njour: ");
                        jour = Console.ReadLine();
   
                    }
                }

            }
           
            Console.WriteLine("Mois :");
            mois = Console.ReadLine();
            no = control_nb_employer_2(mois, n);
            while (!int.TryParse(mois, out n))
            {
                Console.WriteLine("Veuillez entrer des entiers \nmois: ");
                mois = Console.ReadLine();
            }
            //if(DateTime.MaxValue.CompareTo(jour) < 0)
            if (int.Parse(mois) < 1 || int.Parse(mois) > DateTime.MaxValue.Day)
            {
                //Console.WriteLine("no:" + no);
                while (int.Parse(mois) < 1 || int.Parse(mois) > DateTime.MaxValue.Day)
                {
                    Console.WriteLine("Erreur mois non valide\nmois: ");
                    mois = Console.ReadLine();
                    while (!int.TryParse(mois, out n))
                    {
                        Console.WriteLine("Veuillez entrer des entiers \nmois: ");
                        mois = Console.ReadLine();
                    }
                }

            }

            Console.WriteLine("Annee :");
            Annee = Console.ReadLine();
            while (!int.TryParse(Annee, out n))
            {
                Console.WriteLine("Veuillez entrer des entiers \nAnnee: ");
                Annee = Console.ReadLine();
            }
            if (int.Parse(Annee) > DateTime.Now.Year || int.Parse(Annee) < 2000)
            {
                while (int.Parse(Annee) < 2000 || int.Parse(Annee) >  DateTime.Now.Year)
                {
                    Console.WriteLine("Erreur Annee non valide\nAnnee: ");
                    Annee = Console.ReadLine();
                    while (!int.TryParse(Annee, out n))
                    {
                        Console.WriteLine("Veuillez entrer des entiers \nAnnee: ");
                        Annee = Console.ReadLine();
                    }
                }
            }

            date_transition = jour + "/" + mois + "/" + Annee;
            
            DateTime dd = DateTime.Parse(date_transition);
                return dd ;
        }
        public static String control_sexe(String sexe)
        {
            sexe = sexe.ToUpper();
            while(sexe!="F" && sexe!= "M")
            {
                Console.WriteLine("Veuillez entrer le sexe conformement au format: F ou M\n\nSexe de l'employer: ");
                sexe = Console.ReadLine().ToUpper();
            }
            return sexe;
        }
        public static int  control_nbr_employer()
        {
            int n = 0;
            int nbr_employer=0;
            Console.WriteLine("Entrer le nombre d'employer: ");
            String n1 = Console.ReadLine();
 
            while(!int.TryParse(n1, out n))
            {
                Console.WriteLine("Erreur veuillez entrer des entiers\n\nEntrer le nombre d'employer: ");
                n1 = Console.ReadLine();
            }
            while (int.Parse(n1) <= 0)
            {
                Console.WriteLine("\nVeuillez entrer au moin un employer\nNombre d'employer: ");
                    n1 = Console.ReadLine();
                while (!int.TryParse(n1, out n))
                {
                    Console.WriteLine("Erreur veuillez entrer des entiers\n\nEntrer le nombre d'employer: ");
                    n1 = Console.ReadLine();
                }
            }
            nbr_employer = int.Parse(n1);
            return nbr_employer;
        }
        public static bool control_nb_employer_2(String n1 , int n)
        {
            bool no = int.TryParse(n1, out n);
            if (no)
            {
               return true;
            }
            else
            {

                return false;
            }
        }
    }
}
