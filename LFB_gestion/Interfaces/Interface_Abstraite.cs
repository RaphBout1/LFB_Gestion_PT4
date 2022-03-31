using LFB_gestion.Entités;
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
            formAccueil.FormClosed += (s, args) => this.Close();
            formAccueil.ShowDialog();
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
           // formStocks.FormClosed += (s, args) => this.Close();
            formStocks.ShowDialog();
        }

        /// <summary>
        /// Ouvrir l'onglet statistiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formStat = new Interfaces.Interface_Statistiques();
            formStat.FormClosed += (s, args) => this.Close();
            formStat.ShowDialog();
        }

        /// <summary>
        /// Ouvrir l'onglet entretien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entretienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formEntretien = new Interface_Entretien();
            formEntretien.FormClosed += (s, args) => this.Close();
            formEntretien.ShowDialog();
        }

        /// <summary>
        /// ouvrir l'onglet plan intéractif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formPlan = new Interface_Plan();
            formPlan.FormClosed += (s, args) => this.Close();
            formPlan.ShowDialog();
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
            formReservation.FormClosed += (s, args) => this.Close();
            formReservation.ShowDialog();
        }

        /// <summary>
        /// Ouvrir onglet incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formEntretien = new Interface_Incidents();
            formEntretien.FormClosed += (s, args) => this.Close();
            formEntretien.ShowDialog();

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
            formClients.FormClosed += (s, args) => this.Close();
            formClients.ShowDialog();
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
            formUtilisateur.FormClosed += (s, args) => this.Close();
            formUtilisateur.ShowDialog();
        }

        /// <summary>
        /// Ouvrir l'onglet Logs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logsToolStripButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface_Logs logs = new Interface_Logs();
            logs.FormClosed += (s, args) => this.Close();
            logs.ShowDialog();
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
                    logsToolStripButton.Visible = true;
                }
                //Au contraire les caché
                else
                {
                    utilisateursToolStripMenuItem.Visible = false;
                    statistiquesToolStripMenuItem.Visible = false;
                    logsToolStripButton.Visible = false;
                }
            }
        }

        /// <summary>
        /// Fonction qui définie l'emplacement des éléments en fonction de la taille de l'interface
        /// </summary>
        private void DeftSize()
        {

            clientsPanel.Width = ClientSize.Width * 84 / 100;
            clientsPanel.Height = ClientSize.Height * 68 / 100;
            int xlocationPanel = ClientSize.Width * 8 / 100;
            int ylocationPanel = ClientSize.Height * 17 / 100;
            clientsPanel.Location = new Point(xlocationPanel, ylocationPanel);
            panelNomModule.Location = new Point(xlocationPanel, ylocationPanel - 44);
            panelRecherche.Location = new Point(ClientSize.Width - 500, ylocationPanel - 44);
            buttonDeconnexion.Location = new Point(ClientSize.Width - 210, 0);
            if (ClientSize.Height < 550)
            {
                pictureBox1.Location = new Point(ClientSize.Width / 2 - 136, 0);
                if (ClientSize.Width < 900)
                {
                   pictureBox1.Visible = false;
                }

            }
            else
            {
                pictureBox1.Location = new Point(0, 0);
               pictureBox1.Visible = true;
            }

            Update();


        }

        /// <summary>
        /// Se déconnecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Entite_Utilisateur.courant = null;
            this.Hide();
            Form formConnexion = new Connexion();
            formConnexion.FormClosed += (s, args) => this.Close();
            formConnexion.ShowDialog();
        }

        #endregion
    }
}