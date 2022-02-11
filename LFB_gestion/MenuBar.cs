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
    }
}
