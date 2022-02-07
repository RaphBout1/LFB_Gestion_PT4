
namespace LFB_gestion.Entités
{
    partial class Entite_Incident
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
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.statutBox = new System.Windows.Forms.GroupBox();
            this.nomClientLabel = new System.Windows.Forms.Label();
            this.nomEmplacementLabel = new System.Windows.Forms.Label();
            this.statutLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.BackColor = System.Drawing.Color.Red;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(359, 107);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(91, 46);
            this.supprimerBouton.TabIndex = 4;
            this.supprimerBouton.Text = "Supprimer";
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // modifierBouton
            // 
            this.modifierBouton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(272, 107);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(81, 46);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // statutBox
            // 
            this.statutBox.BackColor = System.Drawing.Color.Green;
            this.statutBox.Location = new System.Drawing.Point(376, 43);
            this.statutBox.Name = "statutBox";
            this.statutBox.Size = new System.Drawing.Size(35, 34);
            this.statutBox.TabIndex = 6;
            this.statutBox.TabStop = false;
            this.statutBox.Enter += new System.EventHandler(this.statutBox_Enter);
            // 
            // nomClientLabel
            // 
            this.nomClientLabel.AutoSize = true;
            this.nomClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomClientLabel.Location = new System.Drawing.Point(13, 43);
            this.nomClientLabel.Name = "nomClientLabel";
            this.nomClientLabel.Size = new System.Drawing.Size(112, 20);
            this.nomClientLabel.TabIndex = 7;
            this.nomClientLabel.Text = "Nom du client";
            // 
            // nomEmplacementLabel
            // 
            this.nomEmplacementLabel.AutoSize = true;
            this.nomEmplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEmplacementLabel.Location = new System.Drawing.Point(131, 43);
            this.nomEmplacementLabel.Name = "nomEmplacementLabel";
            this.nomEmplacementLabel.Size = new System.Drawing.Size(111, 20);
            this.nomEmplacementLabel.TabIndex = 8;
            this.nomEmplacementLabel.Text = "Emplacement";
            // 
            // statutLabel
            // 
            this.statutLabel.AutoSize = true;
            this.statutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statutLabel.Location = new System.Drawing.Point(307, 43);
            this.statutLabel.Name = "statutLabel";
            this.statutLabel.Size = new System.Drawing.Size(63, 20);
            this.statutLabel.TabIndex = 9;
            this.statutLabel.Text = "Statut :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(14, 91);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // Entite_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.statutLabel);
            this.Controls.Add(this.nomEmplacementLabel);
            this.Controls.Add(this.nomClientLabel);
            this.Controls.Add(this.statutBox);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.supprimerBouton);
            this.Name = "Entite_Incident";
            this.Size = new System.Drawing.Size(462, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.GroupBox statutBox;
        private System.Windows.Forms.Label nomClientLabel;
        private System.Windows.Forms.Label nomEmplacementLabel;
        private System.Windows.Forms.Label statutLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}
