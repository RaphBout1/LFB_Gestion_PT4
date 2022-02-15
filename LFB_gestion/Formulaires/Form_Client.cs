using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
        }

        private void nomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void prenomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public static bool EmailEstValide(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void creerBouton_Click(object sender, EventArgs e)
        {
            if (EmailEstValide(emailTextBox.Text) && !clientDejaPresent())
            {
                creationDuClient();
                emailTextBox.Text = "";
                nomTextBox.Text = "";
                prenomTextBox.Text = "";
                this.Refresh();
                MessageBox.Show("ajout du nouveau client dans la base");
            } else
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size; 
                nonValideLabel.Text = "Adresse mail non valide";
                nonValideLabel.Location = new Point(emailTextBox.Location.X, (emailTextBox.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
                emailTextBox.Text = "";
                nomTextBox.Text = "";
                prenomTextBox.Text = "";
                this.Refresh();
            }
        }

        /* MANIPULATION DE LA BASE */

        /*
         * Méthode permettant la création du client dans la base
         * A FAIRE
         */
        private void creationDuClient()
        {
       
        }

        /*
         * Méthode permettant de vérifier si un client est déjà présent dans la base.
         * A FAIRE
         */
        private bool clientDejaPresent()
        {
            return false;
        }
    }
}
