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
    }
}
