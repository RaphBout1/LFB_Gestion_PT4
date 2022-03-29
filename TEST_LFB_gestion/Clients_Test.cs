using LFB_gestion.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using System.Data.SqlClient;

namespace TEST_LFB_gestion
{
    [TestClass]
    public class Clients_Test
    {
        SqlConnection connexion = LFB_gestion.Outils.Connexion();

        [TestMethod]
        public void testAjoutClient()
        {
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