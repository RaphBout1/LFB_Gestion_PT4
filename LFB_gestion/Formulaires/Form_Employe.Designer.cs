namespace LFB_gestion.Formulaires
{
    partial class Form_Employe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prénom_TextBox = new System.Windows.Forms.TextBox();
            this.prénom_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.adresse_label = new System.Windows.Forms.Label();
            this.adresse_textBox = new System.Windows.Forms.TextBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mail_label = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.créer_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mdp_label = new System.Windows.Forms.Label();
            this.mdp_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginValue_label = new System.Windows.Forms.Label();
            this.admin_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // prénom_TextBox
            // 
            this.prénom_TextBox.Location = new System.Drawing.Point(364, 77);
            this.prénom_TextBox.Name = "prénom_TextBox";
            this.prénom_TextBox.Size = new System.Drawing.Size(100, 20);
            this.prénom_TextBox.TabIndex = 0;
            this.prénom_TextBox.TextChanged += new System.EventHandler(this.prénom_TextBox_TextChanged);
            // 
            // prénom_label
            // 
            this.prénom_label.AutoSize = true;
            this.prénom_label.Location = new System.Drawing.Point(303, 80);
            this.prénom_label.Name = "prénom_label";
            this.prénom_label.Size = new System.Drawing.Size(43, 13);
            this.prénom_label.TabIndex = 1;
            this.prénom_label.Text = "Prénom";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Location = new System.Drawing.Point(303, 106);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(29, 13);
            this.nom_label.TabIndex = 3;
            this.nom_label.Text = "Nom";
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(364, 103);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(100, 20);
            this.nom_textBox.TabIndex = 2;
            this.nom_textBox.TextChanged += new System.EventHandler(this.nom_textBox_TextChanged);
            // 
            // adresse_label
            // 
            this.adresse_label.AutoSize = true;
            this.adresse_label.Location = new System.Drawing.Point(303, 132);
            this.adresse_label.Name = "adresse_label";
            this.adresse_label.Size = new System.Drawing.Size(45, 13);
            this.adresse_label.TabIndex = 5;
            this.adresse_label.Text = "Adresse";
            // 
            // adresse_textBox
            // 
            this.adresse_textBox.Location = new System.Drawing.Point(364, 129);
            this.adresse_textBox.Name = "adresse_textBox";
            this.adresse_textBox.Size = new System.Drawing.Size(100, 20);
            this.adresse_textBox.TabIndex = 4;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Location = new System.Drawing.Point(303, 158);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(22, 13);
            this.tel_label.TabIndex = 7;
            this.tel_label.Text = "Tel";
            // 
            // tel_textBox
            // 
            this.tel_textBox.Location = new System.Drawing.Point(364, 155);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(100, 20);
            this.tel_textBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Location = new System.Drawing.Point(303, 184);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(26, 13);
            this.mail_label.TabIndex = 11;
            this.mail_label.Text = "Mail";
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(364, 181);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(100, 20);
            this.mail_textBox.TabIndex = 10;
            this.mail_textBox.TextChanged += new System.EventHandler(this.mail_textBox_TextChanged);
            // 
            // créer_button
            // 
            this.créer_button.Location = new System.Drawing.Point(333, 293);
            this.créer_button.Name = "créer_button";
            this.créer_button.Size = new System.Drawing.Size(75, 23);
            this.créer_button.TabIndex = 12;
            this.créer_button.Text = "Créer";
            this.créer_button.UseVisualStyleBackColor = true;
            this.créer_button.Click += new System.EventHandler(this.créer_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(303, 210);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(33, 13);
            this.login_label.TabIndex = 15;
            this.login_label.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // mdp_label
            // 
            this.mdp_label.AutoSize = true;
            this.mdp_label.Location = new System.Drawing.Point(303, 236);
            this.mdp_label.Name = "mdp_label";
            this.mdp_label.Size = new System.Drawing.Size(53, 13);
            this.mdp_label.TabIndex = 18;
            this.mdp_label.Text = "Password";
            // 
            // mdp_textBox
            // 
            this.mdp_textBox.Location = new System.Drawing.Point(364, 233);
            this.mdp_textBox.Name = "mdp_textBox";
            this.mdp_textBox.Size = new System.Drawing.Size(100, 20);
            this.mdp_textBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 16;
            // 
            // loginValue_label
            // 
            this.loginValue_label.AutoSize = true;
            this.loginValue_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginValue_label.Location = new System.Drawing.Point(361, 210);
            this.loginValue_label.Name = "loginValue_label";
            this.loginValue_label.Size = new System.Drawing.Size(29, 13);
            this.loginValue_label.TabIndex = 19;
            this.loginValue_label.Text = "login";
            // 
            // admin_checkBox
            // 
            this.admin_checkBox.AutoSize = true;
            this.admin_checkBox.Location = new System.Drawing.Point(333, 270);
            this.admin_checkBox.Name = "admin_checkBox";
            this.admin_checkBox.Size = new System.Drawing.Size(91, 17);
            this.admin_checkBox.TabIndex = 20;
            this.admin_checkBox.Text = "administrateur";
            this.admin_checkBox.UseVisualStyleBackColor = true;
            this.admin_checkBox.CheckedChanged += new System.EventHandler(this.admin_checkBox_CheckedChanged);
            // 
            // Form_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_checkBox);
            this.Controls.Add(this.loginValue_label);
            this.Controls.Add(this.mdp_label);
            this.Controls.Add(this.mdp_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.créer_button);
            this.Controls.Add(this.mail_label);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.tel_textBox);
            this.Controls.Add(this.adresse_label);
            this.Controls.Add(this.adresse_textBox);
            this.Controls.Add(this.nom_label);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.prénom_label);
            this.Controls.Add(this.prénom_TextBox);
            this.Name = "Form_Employe";
            this.Text = "Créer un nouvel utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prénom_TextBox;
        private System.Windows.Forms.Label prénom_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label adresse_label;
        private System.Windows.Forms.TextBox adresse_textBox;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Button créer_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mdp_label;
        private System.Windows.Forms.TextBox mdp_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label loginValue_label;
        private System.Windows.Forms.CheckBox admin_checkBox;
    }
}
