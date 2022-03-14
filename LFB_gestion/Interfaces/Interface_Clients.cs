using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Clients : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();

        public Interface_Clients()
        {
            // On redéfini le nom du module
            nomModuleLabel.Text = "Clients";
            // On initialise les clients présents dans la base et on les affiche
            defaultClients();
            InitializeComponent();
        }




        #region Événements
        /// <summary>
        /// Méthode permettant de construire une liste de clients présents dans la base en fonction d'une chaine de caractères.
        /// Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheBouton_Click(object sender, EventArgs e)
        {

            connexion.Open();
            // On récupère le texte dans le label rechercheLabel
            String txt = rechercheTextBox.Text;
            // Connexion bdd
            SqlCommand idQuery = new SqlCommand("SELECT * from client where nom like '" + txt + "%" + "'", connexion);
            reader(idQuery);
            connexion.Close();
        }

        /// <summary>
        /// Lance le formulaire pour créer un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click_1(object sender, EventArgs e)
        {
            Form formClient = new Formulaires.Form_Client();
            formClient.ShowDialog();
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Méthode affichant la liste de clients qu'elle reçoit en paramètres.
        /// </summary>
        /// <param name="clients"></param>
        private void affichageClients(List<Entités.Entite_Client> clients)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (clients != null)
            {
                int y = 0;
                foreach (Entités.Entite_Client client in clients)
                {
                    if (client == clients[0])
                    {
                        client.Location = new System.Drawing.Point(0, 0);
                    }
                    else
                    {
                        clients[y].Location = new Point(0, y * (client.Height + 30));
                    }
                    client.Width = this.clientsPanel.Width;
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

        /// <summary>
        /// Méthode permettant de créer une liste de tous les clients présents dans la base
        /// Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
        /// </summary>
        private void defaultClients()
        {
            // Remplir la liste this.clients
            // Connexion bdd
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("SELECT * from client", connexion);
            reader(idQuery);
            connexion.Close();
        }

        /// <summary>
        /// Méthode permettant de créer une liste de client selon une requète
        /// </summary>
        /// <param name="idQuery"></param>
        private void reader(SqlCommand idQuery)
        {
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            List<Entite_Client> listeClients = new List<Entite_Client>();
            while (rd.Read())
            {
                int id = rd.GetInt32(0);
                string nom = rd["nom"].ToString();
                string prenom = rd["prenom"].ToString();
                string email = rd["mail"].ToString();
                Entite_Client client = new Entite_Client(id, nom, prenom, email);
                listeClients.Add(client);
            }
            affichageClients(listeClients);
        }
        #endregion











    }

}