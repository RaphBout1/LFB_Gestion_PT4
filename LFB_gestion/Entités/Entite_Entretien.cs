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

        public string date;

        public string description;

        public int emplacement;

        public string user;

        public Entite_Entretien(int id, string date, string description, int emplacement, string user)
        {
            this.id = id;
            this.date = date;
            this.description = description;

            this.user = user;
            this.emplacement = emplacement;
            InitializeComponent();
            nomEmployeeLabel.Text = user.ToString();
            nomEmplacementLabel.Text = emplacement.ToString();
            descriptionLabel.Text = description;



            
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien(this);
            formEntretien.ShowDialog();
        }
    }
}
