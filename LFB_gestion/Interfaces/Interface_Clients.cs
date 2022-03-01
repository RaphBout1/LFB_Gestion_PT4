using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Clients : Interface_Abstraite
    {
        List<Entités.Entite_Client> clients;
        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        private int admin = 0;
        public Interface_Clients()
        {
            nomModuleLabel.Text = "Module Clients";
            clients = new List<Entités.Entite_Client>();
            affichageClients();
            InitializeComponent();
        }

        private void affichageClients()
        {
            // Pour tous les clients présents dans la liste, les afficher
            if (this.clients != null)
            {
                int y = 0;
                foreach (Entités.Entite_Client client in this.clients)
                {
                    if (client == clients[0])
                    {
                        client.Location = new System.Drawing.Point(0, 0);
                    }
                    else
                    {
                        clients[y].Location = new Point(0, y * (client.Height + 30));
                    }
                    this.clientsPanel.Controls.Add(client);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de client dans la base");
            }
            connexion.Close();
        }

        private List<Entités.Entite_Client> initialisationToutLesClients()
        {
            // Remplir la liste this.clients
            // Connexion bdd
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("SELECT * from client", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            List < Entités.Entite_Client > listeClients = new List<Entités.Entite_Client> ();
            while (rd.Read())
            {
                String nom = rd["nom"].ToString();
                String prenom = rd["prenom"].ToString();
                String email = rd["mail"].ToString();
                Entités.Entite_Client client = new Entités.Entite_Client(nom, prenom, email);
                listeClients.Add(client);
            }
            connexion.Close();
            return listeClients;
        }

        // Système de recherche
        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            // On récupère le texte dans le label rechercheLabel
            String txt = rechercheTextBox.Text;
            // Connexion bdd
            SqlCommand idQuery = new SqlCommand("SELECT * from client where nom like '" + txt + "%" + "'", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            while (rd.Read())
            {
                String nom = rd["nom"].ToString();
                String prenom = rd["prenom"].ToString();
                String email = rd["mail"].ToString();
                Entités.Entite_Client client = new Entités.Entite_Client(nom, prenom, email);
                this.clients.Add(client);
            }
            affichageClients();
            this.clients.Clear();
        }


        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Formulaires.Form_Client formClient = new Formulaires.Form_Client();
            formClient.Show();
        }

    }
}
