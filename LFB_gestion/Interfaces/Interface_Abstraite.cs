﻿using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Abstraite : Form
    {
        private Entite_Utilisateur u;

        public Interface_Abstraite()
        {
            InitializeComponent();
            Admin();
            DeftSize();
        }

        #region Événements
        #region Onglets
        /// <summary>
        /// Ouvrir l'onglet accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Interface_Accueil();

            formAccueil.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Ouvrir l'onglet stocks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formStocks = new Interface_Stocks();

            formStocks.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Ouvrir l'onglet statistiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ouvrir l'onglet entretien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entretienToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// ouvrir l'onglet plan intéractif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ouvrir l'onglet réservations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formReservation = new Interface_Reservations();

            formReservation.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Ouvrir l'onglet clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formClients = new Interface_Clients();

            formClients.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Ouvrir l'onglet utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUtilisateur = new Interface_Utilisateurs();

            formUtilisateur.ShowDialog();
            this.Close();
        }
        #endregion

        /// <summary>
        /// Événement appelant une fonction qui replace esthétiquement les éléments selon al taille de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Abstraite_Resize(object sender, EventArgs e)
        {
            DeftSize();
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Rend visible des fonctionnalités si l'utilisateur connecté est un admin
        /// </summary>
        private void Admin()
        {
            if (Entite_Utilisateur.courant != null)
            {
                //si l'utilisateur courant est un admin alors rendre visible les fonctions admin
                if (Entite_Utilisateur.courant.admin == 1)
                {
                    utilisateursToolStripMenuItem.Visible = true;
                    statistiquesToolStripMenuItem.Visible = true;
                }
                //Au contraire les caché
                else
                {
                    utilisateursToolStripMenuItem.Visible = false;
                    statistiquesToolStripMenuItem.Visible = false;
                }
            }
        }

        /// <summary>
        /// Fonction qui définie l'emplacement des éléments en fonction de la taille de l'interface
        /// </summary>
        private void DeftSize()
        {

            this.clientsPanel.Width = this.ClientSize.Width * 84 / 100;
            this.clientsPanel.Height = this.ClientSize.Height * 68 / 100;
            int xlocationPanel = this.ClientSize.Width * 8 / 100;
            int ylocationPanel = this.ClientSize.Height * 17 / 100;
            this.clientsPanel.Location = new System.Drawing.Point(xlocationPanel, ylocationPanel);
            this.panelNomModule.Location = new System.Drawing.Point(xlocationPanel, ylocationPanel - 44);
            this.panelRecherche.Location = new System.Drawing.Point(this.ClientSize.Width - 500, ylocationPanel - 44);
            if (this.ClientSize.Height < 550)
            {
                this.pictureBox1.Location = new System.Drawing.Point(ClientSize.Width / 2 - 136, 0);
                if (this.ClientSize.Width < 900)
                {
                    this.pictureBox1.Visible = false;
                }

            }
            else
            {
                this.pictureBox1.Location = new System.Drawing.Point(0, 0);
                this.pictureBox1.Visible = true;
            }

            this.Update();

        }

        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formEntretien = new Interfaces.Interface_Incidents();
            formEntretien.ShowDialog();
            this.Close();

        }

        #endregion
    }
}