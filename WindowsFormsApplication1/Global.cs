using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class Global
    {
        static public bool Modification;
        static public bool Recherche;
        static public bool Supprime;
        static public int ID;
        static public int Choix;
        static public int Activite;


        
        public string Interro(int Inter)
        {
            string message = ""; 
            switch(Inter)
            {
                case 1:
                    message = "Souhaitez-vous vraiment fermer cette page? Toutes modifications non enregistrées seront perdues.";
                    break;
                case 2:
                    message = "Souhaitez vous enregistrer les modifications ?";
                    break;
                case 3:
                    message = "Souhaitez-vous vraiment fermer cette page?" ;
                    break;
            }
            return message;
        }
    }


}
