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
    public partial class Form_Produit : Form
    {
        Form_Stock stock;
        public Form_Produit(Form_Stock stock)
        {
            this.stock = stock;
            InitializeComponent();
        }

        private void imageBouton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Image img = new Bitmap(openFileDialog1.FileName);
                Image img1 = (new Bitmap(img, new Size(90, 90)));
                imagePictureBox.Image = img1;
            }
        }

        private void nomProduitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void validerBouton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nomProduitTextBox.Text))
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size;
                nonValideLabel.Text = "Veuillez entrer un nom pour le produit";
                nonValideLabel.Location = new Point(validerBouton.Location.X, (validerBouton.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
            }
            else
            {
                creationProduit();
                this.stock.produitsListBox.Items.Add(nomProduitTextBox.Text);
                this.Controls.Clear();
                InitializeComponent();
                MessageBox.Show("Produit ajouté à la base avec succès !");
            }
        }

        /* MANIPULATION DE LA BASE */

        /*
         * Méthode permettant la création d'un produit dans la base
         * A FAIRE
         */
        private void creationProduit()
        {
        }
    }
}
