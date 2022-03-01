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
            this.nomUtilisateur_textBox = new System.Windows.Forms.TextBox();
            this.motDePasse_textBox = new System.Windows.Forms.TextBox();
            this.nomUtilisateur_label = new System.Windows.Forms.Label();
            this.motDePasse_label = new System.Windows.Forms.Label();
            this.connexion_label = new System.Windows.Forms.Label();
            this.seConnecter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomUtilisateur_textBox
            // 
            this.nomUtilisateur_textBox.Location = new System.Drawing.Point(423, 329);
            this.nomUtilisateur_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomUtilisateur_textBox.Name = "nomUtilisateur_textBox";
            this.nomUtilisateur_textBox.Size = new System.Drawing.Size(289, 22);
            this.nomUtilisateur_textBox.TabIndex = 0;
            // 
            // motDePasse_textBox
            // 
            this.motDePasse_textBox.Location = new System.Drawing.Point(423, 412);
            this.motDePasse_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.motDePasse_textBox.Name = "motDePasse_textBox";
            this.motDePasse_textBox.PasswordChar = '•';
            this.motDePasse_textBox.Size = new System.Drawing.Size(289, 22);
            this.motDePasse_textBox.TabIndex = 1;
            // 
            // nomUtilisateur_label
            // 
            this.nomUtilisateur_label.AutoSize = true;
            this.nomUtilisateur_label.Location = new System.Drawing.Point(420, 308);
            this.nomUtilisateur_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomUtilisateur_label.Name = "nomUtilisateur_label";
            this.nomUtilisateur_label.Size = new System.Drawing.Size(113, 17);
            this.nomUtilisateur_label.TabIndex = 2;
            this.nomUtilisateur_label.Text = "Nom d\'utilisateur";
            // 
            // motDePasse_label
            // 
            this.motDePasse_label.AutoSize = true;
            this.motDePasse_label.Location = new System.Drawing.Point(420, 391);
            this.motDePasse_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motDePasse_label.Name = "motDePasse_label";
            this.motDePasse_label.Size = new System.Drawing.Size(93, 17);
            this.motDePasse_label.TabIndex = 3;
            this.motDePasse_label.Text = "Mot de passe";
            // 
            // connexion_label
            // 
            this.connexion_label.AutoSize = true;
            this.connexion_label.Location = new System.Drawing.Point(16, 11);
            this.connexion_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connexion_label.Name = "connexion_label";
            this.connexion_label.Size = new System.Drawing.Size(133, 17);
            this.connexion_label.TabIndex = 4;
            this.connexion_label.Text = "Écran de connexion";
            // 
            // seConnecter_button
            // 
            this.seConnecter_button.Location = new System.Drawing.Point(504, 442);
            this.seConnecter_button.Margin = new System.Windows.Forms.Padding(4);
            this.seConnecter_button.Name = "seConnecter_button";
            this.seConnecter_button.Size = new System.Drawing.Size(125, 28);
            this.seConnecter_button.TabIndex = 5;
            this.seConnecter_button.Text = "Se connecter";
            this.seConnecter_button.UseVisualStyleBackColor = true;
            this.seConnecter_button.Click += new System.EventHandler(this.seConnecter_button_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondConnexion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 591);
            this.Controls.Add(this.seConnecter_button);
            this.Controls.Add(this.connexion_label);
            this.Controls.Add(this.motDePasse_label);
            this.Controls.Add(this.nomUtilisateur_label);
            this.Controls.Add(this.motDePasse_textBox);
            this.Controls.Add(this.nomUtilisateur_textBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomUtilisateur_textBox;
        private System.Windows.Forms.TextBox motDePasse_textBox;
        private System.Windows.Forms.Label nomUtilisateur_label;
        private System.Windows.Forms.Label motDePasse_label;
        private System.Windows.Forms.Label connexion_label;
        private System.Windows.Forms.Button seConnecter_button;
    }
}
