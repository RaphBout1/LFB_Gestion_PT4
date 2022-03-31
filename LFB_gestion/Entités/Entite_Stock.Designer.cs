
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
            this.nomProduitLabel = new System.Windows.Forms.Label();
            this.quantiteProduitLabel = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.imageProduitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomProduitLabel
            // 
            this.nomProduitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomProduitLabel.AutoSize = true;
            this.nomProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProduitLabel.Location = new System.Drawing.Point(73, 13);
            this.nomProduitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomProduitLabel.Name = "nomProduitLabel";
            this.nomProduitLabel.Size = new System.Drawing.Size(105, 17);
            this.nomProduitLabel.TabIndex = 1;
            this.nomProduitLabel.Text = "Nom du produit";
            this.nomProduitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantiteProduitLabel
            // 
            this.quantiteProduitLabel.AutoSize = true;
            this.quantiteProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteProduitLabel.Location = new System.Drawing.Point(100, 235);
            this.quantiteProduitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantiteProduitLabel.Name = "quantiteProduitLabel";
            this.quantiteProduitLabel.Size = new System.Drawing.Size(62, 17);
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
            this.modifierBouton.Location = new System.Drawing.Point(158, 51);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(74, 70);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.UseVisualStyleBackColor = false;
            this.modifierBouton.Click += new System.EventHandler(this.modifierBouton_Click);
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.BackColor = System.Drawing.Color.Transparent;
            this.supprimerBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.iconePoubelleStock;
            this.supprimerBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimerBouton.FlatAppearance.BorderSize = 0;
            this.supprimerBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(158, 132);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(74, 70);
            this.supprimerBouton.TabIndex = 6;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            this.supprimerBouton.Click += new System.EventHandler(this.supprimerBouton_Click);
            // 
            // imageProduitBox
            // 
            this.imageProduitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageProduitBox.Location = new System.Drawing.Point(25, 51);
            this.imageProduitBox.Name = "imageProduitBox";
            this.imageProduitBox.Size = new System.Drawing.Size(133, 150);
            this.imageProduitBox.TabIndex = 7;
            this.imageProduitBox.TabStop = false;
            // 
            // Entite_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondStock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.imageProduitBox);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.quantiteProduitLabel);
            this.Controls.Add(this.nomProduitLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entite_Stock";
            this.Size = new System.Drawing.Size(256, 268);
            ((System.ComponentModel.ISupportInitialize)(this.imageProduitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomProduitLabel;
        private System.Windows.Forms.Label quantiteProduitLabel;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.PictureBox imageProduitBox;
    }
}
