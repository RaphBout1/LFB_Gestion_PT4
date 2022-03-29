using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LFB_gestion.Formulaires.Form_Client;

namespace TEST_LFB_gestion
{
    [TestClass]
    public class Clients_Test
    {
        SqlConnection connexion = LFB_gestion.Outils.Connexion();
        [TestMethod]
        public void TestCreationClients()
        {
            LFB_gestion.Classes.ClientMéthodes.creationDuClient("nom", "prénom", "mail", "adresse", "code postal", "ville", "telephone");
            string query = "select * from client " +
                "where nom='nom' and prenom='prenom' and mail='mail' and adresse='adresse' and codePostal='code postal' and ville='ville' and telephone='telephone'";
            SqlCommand cmd = new SqlCommand();
        }
    }
}