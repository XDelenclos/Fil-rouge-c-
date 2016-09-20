using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public int Numero_client { get; set; }//0
        public string Nom { get; set; }//1
        public string Prenom { get; set; }//2
        public string Enseigne { get; set; }//3
        public Nullable<double> Siret { get; set; }//4
        public string AdrFacturation { get; set; }//5
        public string CPFacturation { get; set; }//6
        public string VilleFact { get; set; }//7
        public string AdrLivraison { get; set; }//8
        public string CPLivraison { get; set; }//9
        public string VilleLiv { get; set; }//10
        public string Téléphone { get; set; }//11
        public string Fax { get; set; }//12
        public string email { get; set; }//13
        public Nullable<int> Remise { get; set; }//14
        public Nullable<int> Coefficient { get; set; }//15
        public Nullable<bool> Statut { get; set; }//16
        public string CompAdressFact { get; set; }//17
        public string CompAdressLiv { get; set; }//18
        public string TelPortable { get; set; }//19
        public bool Civilite { get; set; }//20
        public string Activite { get; set; }//21

    }
}
