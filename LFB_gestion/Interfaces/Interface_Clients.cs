using LFB_gestion.Classes;
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
            dataBase.refreshDataBase();
            // On initialise les clients présents dans la base et on les affiche
            InitializeComponent();
            afficherClients();


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
            reader(rechercheTextBox.Text);
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

        /// <summary>
        /// Appelle la fonction qui affichera tous les clients
        /// </summary>
        private void afficherClients()
        {
            reader("");
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
                    client.Width = clientsPanel.Width;
                    clientsPanel.Controls.Add(client);
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
        /// Méthode permettant de créer une liste de client selon une requète
        /// </summary>
        /// <param name="recherche"></param>
        private void reader(string recherche)
        {

            List<Entite_Client> listeClients = new List<Entite_Client>();
            foreach (Entite_Client client in dataBase.clients)
            {
                if (client.nom.Contains(recherche) || client.prenom.Contains(recherche) || recherche == null || recherche == "")
                {
                    int id = client.id; string adresse = client.adresse;
                    string mail = client.mail;
                    string codePostal = client.codePostal;
                    string nom = client.nom;
                    string prenom = client.prenom;
                    string tel = client.tel;
                    string ville = client.ville;
                    Entite_Client c = new Entite_Client(id, nom, prenom, mail, adresse, codePostal, ville, tel);
                    listeClients.Add(c);

                }
                
            }
            affichageClients(listeClients);
        }
        #endregion











    }

}