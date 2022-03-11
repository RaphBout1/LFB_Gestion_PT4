using LFB_gestion.Classes;
using LFB_gestion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Reservation : UserControl
    {
        private int id;

        private int idClient;

        private int emplacement;

        private DateTime début;

        private DateTime fin;


        public Entite_Reservation(int id, int idClient, int emplacement, DateTime début, DateTime fin)
        {
            this.id = id;
            this.idClient = idClient;
            this.emplacement = emplacement;
            this.début = début;
            this.fin = fin;
            InitializeComponent();
            string nomClient = "Error";
            foreach (Client client in Interface_Accueil.clients)
            {
                if (client.id == this.idClient)
                    nomClient = client.prenom + " " + client.nom;
            }
            nomClientLabel.Text = nomClient;
            emplacementLabel.Text = this.emplacement.ToString();
            debutLabel.Text = this.début.ToString("dd/MM/yyyy");
            finLabel.Text = this.fin.ToString("dd/MM/yyyy");
        }

        public int getid()
        {
            return id;
        }
        public int getIdEmplacement()
        {
            return emplacement;
        }

        public int getIdClient()
        {
            return idClient;
        }

        public DateTime getDébut()
        {
            return début;
        }

        public  DateTime getfin()
        {
            return fin;
        }
    }
}
