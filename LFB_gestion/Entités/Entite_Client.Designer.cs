
namespace LFB_gestion.Entités
{
    partial class Entite_Client
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomLabel.Location = new System.Drawing.Point(2, 37);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(37, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            // 
            // prenomLabel
            // 
            this.prenomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.prenomLabel.Location = new System.Drawing.Point(40, 37);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(57, 17);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prénom";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emailLabel.Location = new System.Drawing.Point(134, 37);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "email@email.test";
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supprimerBouton.BackColor = System.Drawing.Color.Red;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(373, 27);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(88, 37);
            this.supprimerBouton.TabIndex = 3;
            this.supprimerBouton.Text = "Supprimer";
            this.supprimerBouton.UseVisualStyleBackColor = false;
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierBouton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifierBouton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifierBouton.Location = new System.Drawing.Point(274, 27);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 4;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // Entite_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entite_Client";
            this.Size = new System.Drawing.Size(463, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Button modifierBouton;
    }
}
