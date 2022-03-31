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
        private Image img;
        private String nbVentes;
        private String nomProduit;
        /// <summary>
        /// Constructeur de l'entité produit
        /// </summary>
        /// <param name="nomProduit"></param>
        /// <param name="nbVentes"></param>
        public Entite_Produit(String nomProduit, String nbVentes)
        {
            this.img = img;
            this.nomProduit = nomProduit;
            this.nbVentes = nbVentes;
            InitializeComponent();
            produitPictureBox.Image = img;
            venteLabel.Text = nbVentes;
            nomProduitLabel.Text = nomProduit;
        }
    }
}
