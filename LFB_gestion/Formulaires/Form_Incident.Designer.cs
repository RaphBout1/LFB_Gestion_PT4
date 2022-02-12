namespace LFB_gestion.Formulaires
{
    partial class Form_Incident
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
            this.statutCheckBox = new System.Windows.Forms.CheckBox();
            this.clientsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.emplacementsListBox = new System.Windows.Forms.CheckedListBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.validationBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(77, 49);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(312, 96);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // statutCheckBox
            // 
            this.statutCheckBox.AutoSize = true;
            this.statutCheckBox.Location = new System.Drawing.Point(77, 166);
            this.statutCheckBox.Name = "statutCheckBox";
            this.statutCheckBox.Size = new System.Drawing.Size(74, 21);
            this.statutCheckBox.TabIndex = 1;
            this.statutCheckBox.Text = "Résolu";
            this.statutCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientsCheckListBox
            // 
            this.clientsCheckListBox.FormattingEnabled = true;
            this.clientsCheckListBox.Location = new System.Drawing.Point(77, 225);
            this.clientsCheckListBox.Name = "clientsCheckListBox";
            this.clientsCheckListBox.Size = new System.Drawing.Size(312, 55);
            this.clientsCheckListBox.TabIndex = 2;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(74, 205);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client :";
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.Location = new System.Drawing.Point(77, 318);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.Size = new System.Drawing.Size(312, 55);
            this.emplacementsListBox.TabIndex = 4;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(74, 298);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(101, 17);
            this.emplacementLabel.TabIndex = 5;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // validationBouton
            // 
            this.validationBouton.Location = new System.Drawing.Point(177, 396);
            this.validationBouton.Name = "validationBouton";
            this.validationBouton.Size = new System.Drawing.Size(96, 42);
            this.validationBouton.TabIndex = 6;
            this.validationBouton.Text = "Valider";
            this.validationBouton.UseVisualStyleBackColor = true;
            this.validationBouton.Click += new System.EventHandler(this.validationBouton_Click);
            // 
            // Form_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.validationBouton);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientsCheckListBox);
            this.Controls.Add(this.statutCheckBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "Form_Incident";
            this.Text = "Form_Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox statutCheckBox;
        private System.Windows.Forms.CheckedListBox clientsCheckListBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.CheckedListBox emplacementsListBox;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Button validationBouton;
    }
}