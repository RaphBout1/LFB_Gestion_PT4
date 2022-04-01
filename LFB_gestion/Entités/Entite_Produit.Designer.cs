
namespace LFB_gestion.Entités
{
    partial class Entite_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.produitPictureBox = new System.Windows.Forms.PictureBox();
            this.nomProduitLabel = new System.Windows.Forms.Label();
            this.venteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // produitPictureBox
            // 
            this.produitPictureBox.BackColor = System.Drawing.Color.Silver;
            this.produitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.produitPictureBox.Location = new System.Drawing.Point(19, 16);
            this.produitPictureBox.Name = "produitPictureBox";
            this.produitPictureBox.Size = new System.Drawing.Size(109, 119);
            this.produitPictureBox.TabIndex = 0;
            this.produitPictureBox.TabStop = false;
            // 
            // nomProduitLabel
            // 
            this.nomProduitLabel.AutoSize = true;
            this.nomProduitLabel.Location = new System.Drawing.Point(54, 153);
            this.nomProduitLabel.Name = "nomProduitLabel";
            this.nomProduitLabel.Size = new System.Drawing.Size(35, 13);
            this.nomProduitLabel.TabIndex = 1;
            this.nomProduitLabel.Text = "label1";
            // 
            // venteLabel
            // 
            this.venteLabel.AutoSize = true;
            this.venteLabel.Location = new System.Drawing.Point(54, 182);
            this.venteLabel.Name = "venteLabel";
            this.venteLabel.Size = new System.Drawing.Size(19, 13);
            this.venteLabel.TabIndex = 2;
            this.venteLabel.Text = "12";
            // 
            // Entite_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.venteLabel);
            this.Controls.Add(this.nomProduitLabel);
            this.Controls.Add(this.produitPictureBox);
            this.Name = "Entite_Produit";
            this.Size = new System.Drawing.Size(150, 211);
            ((System.ComponentModel.ISupportInitialize)(this.produitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox produitPictureBox;
        public System.Windows.Forms.Label nomProduitLabel;
        private System.Windows.Forms.Label venteLabel;
    }
}
