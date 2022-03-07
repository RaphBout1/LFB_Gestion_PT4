namespace LFB_gestion.Interfaces
{
    partial class Interface_Utilisateurs
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
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.Location = new System.Drawing.Point(220, 20);
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.Click += new System.EventHandler(this.rechercheBouton_Click);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(40, 55);
            this.clientsPanel.Size = new System.Drawing.Size(720, 387);
            // 
            // Interface_Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Interface_Utilisateurs";
            this.Text = "Interface_Utilisateurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
