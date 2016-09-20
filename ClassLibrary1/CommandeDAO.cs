using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommandeDAO
    {
        public List<Commande> ListComNom(string Nom)
        {
            SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            List<Commande> resultat = new List<Commande>();
            SqlCommand CmdSearch = new SqlCommand("select * from commercial.Commande join commercial.Clients on commercial.Commande.ID_Client = commercial.Clients.ID_Client where commercial.Clients.Nom_Particulier = @Nom", connect);
            CmdSearch.Parameters.AddWithValue("@Nom", Nom);
            SqlDataReader lecture = CmdSearch.ExecuteReader();
            while (lecture.Read())
            {
                Commande com = new Commande();
                com.Numero_Commande = Convert.ToInt32(lecture["ID_Commande"]);
                com.Date_de_Commande = Convert.ToDateTime(lecture["Date_Reglement"]);
                com.Total_HT = Convert.ToDecimal(lecture["Montant_HT"]);
                com.Numero_Client = Convert.ToInt32(lecture["ID_Client"]);
                resultat.Add(com);
            }
            connect.Close();
            return resultat;
        }
        public List<Commande> ListComEnseigne(string Enseigne)
        {
            SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            List<Commande> resultat = new List<Commande>();
            SqlCommand CmdSearch = new SqlCommand("select * from commercial.Commande join commercial.Clients on commercial.Commande.ID_Client = commercial.Clients.ID_Client where commercial.Clients.Nom_Enseigne = @Enseigne", connect);
            CmdSearch.Parameters.AddWithValue("@Enseigne", Enseigne);
            SqlDataReader lecture = CmdSearch.ExecuteReader();
            while (lecture.Read())
            {
                Commande com = new Commande();
                com.Numero_Commande = Convert.ToInt32(lecture["ID_Commande"]);
                com.Date_de_Commande = Convert.ToDateTime(lecture["Date_Reglement"]);
                com.Total_HT = Convert.ToDecimal(lecture["Montant_HT"]);
                com.Numero_Client = Convert.ToInt32(lecture["ID_Client"]);
                resultat.Add(com);
            }
            connect.Close();
            return resultat;
            
        }
        public List<Commande> ListComNum(int NumClient)
        {
            SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            List<Commande> resultat = new List<Commande>();
            SqlCommand CmdSearch = new SqlCommand("select * from commercial.Commande join commercial.Clients on commercial.Commande.ID_Client = commercial.Clients.ID_Client where commercial.Clients.ID_Client = @Numero_client", connect);
            CmdSearch.Parameters.AddWithValue("@Numero_client", NumClient);
            SqlDataReader lecture = CmdSearch.ExecuteReader();
            while (lecture.Read())
            {
                Commande com = new Commande();
                com.Numero_Commande = Convert.ToInt32(lecture["ID_Commande"]);
                com.Date_de_Commande = Convert.ToDateTime(lecture["Date_Reglement"]);
                com.Total_HT = Convert.ToDecimal(lecture["Montant_HT"]);
                com.Numero_Client = Convert.ToInt32(lecture["ID_Client"]);
                resultat.Add(com); 
            }
            connect.Close();
            return resultat;
        }


    }
}
