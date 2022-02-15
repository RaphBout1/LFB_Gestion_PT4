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
        public Form_Produit()
        {
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
    }
}
