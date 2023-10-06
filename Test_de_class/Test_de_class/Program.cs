using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_de_class
{
    internal class Program
    {
        class User
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public void login()
            {
                throw new NotImplementedException();
            }
            public void logout()
            {
                throw new NotImplementedException();
            }

        }

        class Proffesseur : User
        {
            public bool IsTurned { get; set; }
            public DateTime HiringDate { get; set; }    
        }
        static void Main(string[] args)
        {
            Proffesseur prof = new Proffesseur();
            List<Proffesseur> proffes = new List<Proffesseur>();
            proffes.Add(new Proffesseur { UserName = "NTP" ,Password = "NTP"});
            proffes.Add(new Proffesseur { UserName = "NMP", Password = "NMP" });
            //prof.login();
            //prof.logout();
            prof.IsTurned = true;
            int i = 1;
            foreach (var Proffesseur in proffes)
            {

                Console.WriteLine($"Username{i}: {Proffesseur.UserName}");
                i++;
            }
            //Console.WriteLine($"Prof: {prof.UserName}");
        }
    }
}
