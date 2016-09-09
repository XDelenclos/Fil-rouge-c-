using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DAL
{
    public class ClientDAO
    {/// <summary>
     /// Fonction vérifiant la cohérence d'une adresse email    
     /// </summary>
     /// <param name="email">chaine de caractère à vérifer, type e-mail</param>
     /// <returns> renvoie une chaîne de caractère vide si l’adresse est correcte, ou contenant l’erreur détectée</returns>
        public string TestMail(string email)
        {
            Regex test = new Regex(@"^(![\w\d\-\.]+)@{1}(!([\w\d\-]{1,67})|([\w\d\-]+\.[\w\d\-]{1,67}))\.(!([a-zA-Z\d]{2,4})(\.[a-zA-Z\d]{2})?)$");
            if (!test.IsMatch(email))
            {
                test.Replace(email,"a$1");
            }
            else
            {
                Console.WriteLine("pas ok");
            }
            return email;
        }
    }
}
