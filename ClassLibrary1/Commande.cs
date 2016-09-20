using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Commande
    {
        public int Numero_Commande { get; set; }//0
        public decimal Total { get; set; }//1
        public DateTime DateFacturation { get; set; }//2
        public string ModePaiement { get; set; }//3
        public decimal Total_HT { get; set; }//4
        public System.DateTime DateReglement { get; set; }//5
        public decimal Regle { get; set; }//6
        public int TVA { get; set; }//7
        public DateTime Date_de_Commande { get; set; }//8
        public int Numero_Client { get; set; }//9

    }
}
