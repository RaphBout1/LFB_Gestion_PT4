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
            this.nomUtilisateur_textBox.Location = new System.Drawing.Point(255, 159);
            this.nomUtilisateur_textBox.Name = "nomUtilisateur_textBox";
            this.nomUtilisateur_textBox.Size = new System.Drawing.Size(218, 20);
            this.nomUtilisateur_textBox.TabIndex = 0;
            // 
            // motDePasse_textBox
            // 
            this.motDePasse_textBox.Location = new System.Drawing.Point(255, 223);
            this.motDePasse_textBox.Name = "motDePasse_textBox";
            this.motDePasse_textBox.PasswordChar = '•';
            this.motDePasse_textBox.Size = new System.Drawing.Size(218, 20);
            this.motDePasse_textBox.TabIndex = 1;
            // 
            // nomUtilisateur_label
            // 
            this.nomUtilisateur_label.AutoSize = true;
            this.nomUtilisateur_label.Location = new System.Drawing.Point(252, 143);
            this.nomUtilisateur_label.Name = "nomUtilisateur_label";
            this.nomUtilisateur_label.Size = new System.Drawing.Size(84, 13);
            this.nomUtilisateur_label.TabIndex = 2;
            this.nomUtilisateur_label.Text = "Nom d\'utilisateur";
            // 
            // motDePasse_label
            // 
            this.motDePasse_label.AutoSize = true;
            this.motDePasse_label.Location = new System.Drawing.Point(252, 207);
            this.motDePasse_label.Name = "motDePasse_label";
            this.motDePasse_label.Size = new System.Drawing.Size(71, 13);
            this.motDePasse_label.TabIndex = 3;
            this.motDePasse_label.Text = "Mot de passe";
            // 
            // connexion_label
            // 
            this.connexion_label.AutoSize = true;
            this.connexion_label.Location = new System.Drawing.Point(12, 9);
            this.connexion_label.Name = "connexion_label";
            this.connexion_label.Size = new System.Drawing.Size(102, 13);
            this.connexion_label.TabIndex = 4;
            this.connexion_label.Text = "Écran de connexion";
            // 
            // seConnecter_button
            // 
            this.seConnecter_button.Location = new System.Drawing.Point(318, 280);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seConnecter_button);
            this.Controls.Add(this.connexion_label);
            this.Controls.Add(this.motDePasse_label);
            this.Controls.Add(this.nomUtilisateur_label);
            this.Controls.Add(this.motDePasse_textBox);
            this.Controls.Add(this.nomUtilisateur_textBox);
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
