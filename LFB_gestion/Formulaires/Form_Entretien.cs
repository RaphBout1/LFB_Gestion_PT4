using LFB_gestion.Entités;
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
    public partial class Form_Entretien : Form
    {
        public Form_Entretien(Entités.Entite_Entretien entretien)
        {
            InitializeComponent();
            if (entretien != null)
            {
                descriptionTextBox.Text = entretien.description;
                Outils.remplirUtilisateur(utilisateurListBox, entretien.user);
                Outils.remplirEmplacement(emplacementsListBox, entretien.emplacement.ToString());
            }
            else
            {
                Outils.remplirUtilisateur(utilisateurListBox, null);
                Outils.remplirEmplacement(emplacementsListBox, null);
            }
        }

        /// <summary>
        /// Vérifie si au moins un user est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un user est sélectionné</returns>
        private bool auMoinsUnUserSelectionne()
        {
            return utilisateurListBox.SelectedItem != null;
        }

        /// <summary>
        /// Vérifie si au moins un emplacement est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un emplacement est sélectionné</returns>
        private bool auMoinsUnEmplacementSelectionne()
        {
            return emplacementsListBox.SelectedItem != null;
        }

        private void validationBouton_Click(object sender, EventArgs e)
        {
            if (auMoinsUnUserSelectionne())
            {
                if (auMoinsUnEmplacementSelectionne())
                {
                    if (descriptionTextBox != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Description vide");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un emplacement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un utilisateur.");
            }
        }

        private void ajouterEntretien(string description, Entite_Client client,  string emplacement)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            string query = "select max(id) from entretien";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();
            int id = 0;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                id++;
            }
            reader.Close();
            query = "insert into entretien  values (@id, @emplacement, @client, GETDATE())";
            command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@emplacement", emplacement);
            command.Parameters.AddWithValue("@client", client.id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Réservation des emplacements " + s + " effectuée au nom de " + client.ToString());
            connexion.Close();
        }
    }
}


