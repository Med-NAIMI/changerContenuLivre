using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changerContenuLivre
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("svp, entrez le nbr de personne qui stockent le livre!");
            int p = Convert.ToInt32(Console.ReadLine());

            string continu = "oui";
            string s1;
            List<string> l = new List<string>();

            while(continu=="oui")
            {
                Console.WriteLine("svp, entrez la proposition de modification accomagnée du nbr d'accord associé!");
                Console.WriteLine("example de proposition (a 4) pour une proposition d'ecriture de a à 4 accords");

                s1 = Console.ReadLine();

                l.Add(s1);//ajout de proposition
                Console.WriteLine("svp, entrez oui pour continuer la saisie de propositions!");
                continu = Console.ReadLine();
            }

            Console.WriteLine("le livre resultant après modification est: "+Traitement.contenuLivre(l, p));
            
            Console.WriteLine("end");
            
            Console.ReadKey();//pour conserver l'affichage
         }

    
    }
}
