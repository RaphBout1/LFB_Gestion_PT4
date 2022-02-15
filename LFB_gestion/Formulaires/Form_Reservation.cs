using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Reservation : Form
    {
        public Form_Reservation()
        {
            InitializeComponent();
        }

        private void nouveauClientBouton_Click(object sender, EventArgs e)
        {
            Form_Client formNouveauClient = new Form_Client();
            formNouveauClient.Show();
        }

        private void validerBouton_Click(object sender, EventArgs e)
        {
        }
    }
}
