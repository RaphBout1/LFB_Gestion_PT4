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
    public partial class Entite_Produit : UserControl
    {
        private string img;
        private String nbVentes;
        private String nomProduit;
        public Entite_Produit(String nomProduit, String nbVentes, string img)
        {
            this.img = img;
            this.nomProduit = nomProduit;
            this.nbVentes = nbVentes;
            InitializeComponent();
            Outils.afficherImage(img, produitPictureBox);
            venteLabel.Text = nbVentes;
            nomProduitLabel.Text = nomProduit;
        }
    }
}
