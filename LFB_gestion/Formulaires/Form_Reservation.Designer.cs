namespace LFB_gestion.Formulaires
{
    partial class Form_Reservation
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
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.emplacementsListBox = new System.Windows.Forms.ListBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dateDebutCalendrier = new System.Windows.Forms.MonthCalendar();
            this.dateFinCalendrier = new System.Windows.Forms.MonthCalendar();
            this.dateDebutLabel = new System.Windows.Forms.Label();
            this.dateFinLabel = new System.Windows.Forms.Label();
            this.validerBouton = new System.Windows.Forms.Button();
            this.nouveauClientBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(57, 288);
            this.clientsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(235, 56);
            this.clientsListBox.TabIndex = 8;
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.Location = new System.Drawing.Point(57, 383);
            this.emplacementsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.Size = new System.Drawing.Size(235, 56);
            this.emplacementsListBox.TabIndex = 9;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(55, 366);
            this.emplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(77, 13);
            this.emplacementLabel.TabIndex = 10;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(55, 272);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(39, 13);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Client :";
            // 
            // dateDebutCalendrier
            // 
            this.dateDebutCalendrier.Location = new System.Drawing.Point(26, 63);
            this.dateDebutCalendrier.Margin = new System.Windows.Forms.Padding(7);
            this.dateDebutCalendrier.MaxSelectionCount = 365;
            this.dateDebutCalendrier.Name = "dateDebutCalendrier";
            this.dateDebutCalendrier.TabIndex = 12;
            // 
            // dateFinCalendrier
            // 
            this.dateFinCalendrier.Location = new System.Drawing.Point(266, 63);
            this.dateFinCalendrier.Margin = new System.Windows.Forms.Padding(7);
            this.dateFinCalendrier.Name = "dateFinCalendrier";
            this.dateFinCalendrier.TabIndex = 13;
            // 
            // dateDebutLabel
            // 
            this.dateDebutLabel.AutoSize = true;
            this.dateDebutLabel.Location = new System.Drawing.Point(23, 27);
            this.dateDebutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDebutLabel.Name = "dateDebutLabel";
            this.dateDebutLabel.Size = new System.Drawing.Size(81, 13);
            this.dateDebutLabel.TabIndex = 14;
            this.dateDebutLabel.Text = "Date de début :";
            // 
            // dateFinLabel
            // 
            this.dateFinLabel.AutoSize = true;
            this.dateFinLabel.Location = new System.Drawing.Point(263, 27);
            this.dateFinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateFinLabel.Name = "dateFinLabel";
            this.dateFinLabel.Size = new System.Drawing.Size(65, 13);
            this.dateFinLabel.TabIndex = 15;
            this.dateFinLabel.Text = "Date de fin :";
            // 
            // validerBouton
            // 
            this.validerBouton.Location = new System.Drawing.Point(170, 499);
            this.validerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(114, 46);
            this.validerBouton.TabIndex = 17;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // nouveauClientBouton
            // 
            this.nouveauClientBouton.Location = new System.Drawing.Point(311, 305);
            this.nouveauClientBouton.Margin = new System.Windows.Forms.Padding(2);
            this.nouveauClientBouton.Name = "nouveauClientBouton";
            this.nouveauClientBouton.Size = new System.Drawing.Size(107, 27);
            this.nouveauClientBouton.TabIndex = 18;
            this.nouveauClientBouton.Text = "NouveauClient";
            this.nouveauClientBouton.UseVisualStyleBackColor = true;
            this.nouveauClientBouton.Click += new System.EventHandler(this.nouveauClientBouton_Click);
            // 
            // Form_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 609);
            this.Controls.Add(this.nouveauClientBouton);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.dateFinLabel);
            this.Controls.Add(this.dateDebutLabel);
            this.Controls.Add(this.dateFinCalendrier);
            this.Controls.Add(this.dateDebutCalendrier);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.clientsListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Reservation";
            this.Text = "Form_Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.ListBox emplacementsListBox;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.MonthCalendar dateDebutCalendrier;
        private System.Windows.Forms.MonthCalendar dateFinCalendrier;
        private System.Windows.Forms.Label dateDebutLabel;
        private System.Windows.Forms.Label dateFinLabel;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.Button nouveauClientBouton;
    }
}