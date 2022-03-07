using NUnit.Framework;
using System.Collections.Generic;

namespace LFB_gestionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void connexionAffichageClients()
        {
            // On créé une interface client
            LFB_gestion.Interfaces.Interface_Clients interfaceClients  = new LFB_gestion.Interfaces.Interface_Clients();
            // On créé une liste de clients
            List<LFB_gestion.Entités.Entite_Client> clients = new List<LFB_gestion.Entités.Entite_Client>();

            // On la remplie avec des clients provisoires (non inscrits dans la base)

            //client 1
            LFB_gestion.Entités.Entite_Client client1 = new LFB_gestion.Entités.Entite_Client("Michel", "Dumas", "chefMichel@gmail.com");
            //client 2
            LFB_gestion.Entités.Entite_Client client2 = new LFB_gestion.Entités.Entite_Client("Eric", "Cartman", "eric@gmail.com");
            //ajout des clients dans la liste
            clients.Add(client1);
            clients.Add(client2);


        }
    }
}