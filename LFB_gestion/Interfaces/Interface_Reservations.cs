using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Reservations : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();

        public Interface_Reservations()
        {
            nomModuleLabel.Text = "Réservations";
            placeHolder();
            afficherReservations();
            InitializeComponent();
        }
        #region Événements

        /// <summary>
        /// Affiche tout les incidents
        /// </summary>
        private void afficherReservations()
        {
            reader("");
        }
        /// <summary>
        /// bouton pour créer une nouvelle réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formResa = new Formulaires.Form_Reservation(false, null);
            formResa.ShowDialog();
        }

        /// <summary>
        /// Permet de ne pas avoir le focus sur la textbox de recherche dès l'ouverture de l'onglet réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Reservations_Load(object sender, EventArgs e)
        {
            nomModuleLabel.Select();
            rechercheTextBox.LostFocus += rechercheTextBox_LostFocus;
            rechercheTextBox.GotFocus += rechercheTextBox_GotFocus;
        }

        /// <summary>
        /// Passer en mode écriture dans la textBox et non placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_GotFocus(object sender, EventArgs e)
        {
            rechercheTextBox.ForeColor = Color.Black;
            rechercheTextBox.Text = "";
        }

        /// <summary>
        /// revenir en mode placeholder si la textbox est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_LostFocus(object sender, EventArgs e)
        {
            if (rechercheTextBox.Text == "")
            {
                placeHolder();
            }
        }

        /// <summary>
        /// rechercher les réservations avec le prénom et nom tapés dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            clientsPanel.Controls.Clear();
            connexion.Open();
            reader(rechercheTextBox.Text);
            connexion.Close();
        }

        /// <summary>
        /// Permet de valider la recherche en appuyant sur "entrer" au lieu de cliquer sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rechercheBouton_Click(sender, e);
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// placeholder prénom nom pour la recherche de réservations
        /// </summary>
        private void placeHolder()
        {
            rechercheTextBox.ForeColor = Color.Gray;
            rechercheTextBox.Text = "prénom nom";
        }


        /// <summary>
        /// appelle une fonction qui va afficher des réservations selon une requête précisée
        /// </summary>
        /// <param name="cmd">la requête pour chercher des réservations</param>
        private void reader(string recherche)
        {
            List<Entite_Reservation> listeréservations = new List<Entite_Reservation>();
            foreach (Entite_Reservation reservation in dataBase.reservations)
            {
                if (Outils.afficherClient(reservation.idClient).ToString().Contains(recherche) || recherche == null || recherche == "")
                {
                    int id = reservation.id;
                    int idEmplacement = reservation.emplacement;
                    int idClient = reservation.idClient;
                    DateTime début = reservation.début;
                    DateTime fin = reservation.fin;
                    Entite_Reservation resa = new Entite_Reservation(id, idEmplacement, idClient, début, fin);
                    listeréservations.Add(resa);
                }
            }
          
            affichageReservations(listeréservations);
        }

        /// <summary>
        /// gère l'affichage d'une liste de réservations avec l'entité réservation
        /// </summary>
        /// <param name="réservations">une liste de réservations</param>
        private void affichageReservations(List<Entite_Reservation> réservations)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (réservations != null)
            {
                int y = 0;
                foreach (Entite_Reservation réservation in réservations)
                {
                    if (réservation == réservations[0])
                    {
                        réservation.Location = new Point(0, 0);
                    }
                    else
                    {
                        réservations[y].Location = new Point(0, y * (réservation.Height + 30));
                    }
                    réservation.Width = clientsPanel.Width;
                    clientsPanel.Controls.Add(réservation);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de réservations dans la base");
            }
        }
        #endregion

        private void refreshButton_Click(object sender, EventArgs e)
        {
            afficherReservations();
        }
    }
}
