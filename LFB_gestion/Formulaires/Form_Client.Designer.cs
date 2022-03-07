namespace LFB_gestion.Formulaires
{
    partial class Form_Client
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
            this.creerBouton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creerBouton
            // 
            this.creerBouton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creerBouton.Location = new System.Drawing.Point(149, 259);
            this.creerBouton.Name = "creerBouton";
            this.creerBouton.Size = new System.Drawing.Size(75, 23);
            this.creerBouton.TabIndex = 3;
            this.creerBouton.Text = "Créer";
            this.creerBouton.UseVisualStyleBackColor = true;
            this.creerBouton.Click += new System.EventHandler(this.creerBouton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(135, 195);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(135, 90);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 0;
            this.prenomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prenomTextBox_KeyPress);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(135, 144);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 1;
            this.nomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomTextBox_KeyPress);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(133, 127);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(35, 13);
            this.nomLabel.TabIndex = 8;
            this.nomLabel.Text = "Nom :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(133, 73);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(49, 13);
            this.prenomLabel.TabIndex = 9;
            this.prenomLabel.Text = "Prénom :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(133, 178);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Adresse mail :";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 426);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.creerBouton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creerBouton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}