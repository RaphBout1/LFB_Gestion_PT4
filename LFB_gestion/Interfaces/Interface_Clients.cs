﻿using LFB_gestion.Classes;
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

        private SqlConnection connexion = Outils.Connexion();

        public Interface_Clients()
        {
            // On redéfini le nom du module
            nomModuleLabel.Text = "Clients";
            // On initialise les clients présents dans la base et on les affiche
            //defaultClients();
            InitializeComponent();

            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Client> incidents = new List<Entités.Entite_Client>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Client incident = new Entités.Entite_Client("coucou","coucou","coucoumail");
                incidents.Add(incident);
            }
            affichageClients(incidents);

        }

        /*
         * Méthode affichant la liste de clients qu'elle reçoit en paramètres.
         */
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
                    client.Width = this.ClientSize.Width;
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

        /*
         * Méthode permettant de créer une liste de tout les clients présents dans la base
         * Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
         */
        private void defaultClients()
        {
            // Remplir la liste this.clients
            // Connexion bdd
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("SELECT * from client", connexion);
            reader(idQuery);
            connexion.Close();
        }
        

        /*
         * Méthode permettant de construire une liste de clients présents dans la base en fonction 
         * d'une chaine de caractères.
         * 
         * Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
         */
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

        /*
         * Méthode permettant de créer l=une liste de client selon une requète
         * 
         * 
         */
        private void reader(SqlCommand idQuery)
        {
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            List<Entités.Entite_Client> listeClients = new List<Entités.Entite_Client>();
            while (rd.Read())
            {
                String nom = rd["nom"].ToString();
                String prenom = rd["prenom"].ToString();
                String email = rd["mail"].ToString();
                Entités.Entite_Client client = new Entités.Entite_Client(nom, prenom, email);
                listeClients.Add(client);
            }
            affichageClients(listeClients);
        }


        private void ajoutBouton_Click_1(object sender, EventArgs e)
        {

            Form formClient = new Formulaires.Form_Client();

            formClient.ShowDialog();

        }
    }
}
