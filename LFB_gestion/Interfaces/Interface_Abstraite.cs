using LFB_gestion.Classes;
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
        private Utilisateur u;
        public Interface_Abstraite()
        {


            InitializeComponent();
            Admin();
            DeftSize();


        }
        private void Admin()

        {
            if (Utilisateur.getUtilisateurCourant() != null)
            {
                //si l'utilisateur courant est un admin alors rendre visible les fonctions admin
                if (Utilisateur.getUtilisateurCourant().admin == 1)
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

        //Fonction qui définie l'emplacement des élément en fonction de la taille de l'interface
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

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAccueil = new Interfaces.Interface_Accueil();

            formAccueil.ShowDialog();
            this.Close();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formStocks = new Interfaces.Interface_Stocks();

            formStocks.ShowDialog();
            this.Close();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entretienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formEntretien = new Interfaces.Interface_Incidents();

            formEntretien.ShowDialog();
            this.Close();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formReservation = new Interfaces.Interface_Reservations();

            formReservation.ShowDialog();
            this.Close();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formClients = new Interfaces.Interface_Clients();

            formClients.ShowDialog();
            this.Close();
        }

        private void Interface_Abstraite_Resize(object sender, EventArgs e)
        {
            DeftSize();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formUtilisateur = new Interfaces.Interface_Utilisateurs();

            formUtilisateur.ShowDialog();
            this.Close();
        }

        private void Interface_Abstraite_Load(object sender, EventArgs e)
        {

        }
    }
}