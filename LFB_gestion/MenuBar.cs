using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion
{
    public partial class MenuBar : Form
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formReserv = new Interfaces.Interface_Clients();
            formReserv.Show();
        }

        private void boutonClients_Click(object sender, EventArgs e)
        {
            Form formClients = new Formulaires.Form_Client();
            formClients.Show();
        }

        private void boutonReservations_Click(object sender, EventArgs e)
        {
            Form formRes = new Interfaces.Interface_Reservations();
            formRes.Show();
        }

        private void boutonIncidents_Click(object sender, EventArgs e)
        {
            Form formIncid = new Interfaces.Interface_Incidents();
            formIncid.Show();
        }

        private void boutonStocks_Click(object sender, EventArgs e)
        {
            Form formStocks = new Interfaces.Interface_Stocks();
            formStocks.Show();
        }

        private void boutonIncidents_Click_1(object sender, EventArgs e)
        {
            Form formIncidents = new Formulaires.Form_Incident();
            formIncidents.Show();
        }

        private void empalcements_Click(object sender, EventArgs e)
        {
            Form formReservation = new Formulaires.Form_Reservation();
            formReservation.Show();
        }

        private void stocksBouton_Click(object sender, EventArgs e)
        {
            Form formStocks = new Formulaires.Form_Stock();
            formStocks.Show();
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }
    }
}
