namespace LFB_gestion
{
    partial class Connexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.nomUtilisateur_textBox = new System.Windows.Forms.TextBox();
            this.motDePasse_textBox = new System.Windows.Forms.TextBox();
            this.seConnecter_button = new System.Windows.Forms.Button();
            this.visionMDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomUtilisateur_textBox
            // 
            this.nomUtilisateur_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomUtilisateur_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomUtilisateur_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomUtilisateur_textBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nomUtilisateur_textBox.Location = new System.Drawing.Point(392, 300);
            this.nomUtilisateur_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomUtilisateur_textBox.Name = "nomUtilisateur_textBox";
            this.nomUtilisateur_textBox.Size = new System.Drawing.Size(352, 31);
            this.nomUtilisateur_textBox.TabIndex = 0;
            this.nomUtilisateur_textBox.Text = "Nom d\'utilisateur";
            // 
            // motDePasse_textBox
            // 
            this.motDePasse_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motDePasse_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motDePasse_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasse_textBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.motDePasse_textBox.Location = new System.Drawing.Point(392, 372);
            this.motDePasse_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.motDePasse_textBox.Name = "motDePasse_textBox";
            this.motDePasse_textBox.Size = new System.Drawing.Size(352, 31);
            this.motDePasse_textBox.TabIndex = 1;
            this.motDePasse_textBox.Text = "Mot de passe";
            this.motDePasse_textBox.UseSystemPasswordChar = true;
            // 
            // seConnecter_button
            // 
            this.seConnecter_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seConnecter_button.BackColor = System.Drawing.Color.Transparent;
            this.seConnecter_button.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.seConnecter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seConnecter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seConnecter_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.seConnecter_button.FlatAppearance.BorderSize = 0;
            this.seConnecter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seConnecter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seConnecter_button.ForeColor = System.Drawing.Color.Transparent;
            this.seConnecter_button.Location = new System.Drawing.Point(467, 431);
            this.seConnecter_button.Margin = new System.Windows.Forms.Padding(4);
            this.seConnecter_button.Name = "seConnecter_button";
            this.seConnecter_button.Size = new System.Drawing.Size(191, 43);
            this.seConnecter_button.TabIndex = 5;
            this.seConnecter_button.Text = "Se connecter";
            this.seConnecter_button.UseVisualStyleBackColor = false;
            this.seConnecter_button.Click += new System.EventHandler(this.seConnecter_button_Click);
            // 
            // visionMDP
            // 
            this.visionMDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visionMDP.BackColor = System.Drawing.Color.Transparent;
            this.visionMDP.BackgroundImage = global::LFB_gestion.Properties.Resources.oeilFermer;
            this.visionMDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visionMDP.FlatAppearance.BorderSize = 0;
            this.visionMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visionMDP.Location = new System.Drawing.Point(752, 372);
            this.visionMDP.Name = "visionMDP";
            this.visionMDP.Size = new System.Drawing.Size(42, 31);
            this.visionMDP.TabIndex = 6;
            this.visionMDP.UseVisualStyleBackColor = false;
            this.visionMDP.Click += new System.EventHandler(this.visionMDP_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondConnexion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 591);
            this.Controls.Add(this.visionMDP);
            this.Controls.Add(this.seConnecter_button);
            this.Controls.Add(this.motDePasse_textBox);
            this.Controls.Add(this.nomUtilisateur_textBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomUtilisateur_textBox;
        private System.Windows.Forms.TextBox motDePasse_textBox;
        private System.Windows.Forms.Button seConnecter_button;
        private System.Windows.Forms.Button visionMDP;
    }
}
