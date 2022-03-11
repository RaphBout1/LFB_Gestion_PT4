namespace LFB_gestion.Entités
{
    partial class Entite_Reservation
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
            this.nomClientLabel = new System.Windows.Forms.Label();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.debutLabel = new System.Windows.Forms.Label();
            this.finLabel = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomClientLabel
            // 
            this.nomClientLabel.AutoSize = true;
            this.nomClientLabel.Location = new System.Drawing.Point(14, 36);
            this.nomClientLabel.Name = "nomClientLabel";
            this.nomClientLabel.Size = new System.Drawing.Size(55, 13);
            this.nomClientLabel.TabIndex = 0;
            this.nomClientLabel.Text = "NomClient";
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(99, 36);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(71, 13);
            this.emplacementLabel.TabIndex = 1;
            this.emplacementLabel.Text = "Emplacement";
            // 
            // debutLabel
            // 
            this.debutLabel.AutoSize = true;
            this.debutLabel.Location = new System.Drawing.Point(215, 21);
            this.debutLabel.Name = "debutLabel";
            this.debutLabel.Size = new System.Drawing.Size(27, 13);
            this.debutLabel.TabIndex = 2;
            this.debutLabel.Text = "Deb";
            // 
            // finLabel
            // 
            this.finLabel.AutoSize = true;
            this.finLabel.Location = new System.Drawing.Point(323, 21);
            this.finLabel.Name = "finLabel";
            this.finLabel.Size = new System.Drawing.Size(21, 13);
            this.finLabel.TabIndex = 3;
            this.finLabel.Text = "Fin";
            // 
            // modifierBouton
            // 
            this.modifierBouton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(208, 46);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 0;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.BackColor = System.Drawing.Color.Red;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(276, 46);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(68, 37);
            this.supprimerBouton.TabIndex = 1;
            this.supprimerBouton.Text = "Supprimer";
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "au";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "du";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "emplacement";
            // 
            // Entite_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.finLabel);
            this.Controls.Add(this.debutLabel);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.nomClientLabel);
            this.Name = "Entite_Reservation";
            this.Size = new System.Drawing.Size(425, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomClientLabel;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label debutLabel;
        private System.Windows.Forms.Label finLabel;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
