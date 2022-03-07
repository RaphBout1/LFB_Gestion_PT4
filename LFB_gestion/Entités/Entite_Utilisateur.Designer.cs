namespace LFB_gestion.Entités
{
    partial class Entite_Utilisateur
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
            this.prenomLabel = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prenomLabel
            // 
            this.prenomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.BackColor = System.Drawing.Color.Maroon;
            this.prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.Location = new System.Drawing.Point(3, 43);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(65, 20);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "prénom";
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modifierBouton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(272, 30);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(81, 46);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.supprimerBouton.BackColor = System.Drawing.Color.Red;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(359, 30);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(91, 46);
            this.supprimerBouton.TabIndex = 6;
            this.supprimerBouton.Text = "Supprimer";
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // nomLabel
            // 
            this.nomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.DarkRed;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(122, 43);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(41, 20);
            this.nomLabel.TabIndex = 8;
            this.nomLabel.Text = "nom";
            // 
            // Entite_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.prenomLabel);
            this.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Name = "Entite_Utilisateur";
            this.Size = new System.Drawing.Size(461, 100);
            this.Load += new System.EventHandler(this.Entite_Utilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Label nomLabel;
    }
}
