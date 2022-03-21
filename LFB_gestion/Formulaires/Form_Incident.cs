using System;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Incident : Form
    {
        public Form_Incident()
        {
            InitializeComponent();
            remplirClientsEtEmplacements();
        }


        #region Événements
        /// <summary>
        /// Valider l'incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validationBouton_Click(object sender, EventArgs e)
        {
            if (!auMoinsUnClientSelectionne() || !auMoinsUnEmplacementSelectionne())
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size;
                nonValideLabel.Text = "Veuillez sélectionner un client et un emplacement";
                nonValideLabel.Location = new Point(clientLabel.Location.X, (clientLabel.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
            }
            else
            {
                creationEmplacement();
                this.Controls.Clear();
                InitializeComponent();
                remplirClientsEtEmplacements();
                MessageBox.Show("Emplacement créé avec succès !");
            }
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// vérifie si au moins un emplacement est sélectionné
        /// </summary>
        /// <returns>renvoie vrai si au moins un emplacement est selectionné</returns>
        private bool auMoinsUnEmplacementSelectionne()
        {
            return emplacementsListBox.SelectedItems.Count == 0;
        }

        /// <summary>
        /// Vérifie si au moins un client est sélectionné
        /// </summary>
        /// <returns></returns>
        private bool auMoinsUnClientSelectionne()
        {
            return clientsListBox.SelectedItems.Count == 0;
        }
        #endregion

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
