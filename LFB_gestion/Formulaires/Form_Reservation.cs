using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Reservation : Form
    {

        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        public Form_Reservation()
        {
            InitializeComponent();
            remplirClients();
        }

        private void nouveauClientBouton_Click(object sender, EventArgs e)
        {
            Form_Client formNouveauClient = new Form_Client();
            formNouveauClient.Show();
        }

        private void validerBouton_Click(object sender, EventArgs e)
        {
            if (!auMoinsUnClientSelectionne() || !auMoinsUnEmplacementSelectionne() || !dateLogiques())
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size;
                nonValideLabel.Text = "Les champs du formulaires ont mal été remplis";
                nonValideLabel.Location = new Point(validerBouton.Location.X, (validerBouton.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
            }
            else
            {
                creationEmplacement();
                this.Controls.Clear();
                InitializeComponent();
                remplirClients();
                MessageBox.Show("Réservation ajoutée à la base avec succès !");
            }
        }

        private bool dateLogiques()
        {
            return calendrier.SelectionEnd != calendrier.SelectionStart;
        }

        private bool auMoinsUnEmplacementSelectionne()
        {
            if (emplacementsListBox.SelectedItems.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool auMoinsUnClientSelectionne()
        {
            if (clientsListBox.SelectedItems.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        /* MANIPULATION DE LA BASE */


        /// <summary>
        /// Rempli la listBox avec les clients existant dans la basede données
        /// </summary>
        private void remplirClients()
        {
            string query = "SELECT prenom, nom FROM client";
            SqlCommand command = new SqlCommand(query, connexion);
            connexion.Open();
            DbDataReader reader = command.ExecuteReader();

            if (reader.HasRows) //S'il existe des clients
            {
                while (reader.Read())
                {
                    clientsListBox.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                }
                reader.Close();
            }
            connexion.Close();
        }

        /*
         * Méthode permettant la création d'un emplacement dans la base
         * A FAIRE
         */
        private void creationEmplacement()
        {
        }

        /// <summary>
        /// Selon les dates selectionnées ça va afficher les emplacements disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            string query = "select emplacement.id from emplacement " +
                "left outer join reservation on emplacement.id = reservation.id_emplacement " +
                "and '2022-02-10' not between date_debut and date_fin";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("", null);

        }
    }
}
