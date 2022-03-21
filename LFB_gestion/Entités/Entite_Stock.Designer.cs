
namespace LFB_gestion.Entités
{
    partial class Entite_Stock
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
            this.imageProduit = new System.Windows.Forms.GroupBox();
            this.nomProduitLabel = new System.Windows.Forms.Label();
            this.quantiteProduitLabel = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageProduit
            // 
            this.imageProduit.BackColor = System.Drawing.SystemColors.Highlight;
            this.imageProduit.Location = new System.Drawing.Point(38, 63);
            this.imageProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageProduit.Name = "imageProduit";
            this.imageProduit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageProduit.Size = new System.Drawing.Size(167, 186);
            this.imageProduit.TabIndex = 0;
            this.imageProduit.TabStop = false;
            this.imageProduit.Text = "Image du produit";
            // 
            // nomProduitLabel
            // 
            this.nomProduitLabel.AutoSize = true;
            this.nomProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProduitLabel.Location = new System.Drawing.Point(99, 17);
            this.nomProduitLabel.Name = "nomProduitLabel";
            this.nomProduitLabel.Size = new System.Drawing.Size(123, 20);
            this.nomProduitLabel.TabIndex = 1;
            this.nomProduitLabel.Text = "Nom du produit";
            // 
            // quantiteProduitLabel
            // 
            this.quantiteProduitLabel.AutoSize = true;
            this.quantiteProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteProduitLabel.Location = new System.Drawing.Point(133, 289);
            this.quantiteProduitLabel.Name = "quantiteProduitLabel";
            this.quantiteProduitLabel.Size = new System.Drawing.Size(72, 20);
            this.quantiteProduitLabel.TabIndex = 2;
            this.quantiteProduitLabel.Text = "Quantité";
            // 
            // modifierBouton
            // 
            this.modifierBouton.BackColor = System.Drawing.Color.Transparent;
            this.modifierBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.IconeModiStock;
            this.modifierBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modifierBouton.FlatAppearance.BorderSize = 0;
            this.modifierBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(211, 63);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(98, 86);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.BackColor = System.Drawing.Color.Transparent;
            this.supprimerBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.iconePoubelleStock;
            this.supprimerBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimerBouton.FlatAppearance.BorderSize = 0;
            this.supprimerBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(211, 163);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(98, 86);
            this.supprimerBouton.TabIndex = 6;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // Entite_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondStock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.quantiteProduitLabel);
            this.Controls.Add(this.nomProduitLabel);
            this.Controls.Add(this.imageProduit);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Entite_Stock";
            this.Size = new System.Drawing.Size(342, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox imageProduit;
        private System.Windows.Forms.Label nomProduitLabel;
        private System.Windows.Forms.Label quantiteProduitLabel;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button supprimerBouton;
    }
}
