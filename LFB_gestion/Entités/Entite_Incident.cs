using System;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Incident : UserControl
    {

        public int id;
        public string description;
        public int id_réservation;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="idClient"></param>
        /// <param name="idEmplacement"></param>
        /// <param name="date"></param>
        public Entite_Incident(int id, string description, int id_réservation)
        {
            this.id = id;
            this.description = description;
            this.id_réservation = id_réservation;
            InitializeComponent();
            descriptionLabel.Text = description;
        }
    }
}
