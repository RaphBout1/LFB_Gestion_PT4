using LFB_gestion.Entités;
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

namespace LFB_gestion.Formulaires
{
    public partial class Form_Facture : Form
    {
        private SqlConnection connexion = Outils.Connexion();

        public Form_Facture(Entite_Reservation réservation)
        {
            InitializeComponent();
            remplirDonnées();
        }

        private void remplirDonnées()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from facture", connexion);
            try
            {
                connexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int numFacture = reader.GetInt32(0) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void acompteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acompteCheckBox.Checked)
            {
                acompteCheckBox.Text = "Facture d'acompte";
            }
            else
            {
                acompteCheckBox.Text = "Facture";
            }
        }
    }
}
