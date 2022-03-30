
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
            this.nomClientLabel = new System.Windows.Forms.Label();
            this.nomEmplacementLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.checkBoxRésolu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.supprimerBouton.Location = new System.Drawing.Point(488, 33);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(39, 41);
            this.supprimerBouton.TabIndex = 4;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            this.supprimerBouton.Click += new System.EventHandler(this.supprimerBouton_Click);
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierBouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.modifierBouton.FlatAppearance.BorderSize = 0;
            this.modifierBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.modifierBouton.Location = new System.Drawing.Point(403, 35);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // nomClientLabel
            // 
            this.nomClientLabel.AutoSize = true;
            this.nomClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomClientLabel.Location = new System.Drawing.Point(17, 45);
            this.nomClientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomClientLabel.Name = "nomClientLabel";
            this.nomClientLabel.Size = new System.Drawing.Size(105, 20);
            this.nomClientLabel.TabIndex = 7;
            this.nomClientLabel.Text = "Nom du client";
            // 
            // nomEmplacementLabel
            // 
            this.nomEmplacementLabel.AutoSize = true;
            this.nomEmplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEmplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomEmplacementLabel.Location = new System.Drawing.Point(159, 45);
            this.nomEmplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomEmplacementLabel.Name = "nomEmplacementLabel";
            this.nomEmplacementLabel.Size = new System.Drawing.Size(107, 20);
            this.nomEmplacementLabel.TabIndex = 8;
            this.nomEmplacementLabel.Text = "Emplacement";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.descriptionLabel.Location = new System.Drawing.Point(252, 45);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // checkBoxRésolu
            // 
            this.checkBoxRésolu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRésolu.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRésolu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRésolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRésolu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.checkBoxRésolu.FlatAppearance.BorderSize = 6;
            this.checkBoxRésolu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.checkBoxRésolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRésolu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.checkBoxRésolu.Location = new System.Drawing.Point(550, 41);
            this.checkBoxRésolu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRésolu.Name = "checkBoxRésolu";
            this.checkBoxRésolu.Size = new System.Drawing.Size(88, 29);
            this.checkBoxRésolu.TabIndex = 11;
            this.checkBoxRésolu.Text = "Résolu :";
            this.checkBoxRésolu.UseVisualStyleBackColor = false;
            // 
            // Entite_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.checkBoxRésolu);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nomEmplacementLabel);
            this.Controls.Add(this.nomClientLabel);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.supprimerBouton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Entite_Incident";
            this.Size = new System.Drawing.Size(656, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Label nomClientLabel;
        private System.Windows.Forms.Label nomEmplacementLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.CheckBox checkBoxRésolu;
    }
}
