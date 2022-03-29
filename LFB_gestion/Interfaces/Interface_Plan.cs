using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Plan : Interface_Abstraite
    {
        public Interface_Plan()
        {
            nomModuleLabel.Text = "Plan";
            rechercheTextBox.Hide(); 
            rechercheBouton.Hide();
            ajoutBouton.Hide();
            InitializeComponent();
            
        }
    }
}
