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
    public partial class Entite_Reservation : UserControl
    {

        private string nomClient;

        private int empalcement;

        DateTime début;

        DateTime fin;


        public Entite_Reservation()
        {
            InitializeComponent();
        }
    }
}
