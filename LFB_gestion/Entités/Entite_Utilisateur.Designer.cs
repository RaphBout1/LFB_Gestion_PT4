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
            this.loginLabel = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(2, 35);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 17);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // modifierBouton
            // 
            this.modifierBouton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(204, 35);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.BackColor = System.Drawing.Color.Red;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(269, 35);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(68, 37);
            this.supprimerBouton.TabIndex = 6;
            this.supprimerBouton.Text = "Supprimer";
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLabel.Location = new System.Drawing.Point(116, 35);
            this.reservationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(84, 17);
            this.reservationLabel.TabIndex = 7;
            this.reservationLabel.Text = "Réservation";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(43, 35);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // Entite_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.loginLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entite_Utilisateur";
            this.Size = new System.Drawing.Size(346, 83);
            this.Load += new System.EventHandler(this.Entite_Utilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}
