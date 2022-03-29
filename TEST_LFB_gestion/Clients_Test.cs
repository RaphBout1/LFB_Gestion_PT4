using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LFB_gestion.Formulaires.Form_Client;

namespace TEST_LFB_gestion
{
    [TestClass]
    public class Clients_Test
    {
        [TestMethod]
        public void TestCreationClients()
        {
            LFB_gestion.Outils.crypter("hey");
        }
    }
}