using LFB_gestion.Interfaces;
using System;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Reservation : UserControl
    {
        public int id;

        public int idClient;

        public int emplacement;

        public DateTime début;

        public DateTime fin;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emplacement"></param>
        /// <param name="idClient"></param>
        /// <param name="début"></param>
        /// <param name="fin"></param>
        public Entite_Reservation(int id, int emplacement, int idClient, DateTime début, DateTime fin)
        {
            this.id = id;
            this.emplacement = emplacement;
            this.idClient = idClient;
            this.début = début;
            this.fin = fin;
            InitializeComponent();

            // Trouver le nom du client avec un id
            string nomClient = "Error";
            foreach (Entite_Client client in Interface_Accueil.clients)
            {
                if (client.id == this.idClient)
                    nomClient = client.prenom + " " + client.nom;
            }

            nomClientLabel.Text = nomClient;
            emplacementLabel.Text = this.emplacement.ToString();
            debutLabel.Text = this.début.ToString("dd/MM/yyyy");
            finLabel.Text = this.fin.ToString("dd/MM/yyyy");
        }
    }
}
