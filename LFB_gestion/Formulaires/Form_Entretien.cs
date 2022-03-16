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
    public partial class Form_Entretien : Form
    {
        public Form_Entretien(Entités.Entite_Entretien entretien)
        {
            InitializeComponent();
            if (entretien != null)
            {
                descriptionTextBox.Text = entretien.description;
            }
        }
    }
}
