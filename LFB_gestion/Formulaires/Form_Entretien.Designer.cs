namespace LFB_gestion.Formulaires
{
    partial class Form_Entretien
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
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.validationBouton = new System.Windows.Forms.Button();
            this.utilisateurListBox = new System.Windows.Forms.ListBox();
            this.emplacementsListBox = new System.Windows.Forms.ListBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(54, 250);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(235, 79);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.employeeLabel.Location = new System.Drawing.Point(52, 11);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(82, 20);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "Employé  :";
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.BackColor = System.Drawing.Color.Transparent;
            this.emplacementLabel.CausesValidation = false;
            this.emplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emplacementLabel.Location = new System.Drawing.Point(52, 122);
            this.emplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(115, 20);
            this.emplacementLabel.TabIndex = 5;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // validationBouton
            // 
            this.validationBouton.BackColor = System.Drawing.Color.Transparent;
            this.validationBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.validationBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validationBouton.FlatAppearance.BorderSize = 0;
            this.validationBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validationBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.validationBouton.Location = new System.Drawing.Point(133, 361);
            this.validationBouton.Margin = new System.Windows.Forms.Padding(2);
            this.validationBouton.Name = "validationBouton";
            this.validationBouton.Size = new System.Drawing.Size(72, 34);
            this.validationBouton.TabIndex = 6;
            this.validationBouton.Text = "Valider";
            this.validationBouton.UseVisualStyleBackColor = true;
            // 
            // utilisateurListBox
            // 
            this.utilisateurListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utilisateurListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.utilisateurListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.utilisateurListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateurListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.utilisateurListBox.FormattingEnabled = true;
            this.utilisateurListBox.ItemHeight = 17;
            this.utilisateurListBox.Location = new System.Drawing.Point(54, 33);
            this.utilisateurListBox.Margin = new System.Windows.Forms.Padding(2);
            this.utilisateurListBox.Name = "utilisateurListBox";
            this.utilisateurListBox.Size = new System.Drawing.Size(234, 51);
            this.utilisateurListBox.TabIndex = 7;
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.emplacementsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emplacementsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.ItemHeight = 17;
            this.emplacementsListBox.Location = new System.Drawing.Point(54, 144);
            this.emplacementsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.Size = new System.Drawing.Size(234, 51);
            this.emplacementsListBox.TabIndex = 8;
            // 
            // labelDesc
            // 
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.labelDesc.Location = new System.Drawing.Point(50, 228);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(128, 19);
            this.labelDesc.TabIndex = 9;
            this.labelDesc.Text = "Description :";
            // 
            // Form_Entretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 404);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.utilisateurListBox);
            this.Controls.Add(this.validationBouton);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Entretien";
            this.Text = "Nouvel Entretien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Button validationBouton;
        private System.Windows.Forms.ListBox utilisateurListBox;
        private System.Windows.Forms.ListBox emplacementsListBox;
        private System.Windows.Forms.Label labelDesc;
    }
}