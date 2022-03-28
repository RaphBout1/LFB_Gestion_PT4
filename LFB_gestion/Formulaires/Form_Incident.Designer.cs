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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Incident));
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.validationBouton = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientlabel = new System.Windows.Forms.Label();
            this.débutLabel = new System.Windows.Forms.Label();
            this.emplacementlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(54, 161);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(235, 79);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
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
            this.validationBouton.Location = new System.Drawing.Point(133, 272);
            this.validationBouton.Margin = new System.Windows.Forms.Padding(2);
            this.validationBouton.Name = "validationBouton";
            this.validationBouton.Size = new System.Drawing.Size(72, 34);
            this.validationBouton.TabIndex = 6;
            this.validationBouton.Text = "Valider";
            this.validationBouton.UseVisualStyleBackColor = true;
            this.validationBouton.Click += new System.EventHandler(this.validationBouton_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.labelDesc.Location = new System.Drawing.Point(50, 139);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(128, 19);
            this.labelDesc.TabIndex = 9;
            this.labelDesc.Text = "Description :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(50, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Réservation du ";
            // 
            // clientlabel
            // 
            this.clientlabel.BackColor = System.Drawing.Color.Transparent;
            this.clientlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.clientlabel.Location = new System.Drawing.Point(50, 9);
            this.clientlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientlabel.Name = "clientlabel";
            this.clientlabel.Size = new System.Drawing.Size(128, 19);
            this.clientlabel.TabIndex = 12;
            this.clientlabel.Text = "Client";
            // 
            // débutLabel
            // 
            this.débutLabel.BackColor = System.Drawing.Color.Transparent;
            this.débutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.débutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.débutLabel.Location = new System.Drawing.Point(170, 42);
            this.débutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.débutLabel.Name = "débutLabel";
            this.débutLabel.Size = new System.Drawing.Size(128, 19);
            this.débutLabel.TabIndex = 13;
            this.débutLabel.Text = "Début";
            // 
            // emplacementlabel
            // 
            this.emplacementlabel.BackColor = System.Drawing.Color.Transparent;
            this.emplacementlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emplacementlabel.Location = new System.Drawing.Point(50, 72);
            this.emplacementlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emplacementlabel.Name = "emplacementlabel";
            this.emplacementlabel.Size = new System.Drawing.Size(128, 19);
            this.emplacementlabel.TabIndex = 14;
            this.emplacementlabel.Text = "Emplacement";
            // 
            // Form_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 324);
            this.Controls.Add(this.emplacementlabel);
            this.Controls.Add(this.débutLabel);
            this.Controls.Add(this.clientlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.validationBouton);
            this.Controls.Add(this.descriptionTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Incident";
            this.Text = "Nouvel Incident";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button validationBouton;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clientlabel;
        private System.Windows.Forms.Label débutLabel;
        private System.Windows.Forms.Label emplacementlabel;
    }
}