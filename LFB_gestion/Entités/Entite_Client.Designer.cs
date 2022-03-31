
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
            this.modifierBouton = new System.Windows.Forms.Button();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
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
            this.prenomLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.prenomLabel.Location = new System.Drawing.Point(149, 37);
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
            this.emailLabel.Location = new System.Drawing.Point(362, 37);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "email@email.test";
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierBouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.modifierBouton.FlatAppearance.BorderSize = 0;
            this.modifierBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBouton.ForeColor = System.Drawing.Color.AliceBlue;
            this.modifierBouton.Location = new System.Drawing.Point(846, 27);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 4;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // supprimerBouton
            // 
            this.supprimerBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supprimerBouton.BackColor = System.Drawing.Color.Transparent;
            this.supprimerBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.iconneSupp;
            this.supprimerBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimerBouton.FlatAppearance.BorderSize = 0;
            this.supprimerBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerBouton.Location = new System.Drawing.Point(951, 24);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(50, 46);
            this.supprimerBouton.TabIndex = 3;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            this.supprimerBouton.Click += new System.EventHandler(this.supprimerBouton_Click);
            // 
            // labelTel
            // 
            this.labelTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.labelTel.Location = new System.Drawing.Point(542, 37);
            this.labelTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(88, 17);
            this.labelTel.TabIndex = 5;
            this.labelTel.Text = "0123456789";
            // 
            // Entite_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entite_Client";
            this.Size = new System.Drawing.Size(1041, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Label labelTel;
    }
}
