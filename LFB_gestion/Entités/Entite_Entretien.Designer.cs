
namespace LFB_gestion.Entités
{
    partial class Entite_Entretien
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
            this.modifierBouton = new System.Windows.Forms.Button();
            this.nomEmplacementLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.checkBoxRésolu = new System.Windows.Forms.CheckBox();
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.nomEmployeeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierBouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.modifierBouton.FlatAppearance.BorderSize = 0;
            this.modifierBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.modifierBouton.Location = new System.Drawing.Point(567, 35);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 5;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            this.modifierBouton.Click += new System.EventHandler(this.modifierBouton_Click);
            // 
            // nomEmplacementLabel
            // 
            this.nomEmplacementLabel.AutoSize = true;
            this.nomEmplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEmplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomEmplacementLabel.Location = new System.Drawing.Point(30, 42);
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
            this.descriptionLabel.Location = new System.Drawing.Point(365, 42);
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
            this.checkBoxRésolu.Location = new System.Drawing.Point(740, 39);
            this.checkBoxRésolu.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRésolu.Name = "checkBoxRésolu";
            this.checkBoxRésolu.Size = new System.Drawing.Size(64, 29);
            this.checkBoxRésolu.TabIndex = 11;
            this.checkBoxRésolu.Text = "Fait :";
            this.checkBoxRésolu.UseVisualStyleBackColor = false;
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
            this.supprimerBouton.Location = new System.Drawing.Point(652, 33);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(39, 41);
            this.supprimerBouton.TabIndex = 4;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            this.supprimerBouton.Click += new System.EventHandler(this.supprimerBouton_Click);
            // 
            // nomEmployeeLabel
            // 
            this.nomEmployeeLabel.AutoSize = true;
            this.nomEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEmployeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomEmployeeLabel.Location = new System.Drawing.Point(163, 42);
            this.nomEmployeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomEmployeeLabel.Name = "nomEmployeeLabel";
            this.nomEmployeeLabel.Size = new System.Drawing.Size(107, 20);
            this.nomEmployeeLabel.TabIndex = 7;
            this.nomEmployeeLabel.Text = "Nom Employé";
            // 
            // Entite_Entretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.checkBoxRésolu);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nomEmplacementLabel);
            this.Controls.Add(this.nomEmployeeLabel);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.supprimerBouton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entite_Entretien";
            this.Size = new System.Drawing.Size(820, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Label nomEmplacementLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.CheckBox checkBoxRésolu;
        private System.Windows.Forms.Label nomEmployeeLabel;
    }
}
