using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using Modele;
using System.Diagnostics;
using MySql.Data.MySqlClient.Memcached;

namespace Controlleur
{
    public class Factory
    {
 static MySqlConnection conn = null;

        public static void initialiserConn()
        {
            string pwd = "";
            string chaine = "Server=localhost;Database=maisoninformatique;port=3306 ; User Id=root;password = " + pwd;
            conn = new MySqlConnection(chaine);
        }


        #region Client

        public static ArrayList getAllClients() {
        
            ArrayList clients = new ArrayList();

            Modele.Client client = null;

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select * from client";
            MySqlDataReader ClientReader = commande.ExecuteReader();
            while (ClientReader.Read())
            {
                client = new Modele.Client();

                client.Matricule = ClientReader["idClient"].ToString();
                client.Nom = ClientReader["nom"].ToString();
                client.Genre = ClientReader["genre"].ToString();
                client.Telephone = ClientReader["tel"].ToString();
                client.Email = ClientReader["email"].ToString();
                client.Nationalite = ClientReader["nationalite"].ToString();
                clients.Add(client);
            }
            ClientReader.Close();
            conn.Close();
            return clients;
        }
        //   public static Clients getClientByID() { return null; }

        public static Modele.Client addClients(Modele.Client cl1) 
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO client(idClient,nom,genre,tel,email,nationalite) VALUES(@id, @no, @ge,@tel, @email, @not)";

                command.Parameters.Add(new MySqlParameter("@id", cl1.Matricule));
                command.Parameters.Add(new MySqlParameter("@no", cl1.Nom));
                command.Parameters.Add(new MySqlParameter("@ge", cl1.Genre));
                command.Parameters.Add(new MySqlParameter("@tel", cl1.Telephone));
                command.Parameters.Add(new MySqlParameter("@email", cl1.Email));
                command.Parameters.Add(new MySqlParameter("@not", cl1.Nationalite));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cl1;
        }

        public static Modele.Client getIdByClient(string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            Modele.Client cl1 = null;

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * WHERE idClient = @id";

                command.Parameters.Add(new MySqlParameter("@id", idClient));

                MySqlDataReader ClientReader = command.ExecuteReader();
                if (ClientReader.Read())
                {
                    cl1 = new Modele.Client();

                    cl1.Matricule = ClientReader["idClient"].ToString();
                    cl1.Nom = ClientReader["nom"].ToString();
                    cl1.Genre = ClientReader["genre"].ToString();
                    cl1.Telephone = ClientReader["tel"].ToString();
                    cl1.Email = ClientReader["email"].ToString();
                    cl1.Nationalite = ClientReader["nationalite"].ToString();
                
                }
                ClientReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cl1;
        }

        #endregion

        #region Technitien
        #endregion

        #region Materiel
        #endregion
    }
}
