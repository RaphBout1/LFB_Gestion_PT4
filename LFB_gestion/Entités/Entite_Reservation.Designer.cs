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
            this.supprimerBouton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modifierBouton = new System.Windows.Forms.Button();
            this.buttonFacturer = new System.Windows.Forms.Button();
            this.labelAu = new System.Windows.Forms.Label();
            this.créerIncident = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomClientLabel
            // 
            this.nomClientLabel.AutoSize = true;
            this.nomClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomClientLabel.Location = new System.Drawing.Point(15, 33);
            this.nomClientLabel.Name = "nomClientLabel";
            this.nomClientLabel.Size = new System.Drawing.Size(72, 17);
            this.nomClientLabel.TabIndex = 0;
            this.nomClientLabel.Text = "NomClient";
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emplacementLabel.Location = new System.Drawing.Point(105, 33);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(93, 17);
            this.emplacementLabel.TabIndex = 1;
            this.emplacementLabel.Text = "Emplacement";
            // 
            // debutLabel
            // 
            this.debutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.debutLabel.AutoSize = true;
            this.debutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.debutLabel.Location = new System.Drawing.Point(245, 36);
            this.debutLabel.Name = "debutLabel";
            this.debutLabel.Size = new System.Drawing.Size(75, 13);
            this.debutLabel.TabIndex = 2;
            this.debutLabel.Text = "Date de début";
            // 
            // finLabel
            // 
            this.finLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finLabel.AutoSize = true;
            this.finLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.finLabel.Location = new System.Drawing.Point(366, 36);
            this.finLabel.Name = "finLabel";
            this.finLabel.Size = new System.Drawing.Size(62, 13);
            this.finLabel.TabIndex = 3;
            this.finLabel.Text = "Date de Fin";
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
            this.supprimerBouton.Location = new System.Drawing.Point(567, 21);
            this.supprimerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerBouton.Name = "supprimerBouton";
            this.supprimerBouton.Size = new System.Drawing.Size(44, 37);
            this.supprimerBouton.TabIndex = 1;
            this.supprimerBouton.UseVisualStyleBackColor = false;
            this.supprimerBouton.Click += new System.EventHandler(this.supprimerBouton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(208, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Du :";
            // 
            // modifierBouton
            // 
            this.modifierBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierBouton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.modifierBouton.FlatAppearance.BorderSize = 0;
            this.modifierBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.modifierBouton.Location = new System.Drawing.Point(480, 21);
            this.modifierBouton.Margin = new System.Windows.Forms.Padding(2);
            this.modifierBouton.Name = "modifierBouton";
            this.modifierBouton.Size = new System.Drawing.Size(61, 37);
            this.modifierBouton.TabIndex = 0;
            this.modifierBouton.Text = "Modifier";
            this.modifierBouton.UseVisualStyleBackColor = false;
            // 
            // buttonFacturer
            // 
            this.buttonFacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFacturer.BackColor = System.Drawing.Color.Transparent;
            this.buttonFacturer.FlatAppearance.BorderSize = 0;
            this.buttonFacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.buttonFacturer.Location = new System.Drawing.Point(634, 21);
            this.buttonFacturer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFacturer.Name = "buttonFacturer";
            this.buttonFacturer.Size = new System.Drawing.Size(103, 37);
            this.buttonFacturer.TabIndex = 13;
            this.buttonFacturer.Text = "Facturer >";
            this.buttonFacturer.UseVisualStyleBackColor = false;
            this.buttonFacturer.Click += new System.EventHandler(this.buttonFacturer_Click);
            // 
            // labelAu
            // 
            this.labelAu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAu.AutoSize = true;
            this.labelAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.labelAu.Location = new System.Drawing.Point(331, 33);
            this.labelAu.Name = "labelAu";
            this.labelAu.Size = new System.Drawing.Size(33, 17);
            this.labelAu.TabIndex = 10;
            this.labelAu.Text = "Au :";
            // 
            // créerIncident
            // 
            this.créerIncident.Location = new System.Drawing.Point(434, 22);
            this.créerIncident.Name = "créerIncident";
            this.créerIncident.Size = new System.Drawing.Size(40, 37);
            this.créerIncident.TabIndex = 15;
            this.créerIncident.Text = "!";
            this.créerIncident.UseVisualStyleBackColor = true;
            this.créerIncident.Click += new System.EventHandler(this.créerIncident_Click);
            // 
            // Entite_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.créerIncident);
            this.Controls.Add(this.buttonFacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAu);
            this.Controls.Add(this.supprimerBouton);
            this.Controls.Add(this.modifierBouton);
            this.Controls.Add(this.finLabel);
            this.Controls.Add(this.debutLabel);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.nomClientLabel);
            this.Name = "Entite_Reservation";
            this.Size = new System.Drawing.Size(758, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomClientLabel;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label debutLabel;
        private System.Windows.Forms.Label finLabel;
        private System.Windows.Forms.Button supprimerBouton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifierBouton;
        private System.Windows.Forms.Button buttonFacturer;
        private System.Windows.Forms.Label labelAu;
        private System.Windows.Forms.Button créerIncident;
    }
}
