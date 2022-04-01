using System;
using LFB_gestion.Entités;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LFB_gestion.Classes;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Entretien : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();
        public Interface_Entretien()
        {
            dataBase.selectEntretien();
            // On redéfini le nom du module
            nomModuleLabel.Text = "Entretiens";
            InitializeComponent();
            afficherEntretien();
        }

        #region Événements
        /// <summary>
        /// Appelle la fonction qui affichera tous les utilisateurs
        /// </summary>
        public void afficherEntretien()
        {
            reader("");
        }



        /// <summary>
        /// Méthode permettant de construire une liste d'entretien présents dans la base en fonction d'une chaine de caractères. Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            reader(rechercheTextBox.Text);
            connexion.Close();
        }

        /// <summary>
        /// Ouvre un formulaire pour créer un nouveau incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien(null);
            formEntretien.ShowDialog();

        }
        #endregion

        #region Fonctions

        /// <summary>
        /// Permet de créer une liste d'Entités_Entretien selon un identifiant recherché et appelle la fonction qui les affiche
        /// </summary>
        /// <param name="recherche"></param>
        public void reader(string recherche)
        {
            List<Entite_Entretien> listeEntretien = new List<Entite_Entretien>();
            foreach (Entite_Entretien entretien in dataBase.entretiens)
            {
                if (entretien.description.Contains(recherche) || recherche == null || recherche == "")
                {
                    int id = entretien.id;
                    string date = entretien.date;
                    string description = entretien.description;
                    string user = entretien.user;
                    int emplacement = entretien.emplacement;
                    Entite_Entretien entre = new Entite_Entretien(id, date, description, emplacement, user);
                    listeEntretien.Add(entre);
                }
            }
            affichageEntretien(listeEntretien);
        }

        /// <summary>
        /// Méthode affichant la liste de entretient qu'elle reçoit en paramètres.
        /// </summary>
        /// <param name="entretiens"></param>
        private void affichageEntretien(List<Entités.Entite_Entretien> entretiens)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (entretiens != null)
            {
                int y = 0;
                foreach (Entités.Entite_Entretien entretien in entretiens)
                {
                    if (entretien == entretiens[0])
                    {
                        entretien.Location = new System.Drawing.Point(0, 0);
                    }
                    else
                    {
                        entretiens[y].Location = new Point(0, y * (entretien.Height + 30));
                    }
                    entretien.Width = clientsPanel.Width -15;
                    clientsPanel.Controls.Add(entretien);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas d'entretien dans la base");
            }
            connexion.Close();
        }






        #endregion

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataBase.selectEntretien();
            afficherEntretien();
        }
    }
}
