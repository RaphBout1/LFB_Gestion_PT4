
namespace LFB_gestion.Interfaces
{
    partial class Interface_Reservations
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
            this.ajouter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.Location = new System.Drawing.Point(219, 20);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(39, 55);
            this.clientsPanel.Size = new System.Drawing.Size(718, 387);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(671, 24);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(75, 23);
            this.ajouter_button.TabIndex = 8;
            this.ajouter_button.Text = "+";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // Interface_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.ajouter_button);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(614, 488);
            this.Name = "Interface_Reservations";
            this.Text = "Interface_Reservations";
            this.Controls.SetChildIndex(this.clientsPanel, 0);
            this.Controls.SetChildIndex(this.nomModuleLabel, 0);
            this.Controls.SetChildIndex(this.ajouter_button, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter_button;
    }
}