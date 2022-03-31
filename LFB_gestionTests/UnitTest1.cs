using LFB_gestion.Classes;
using NUnit.Framework;
using System.Data.Common;
using System.Data.SqlClient;

namespace LFB_gestionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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

            [Test]
            public void testAjoutClient()
            {
            SqlConnection connexion = LFB_gestion.Outils.Connexion();
            connexion.Open();
                ClientMéthodes.creationDuClient("nom", "prénom", "mail", "adresse", "code postal", "ville", "telephone");
                string query = "select * from client " +
                    "where nom='nom' and prenom='prenom' and mail='mail' and adresse='adresse' and codePostal='code postal' and ville='ville' and telephone='telephone'";
                SqlCommand cmd = new SqlCommand(query, connexion);
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
        }
    }
}