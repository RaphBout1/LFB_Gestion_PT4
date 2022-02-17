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
            remplirClientsEtEmplacements();
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
                remplirClientsEtEmplacements();
                MessageBox.Show("Réservation ajoutée à la base avec succès !");
            }
        }

        private bool dateLogiques()
        {
            return dateDebutCalendrier.SelectionEnd != dateDebutCalendrier.SelectionStart;
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


        /*
        * Méthode permettant de remplir les listes clients et emplacements
        * A MODIFIER AVEC LA BASE DE DONNEES
        */
        private void remplirClientsEtEmplacements()
        {
            for (int i = 0; i < 30; i++)
            {
                clientsListBox.Items.Add("client " + i);
                emplacementsListBox.Items.Add("emplacement " + i);
            }
        }


        /*
         * Méthode permettant la création d'un emplacement dans la base
         * A FAIRE
         */
        private void creationEmplacement()
        {
        }
    }
}
