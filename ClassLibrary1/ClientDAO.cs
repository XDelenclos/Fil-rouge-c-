using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
            string BoutErreur = "";
            List<Regex> test = new List<Regex>();
            test.Add(new Regex(@"^(.+)@(.+)\.(.+)$")); //@"^([\w\d\-\.]+)@{1}(([\w\d\-]{1,67})|([\w\d\-]+\.[\w\d\-]{1,67}))\.(([a-zA-Z\d]{2,4})(\.[a-zA-Z\d]{2})?)$");
            test.Add(new Regex(@"^([\w\d\-\.]+){2,50}$"));
            test.Add(new Regex(@"^(([\w\d\-]{1,67})|([\w\d\-]+\.[\w\d\-]{1,67})){2,67}$"));
            test.Add(new Regex(@"^(([a-zA-Z]{2,4})(\.[a-zA-Z]{2})?)$"));
            Match r = test[0].Match(email);
           
            if (r.Success)
            {
                int i = 1;
                while (BoutErreur=="" & i<=3)
                {
                    if (test[i].Match(r.Groups[i].Value).Success)
                    { i++; }
                    else
                    {BoutErreur += r.Groups[i].Value.ToString(); }
                }
            }
            else
            {
                BoutErreur = email;
            }
            return BoutErreur;
        }

        public string Interrogation(int Choix)
        {
            string Statut = "";
            switch (Choix)
            {
                case 1:
                    Statut = " and Statut = 'Inactif'   ";
                    break;
                case 2:
                    Statut = " and Statut = 'Actif'     ";
                    break;
                case 3:
                    Statut = "";
                    break;
            }
            return Statut;
        }

        public string Activite(int Choix)
        {
            string Statut = "";
            switch (Choix)
            {
                case 0:
                    Statut = "Inactif";
                    break;
                case 1:
                    Statut = "Actif";
                    break;
            }
            return Statut;
        }
        public List<Client> ListClient(string Nom)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                List<Client> resultat = new List<Client>();
                SqlCommand requete = new SqlCommand("select * from  commercial.Clients where Nom_Particulier like  @Nom", connect);
                Nom = "%" + Nom + "%";
                requete.Parameters.AddWithValue("@Nom", Nom);
                SqlDataReader lecture = requete.ExecuteReader();
                while (lecture.Read())
                {
                    Client c = new Client();
                    c.Numero_client = Convert.ToInt32(lecture["ID_Client"]);
                    c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                    c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                    c.Enseigne = Convert.ToString(lecture["Nom_Enseigne"]);
                    c.VilleFact = Convert.ToString(lecture["Ville_Livraison"]);
                    c.Téléphone = (String)lecture["No_Telephone_Client"];
                    c.email = Convert.ToString(lecture["Mail_Client"]);
                    resultat.Add(c);
                }
                lecture.Close();
                connect.Close();
                return resultat;
            }
            catch
            {
                throw new Exception("Problème lors du chargement de la liste client !");
            }
        }

        public List<Client> ListClientEnseigne(string Enseigne)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                List<Client> resultat = new List<Client>();
                SqlCommand requete = new SqlCommand("select * from  commercial.Clients where Nom_Enseigne like @Enseigne", connect);
                Enseigne = "%" + Enseigne + "%";
                requete.Parameters.AddWithValue("@Enseigne", Enseigne);
                SqlDataReader lecture = requete.ExecuteReader();
                while (lecture.Read())
                {
                    Client c = new Client();
                    c.Numero_client = Convert.ToInt32(lecture["ID_Client"]);
                    c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                    c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                    c.Enseigne = Convert.ToString(lecture["Nom_Enseigne"]);
                    c.VilleFact = Convert.ToString(lecture["Ville_Livraison"]);
                    c.Téléphone = (String)lecture["No_Telephone_Client"];
                    c.email = Convert.ToString(lecture["Mail_Client"]);
                    resultat.Add(c);
                }
                lecture.Close();
                connect.Close();
                return resultat;
            }
            catch
            {
                throw new Exception("Problème lors du chargement de la liste client !");
            }
        }

        public List<Client> ListClientNum(int Num)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                List<Client> resultat = new List<Client>();
                SqlCommand requete = new SqlCommand("select * from  commercial.Clients where ID_Client= @Num", connect);
                requete.Parameters.AddWithValue("@Num", Num);
                SqlDataReader lecture = requete.ExecuteReader();
                while (lecture.Read())
                {
                    Client c = new Client();
                    c.Numero_client = Convert.ToInt32(lecture["ID_Client"]);
                    c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                    c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                    c.Enseigne = Convert.ToString(lecture["Nom_Enseigne"]);
                    c.VilleFact = Convert.ToString(lecture["Ville_Livraison"]);
                    c.Téléphone = (String)lecture["No_Telephone_Client"];
                    c.email = Convert.ToString(lecture["Mail_Client"]);
                    c.Activite = lecture["Statut"].ToString();
                    resultat.Add(c);
                }
                lecture.Close();
                connect.Close();
                return resultat;
            }
            catch
            {
                throw new Exception("Problème lors du chargement de la liste client !");
            }
        }

        public Client find(int id, int Choix)
        {
            SqlConnection connect = null;
            try
            {
                connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                //string tmp = Interrogation(Choix);
                SqlCommand requete = new SqlCommand("select * from  commercial.Clients where ID_Client= @Numero_client" + Interrogation(Choix), connect);
                requete.Parameters.AddWithValue("@Numero_client", id);
                SqlDataReader lecture = requete.ExecuteReader();
                Client c = new Client();
                while (lecture.Read())
                {
                    c.Numero_client = id;
                    c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                    c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                    c.VilleFact = Convert.ToString(lecture["Ville_Facturation"]);
                    c.Téléphone = (String)lecture["No_Telephone_Client"];
                    if (lecture["Nom_Enseigne"] is DBNull)
                    { c.Enseigne = ""; }
                    else
                    { c.Enseigne = Convert.ToString(lecture["Nom_Enseigne"]); }
                    if (lecture["Mail_Client"] is DBNull)
                    { c.email = ""; }
                    else
                    { c.email = Convert.ToString(lecture["Mail_Client"]); }
                    if (lecture["Adresse_Facturation"] is DBNull)
                    { c.AdrFacturation = ""; }
                    else
                    { c.AdrFacturation = (string)lecture["Adresse_Facturation"]; }
                    if (lecture["Adresse_Livraison"] is DBNull)
                    { c.AdrLivraison = ""; }
                    else
                    { c.AdrLivraison = (string)lecture["Adresse_Livraison"]; }
                    if (lecture["CompAdresLiv"] is DBNull)
                    { c.CompAdressLiv = ""; }
                    else
                    { c.CompAdressLiv = (string)lecture["CompAdresLiv"]; }
                    if (lecture["Code_Postal_Facturation"] is DBNull)
                    { c.CPFacturation = ""; }
                    else
                    { c.CPFacturation = (string)lecture["Code_Postal_Facturation"]; }
                    if (lecture["Code_Postal_Livraison"] is DBNull)
                    { c.CPLivraison = ""; }
                    else
                    { c.CPLivraison = (string)lecture["Code_Postal_Livraison"]; }
                    if (lecture["No_Fax_Client"] is DBNull)
                    { c.Fax = ""; }
                    else
                    { c.Fax = (string)(lecture["No_Fax_Client"]); }
                    if (lecture["No_Siret"] is DBNull)
                    { c.Siret = 0; }
                    else
                    { c.Siret = Convert.ToInt32(lecture["No_Siret"].ToString()); }
                    if (lecture["Particulier_Professionnel"] is DBNull)
                    { c.Statut = false; }
                    else
                    { c.Statut = (bool)lecture["Particulier_Professionnel"]; }
                    if (lecture["No_Telephone_Client"] is DBNull)
                    { c.Téléphone = ""; }
                    else
                    { c.Téléphone = (string)lecture["No_Telephone_Client"]; }
                    if (lecture["Ville_Livraison"] is DBNull)
                    { c.VilleLiv = ""; }
                    else
                    { c.VilleLiv = (string)lecture["Ville_Livraison"]; }
                    if (lecture["CompAdresFact"] is DBNull)
                    { c.VilleLiv = ""; }
                    else
                    { c.CompAdressFact = (string)lecture["CompAdresFact"]; }
                    if (lecture["Tel_Portable"] is DBNull)
                    { c.TelPortable = ""; }
                    else
                    { c.TelPortable = (string)lecture["Tel_Portable"]; }
                    if (lecture["Civilite"] is DBNull)
                    { c.Civilite = false; }
                    else
                    { c.Civilite = (bool)lecture["Civilite"]; }
                    c.Activite = Convert.ToString(lecture["Statut"]);
                }
                connect.Close();
                return c;
            }
            catch (SqlException ex)
            {
                throw new Exception("Problème lors du chargement de la liste client !");
            }
        }

        public void insert(Client cli)
        {
            //try
            //{
            SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            SqlCommand RequeteId = new SqlCommand("select max(ID_Client) from  commercial.Clients", connect);
            int ID = (int)RequeteId.ExecuteScalar();
            cli.Numero_client = ID + 1;
            string Etat = "Actif";
            SqlCommand CmdInsert = new SqlCommand("insert into commercial.Clients (Particulier_Professionnel, Nom_Particulier, Prenom_Particulier, Nom_Enseigne, No_Siret, Adresse_Facturation, Code_Postal_Facturation, Ville_Facturation, Adresse_Livraison, Code_Postal_Livraison, Ville_Livraison, No_Telephone_Client, No_Fax_Client, Mail_Client, Coefficient, CompAdresLiv, CompAdresFact, Tel_Portable, Civilite, Statut) values (@Statut, @nom, @prenom, @Enseigne, @Siret, @AdressFact, @CPFact, @ville, @AdressLiv, @CPLiv, @VilleLiv, @Tel, @Fax, @Mail, @Coefficient,@CompAdressLiv, @CompAdressFact, @TelPortable, @Civilite, @Activite)", connect);

            CmdInsert.Parameters.AddWithValue("@ID", cli.Numero_client);
            CmdInsert.Parameters.AddWithValue("@nom", cli.Nom);
            CmdInsert.Parameters.AddWithValue("@prenom", cli.Prenom);
            CmdInsert.Parameters.AddWithValue("@ville", cli.VilleFact);
            CmdInsert.Parameters.AddWithValue("@Enseigne", cli.Enseigne);
            if (cli.Siret == null)
            {
                CmdInsert.Parameters.AddWithValue("@Siret", DBNull.Value);

            }
            else
            {
                CmdInsert.Parameters.AddWithValue("@Siret", cli.Siret);

            }
            CmdInsert.Parameters.AddWithValue("@AdressFact", cli.AdrFacturation);
            CmdInsert.Parameters.AddWithValue("@CPFact", cli.CPFacturation);
            CmdInsert.Parameters.AddWithValue("@CompAdressLiv", cli.CompAdressLiv);
            CmdInsert.Parameters.AddWithValue("@AdressLiv", cli.AdrLivraison);
            CmdInsert.Parameters.AddWithValue("@CPLiv", cli.CPLivraison);
            CmdInsert.Parameters.AddWithValue("@CompAdressFact", cli.CompAdressFact);
            CmdInsert.Parameters.AddWithValue("@VilleLiv", cli.VilleLiv);
            CmdInsert.Parameters.AddWithValue("@Tel", cli.Téléphone);
            CmdInsert.Parameters.AddWithValue("@Fax", cli.Fax);
            CmdInsert.Parameters.AddWithValue("@Mail", cli.email);
            // CmdInsert.Parameters.AddWithValue("@Remise", cli.Remise);
            CmdInsert.Parameters.AddWithValue("@Coefficient", cli.Coefficient);
            CmdInsert.Parameters.AddWithValue("@Statut", cli.Statut);
            CmdInsert.Parameters.AddWithValue("@TelPortable", cli.TelPortable);
            CmdInsert.Parameters.AddWithValue("@Civilite", cli.Civilite);
            CmdInsert.Parameters.AddWithValue("@Activite", Etat);
            CmdInsert.ExecuteNonQuery();


            connect.Close();
            //}
            //catch
            //{
            //    throw new Exception("Problème lors de l'ajout de la fiche client !");
            //}
        }

        public void Update(Client cli, int Choix)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                string tmp = Activite(Choix);
                SqlCommand CmdUpdate = new SqlCommand("update commercial.Clients set Nom_Particulier = @nom , Prenom_Particulier =@prenom, Ville_Livraison = @VilleLiv, Nom_Enseigne= @Enseigne, No_Siret =@Siret, Adresse_Facturation= @AdressFact, Code_Postal_Facturation= @CPFact, Ville_Facturation=@VilleFact, Adresse_Livraison = @AdressLiv, Code_Postal_Livraison = @CPLiv, No_Telephone_Client=@Tel, No_Fax_Client=@Fax, Mail_Client=@Mail, Coefficient=@Coefficient, CompAdresLiv=@CompAdressLiv, CompAdresFact=@CompAdressFact, Tel_Portable=@TelPortable, Civilite= @Civilite, Particulier_Professionnel=@Statut, Statut=@Activite where ID_Client = @ID", connect);
                CmdUpdate.Parameters.AddWithValue("@ID", cli.Numero_client);
                CmdUpdate.Parameters.AddWithValue("@nom", cli.Nom);
                CmdUpdate.Parameters.AddWithValue("@prenom", cli.Prenom);
                CmdUpdate.Parameters.AddWithValue("@Enseigne", cli.Enseigne);
                if (cli.Siret == null)
                {
                    CmdUpdate.Parameters.AddWithValue("@Siret", DBNull.Value);
                }
                else
                { CmdUpdate.Parameters.AddWithValue("@Siret", cli.Siret); }

                CmdUpdate.Parameters.AddWithValue("@AdressFact", cli.AdrFacturation);
                CmdUpdate.Parameters.AddWithValue("@CompAdressFact", cli.CompAdressFact);
                CmdUpdate.Parameters.AddWithValue("@CPFact", cli.CPFacturation);
                CmdUpdate.Parameters.AddWithValue("@VilleFact", cli.VilleFact);
                CmdUpdate.Parameters.AddWithValue("@AdressLiv", cli.AdrLivraison);
                CmdUpdate.Parameters.AddWithValue("@CompAdressLiv", cli.CompAdressLiv);
                CmdUpdate.Parameters.AddWithValue("@CPLiv", cli.CPLivraison);
                CmdUpdate.Parameters.AddWithValue("@VilleLiv", cli.VilleLiv);
                CmdUpdate.Parameters.AddWithValue("@Tel", cli.Téléphone);
                CmdUpdate.Parameters.AddWithValue("@Fax", cli.Fax);
                CmdUpdate.Parameters.AddWithValue("@Mail", cli.email);
                //CmdUpdate.Parameters.AddWithValue("@Remise", cli.Remise);
                if (cli.Coefficient == null)
                {
                    CmdUpdate.Parameters.AddWithValue("@Coefficient", DBNull.Value);
                }
                else
                { CmdUpdate.Parameters.AddWithValue("@Coefficient", cli.Coefficient); }

                CmdUpdate.Parameters.AddWithValue("@Statut", cli.Statut);
                CmdUpdate.Parameters.AddWithValue("@TelPortable", cli.TelPortable);
                CmdUpdate.Parameters.AddWithValue("@Civilite", cli.Civilite);
                CmdUpdate.Parameters.AddWithValue("@Activite", tmp);
                CmdUpdate.ExecuteNonQuery();
                connect.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);//"Problème lors de la modification de la fiche client !");
            }
        }

        public void Delete(Client cli)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                SqlCommand CmdDelete = new SqlCommand("DELETE FROM commercial.Clients where ID_Client = @ID", connect);
                CmdDelete.Parameters.AddWithValue("@ID", cli.Numero_client);
                CmdDelete.ExecuteNonQuery();
                connect.Close();
            }
            catch
            { throw new Exception("La suppression classique n'a pas fonctionné, tentative de désactiver le client ..."); }

        }

        public void Delete_Complet(Client cli)
        {
            try
            {
                Delete(cli);
            }
            catch
            {
                string Etat = "Inactif   ";
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();

                SqlCommand CmdUpdate = new SqlCommand("update commercial.Clients set Statut = @Activite where ID_Client = @ID", connect);
                CmdUpdate.Parameters.AddWithValue("@ID", cli.Numero_client);

                CmdUpdate.Parameters.AddWithValue("@Activite", Etat);
                CmdUpdate.ExecuteNonQuery();
                connect.Close();
                Console.WriteLine("OK");
            }

        }
        public Client findnom(string nom, string prenom, int Choix)
        {
            SqlConnection connect = null;
            //try
            //{
            connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from  commercial.Clients where Nom_Particulier like @Nom and Prenom_Particulier like @Prenom", connect);
            prenom = "%" + prenom + "%";
            nom = "%" + nom + "%";
            requete.Parameters.AddWithValue("@Nom", nom);
            requete.Parameters.AddWithValue("@Prenom", prenom);
            SqlDataReader lecture = requete.ExecuteReader();
            Client c = new Client();
            while (lecture.Read())
            {
                c.Numero_client = Convert.ToInt32(lecture["ID_Client"]);
            }
            connect.Close();
            return c;
        }
        public Client findEnseigne(string Enseigne, int Choix)
        {

            SqlConnection connect = null;
            connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from  commercial.Clients where Nom_Enseigne= @Enseigne" + Interrogation(Choix), connect);
            requete.Parameters.AddWithValue("@Enseigne", Enseigne);


            SqlDataReader lecture = requete.ExecuteReader();
            Client c = new Client();
            while (lecture.Read())
            {
                c.Numero_client = Convert.ToInt32(lecture["ID_Client"]);
            }
            connect.Close();
            return c;
        }
    }
}
