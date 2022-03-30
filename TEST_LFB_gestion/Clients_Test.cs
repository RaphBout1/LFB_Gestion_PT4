using LFB_gestion.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace TEST_LFB_gestion
{
    [TestClass]
    public class Clients_Test
    {
        private static SqlConnection connexion = LFB_gestion.Outils.Connexion();

        /// <summary>
        /// Création d'un nouveau client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        public static void creationDuClient(string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel)
        {
            connexion.Open();
            int id = 0;
            string query = "select max (id) from client";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                id++;
                reader.Close();
            }
            query = "insert into client values (@id, @nom, @prenom, @mail, @adresse, @codePostal, @ville, @tel)";
            command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@adresse", adresse);
            command.Parameters.AddWithValue("@codePostal", codePostal);
            command.Parameters.AddWithValue("@ville", ville);
            command.Parameters.AddWithValue("@tel", tel);
            command.ExecuteNonQuery();
            connexion.Close();
        }

        [TestMethod]
        public void testAjoutClient()
        {
            bool vrai = true;
            bool faux = false;
            creationDuClient("nomt", "prénomt", "mail@qsd.comt", "adresset", "code postalt", "villet", "telephonet");
            connexion.Open();
            string query = "select * from client " +
                "where nom='nomt' and prenom='prénomt' and mail='mail@qsd.comt' and adresse='adresset' and codePostal='code postalt' and ville='villet' and telephone='telephonet'";
            SqlCommand cmd = new SqlCommand(query, connexion);
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Assert.IsTrue(vrai);
            }
            else
            {
                Assert.IsTrue(faux);
            }
        }
    }
}