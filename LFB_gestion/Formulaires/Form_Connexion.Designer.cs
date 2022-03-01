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
            this.seConnecter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomUtilisateur_textBox
            // 
            this.nomUtilisateur_textBox.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomUtilisateur_textBox.Location = new System.Drawing.Point(317, 267);
            this.nomUtilisateur_textBox.Name = "nomUtilisateur_textBox";
            this.nomUtilisateur_textBox.Size = new System.Drawing.Size(218, 20);
            this.nomUtilisateur_textBox.TabIndex = 0;
            this.nomUtilisateur_textBox.Text = "Nom d\'utilisateur";
            // 
            // motDePasse_textBox
            // 
            this.motDePasse_textBox.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasse_textBox.Location = new System.Drawing.Point(317, 312);
            this.motDePasse_textBox.Name = "motDePasse_textBox";
            this.motDePasse_textBox.PasswordChar = '•';
            this.motDePasse_textBox.Size = new System.Drawing.Size(218, 20);
            this.motDePasse_textBox.TabIndex = 1;
            this.motDePasse_textBox.Text = "Mot de passe";
            // 
            // seConnecter_button
            // 
            this.seConnecter_button.Location = new System.Drawing.Point(378, 359);
            this.seConnecter_button.Name = "seConnecter_button";
            this.seConnecter_button.Size = new System.Drawing.Size(94, 23);
            this.seConnecter_button.TabIndex = 5;
            this.seConnecter_button.Text = "Se connecter";
            this.seConnecter_button.UseVisualStyleBackColor = true;
            this.seConnecter_button.Click += new System.EventHandler(this.seConnecter_button_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondConnexion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 480);
            this.Controls.Add(this.seConnecter_button);
            this.Controls.Add(this.motDePasse_textBox);
            this.Controls.Add(this.nomUtilisateur_textBox);
            this.DoubleBuffered = true;
            this.Name = "Connexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomUtilisateur_textBox;
        private System.Windows.Forms.TextBox motDePasse_textBox;
        private System.Windows.Forms.Button seConnecter_button;
    }
}
