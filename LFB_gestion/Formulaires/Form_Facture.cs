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
        public Entite_Reservation réservation;

        private SqlConnection connexion = Outils.Connexion();

        public Form_Facture(Entite_Reservation réservation)
        {
            this.réservation = réservation;
            InitializeComponent();
            remplirDonnées();
        }

        /// <summary>
        /// Instancie les variables nécessaires pour remplir ensuite le form Facture
        /// </summary>
        private void remplirDonnées()
        {
            numFactureTextBox.Text = numFacture().ToString();

            dateTextBox.Text = date();

            Entite_Client leClient = client();

            clientTextBox.Text = leClient.ToString();
            adresseTextBox.Text = leClient.adresse;
            codePostalTextBox.Text = leClient.codePostal;
            villeTextBox.Text = leClient.ville;
            telTextBox.Text = leClient.tel;
            mailTextBox.Text = leClient.mail;

            débutTextBox.Text = réservation.début.ToString("dd/MM/yyyy");
            finTextBox.Text = réservation.fin.ToString("dd/MM/yyyy");

            emplacementTextBox.Text = réservation.emplacement.ToString();
        }

        /// <summary>
        /// Retourne un string de la date actuelle
        /// </summary>
        /// <returns></returns>
        private string date()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Retourne lentité client selon l'idClient
        /// </summary>
        /// <returns></returns>
        private Entite_Client client()
        {
            return Outils.findClient(réservation.idClient);
        }

        /// <summary>
        /// Récupére le dernier numéro de facture dans la bd et incrémente
        /// </summary>
        /// <returns>renvoie le numéro de la dernière facture +1</returns>
        private int numFacture()
        {
            int numFacture = 0;
            SqlCommand cmd = new SqlCommand("select count(*) from facture", connexion);
            try
            {
                connexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                numFacture = reader.GetInt32(0) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return numFacture;
        }

        /// <summary>
        /// Savoir si la facture est un acompte ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
