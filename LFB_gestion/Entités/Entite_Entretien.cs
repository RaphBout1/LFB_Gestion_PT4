using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Entretien : UserControl
    {

        public int id;

        public DateTime date;

        public string description;

        public string emplacement;

        public Entite_Utilisateur user;

        public Entite_Entretien(int id,DateTime date ,string description, string emplacement, Entite_Utilisateur user )
        {
            this.id = id;
            this.date = date;
            this.description = description;
            this.emplacement = emplacement;
            this.user = user;

            descriptionLabel.Text = description;
            nomEmployeeLabel.Text = user.ToString();
            nomEmplacementLabel.Text = emplacement;

            InitializeComponent();
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien(this);
            formEntretien.ShowDialog();
        }
    }
}
