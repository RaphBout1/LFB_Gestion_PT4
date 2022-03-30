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

            // On vérifie si le chiffrage fonctionne sur une chaine complexe
            string sComplexe = "aMoR78_@&é'==SSi, P";
            sCrypte = LFB_gestion.Outils.chiffrer(sComplexe);
            Assert.AreNotEqual(sComplexe, sCrypte);


        }

        [TestMethod]
        public void testsMailEstValide()
        {
            // Sur adresse mail valide
            // On créer plusieurs adresses mails valide
            string valide = "tonyStark@gmail.com";
            string valideAvecTiret = "tony-stark@gmail.com";
            string valideAvecPoint = "tony-stark@gmail.com";
            string valideAvecChiffre = "tony2-stark@gmail.com";
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valide));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecTiret));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecChiffre));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecPoint));

            // sur adresse mail invalide
            string nonValideAvecEspace = "tony stark@gmail.com";
            string nonValideSansArobase = "tonystarkgmail.com";
            string nonValideSansDomaine = "tonystark@gmail";
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecEspace));
           // Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecCaractereSpecial));
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideSansArobase));
           // Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecTiretApresArobase));
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideSansDomaine));


        }

        [TestMethod]
        public void trouverClient()
        {
            // On créé un client dans la base
            string nom = "bob";
            string prenom = "dupont";
            string mail = "bob.dupont@laposte.net";
            int id = 0;
            SqlConnection conn = LFB_gestion.Outils.Connexion();
            string query = "select max (id) from client";
            SqlCommand command = new SqlCommand(query, conn);
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.IsTrue(false);
            }
                query = "insert into client values (@id, @nom, @prenom, @mail)";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.ExecuteNonQuery();

            // Une fois le client créé on teste la méthode trouverClient
            Assert.AreEqual(LFB_gestion.Outils.trouverClient(id).nom, "nom");
        }
    }
}