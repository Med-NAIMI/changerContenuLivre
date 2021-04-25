using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changerContenuLivre
{
    abstract class Traitement
    {
        public static String contenuLivre(List<string> l, int p )
        {
            Dictionary<char, int> tauxValidationChar = charTauxAffectation(l);
            //extraction de taux de validation pour chaque char

            int tauxAdmissible = p/2;//calcule du taux admissible

            string s1= "";//initialisation de la chaine qui contiendra le livre de retour

            //selection des char ayant un nbr de validation superieure a la moitié d'effectif
            var admissibleChars = tauxValidationChar.Where(p1 => p1.Value>tauxAdmissible).Select(p1=>p1.Key).ToList();
            foreach(char s2 in admissibleChars)
            {
                s1+=s2;//concaténation de tous les chars qui satisfait les conditions
            }
            //Console.WriteLine(s1);
            return s1;
        }

        static Dictionary<char, int> charTauxAffectation(List<string> l)
        {
            Dictionary<char, int> tauxAffectationChar = new Dictionary<char, int>();
            foreach(string s in l)
            {
                try
                {
                    
                        if(!tauxAffectationChar.ContainsKey(s[0]))
                    tauxAffectationChar.Add(s[0],(int)Char.GetNumericValue(s[2]));
                    //nous nous intereserons a s[0] "le char" et s[2] "nbr de personnes qui valide ce char" 

                    else//si la demande a propos de ce char est déja faite, nous enregistrons celle du plus grand nbr de validation
                    {
                        if (s[2] > tauxAffectationChar[s[0]])//
                        {
                            tauxAffectationChar.Remove(s[0]);
                            tauxAffectationChar.Add(s[0], (int)Char.GetNumericValue(s[2]));
                        }
                        else
                            continue;
                        

                    }

                        
                }
                catch (IndexOutOfRangeException e)  
                {
                    throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
                }
                               
            }
            return tauxAffectationChar;
        }
    }
}
