using iTextSharp.text;
using iTextSharp.text.pdf;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Facture : Form
    {
        public Entite_Reservation réservation;

        private double totalHt;

        private SqlConnection connexion = Outils.Connexion();

        public Form_Facture(Entite_Reservation réservation)
        {
            this.réservation = réservation;
            InitializeComponent();
            string[] tab = new string[] { "5.5", "10", "20" };
            tvaComboBox.Items.AddRange(tab);
            tvaComboBox.SelectedIndex = 1;
            remplirDonnées();
        }

        #region Evenements
        /// <summary>
        /// Savoir si la facture est un acompte ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acompteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acompteCheckBox.Checked)
            {
                factureLabel.Text = "Facture d'acompte";
                numFactureTextBox.Text += "A";
                acompteLabel.Enabled = false;
                acompteTextBox.Visible = false;
                calculer();
            }
            else
            {
                factureLabel.Text = "Facture";
                numFactureTextBox.Text = réservation.id.ToString();
                acompteLabel.Enabled = true;
                acompteTextBox.Visible = true;
                calculer();
            }
        }

        /// <summary>
        /// Génération du pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerButton_Click(object sender, EventArgs e)
        {
            //Création du document
            string outFile = "";
            if (!acompteCheckBox.Checked)
            {
                outFile = Environment.CurrentDirectory + "/Facture n°" + numFacture().ToString() + ".pdf";
            }
            else
            {
                outFile = Environment.CurrentDirectory + "/Facture d'acompte n°" + numFacture().ToString() + "A.pdf";
            }

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();

            #region Colors & Fonts
            //Palette de couleurs
            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor red = BaseColor.RED;
            BaseColor gris = new BaseColor(240, 240, 240);
            BaseColor blanc = new BaseColor(255, 255, 255);
            BaseColor noir = BaseColor.BLACK;
            BaseColor gold = new BaseColor(255, 215, 0);
            //Fonts
            Font titre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
            Font titreRed = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, red);
            Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, 1, blanc);
            Font policeTotalBlanc = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, 1, blanc);
            Font policeTotalNoir = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, 1, noir);
            Font policeTotalGold = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, 1, gold);
            Font normal = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, 1, noir);
            #endregion

            //Page
            //Titre
            Paragraph facture = new Paragraph(factureLabel.Text + "\n\n", titre);
            facture.Alignment = Element.ALIGN_CENTER;

            Paragraph num = addParagraph("N°" + numFactureTextBox.Text, normal);
            Paragraph date = addParagraph("Date " + dateTextBox.Text, normal);
            num.Alignment = Element.ALIGN_RIGHT;
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(facture);
            doc.Add(num);
            doc.Add(date);

            #region Données entreprise
            List<Paragraph> tabE = new List<Paragraph>();
            tabE.Add(addParagraph(CampingName.Text, titre));
            tabE.Add(addParagraph(adresseLabel.Text, normal));
            tabE.Add(addParagraph(villeLabel.Text, normal));
            tabE.Add(addParagraph(telLabel.Text, normal));
            tabE.Add(addParagraph(mailLabel.Text, normal));
            tabE.Add(addParagraph(siretLabel.Text, normal));

            foreach (Paragraph p in tabE)
            {
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);
            }
            #endregion

            #region Données client
            List<Paragraph> tabCl = new List<Paragraph>();
            tabCl.Add(addParagraph(clientTextBox.Text, titreRed));
            tabCl.Add(addParagraph(adresseTextBox.Text, normal));
            tabCl.Add(addParagraph(codePostalTextBox.Text, normal));
            tabCl.Add(addParagraph(villeTextBox.Text, normal));
            tabCl.Add(addParagraph(telTextBox.Text, normal));
            tabCl.Add(addParagraph(mailTextBox.Text, normal));
            tabCl.Add(new Paragraph("\n"));

            foreach (Paragraph p in tabCl)
            {
                p.Alignment = Element.ALIGN_RIGHT;
                doc.Add(p);
            }
            #endregion

            #region Désignations
            //Construction du tableau
            PdfPTable table = new PdfPTable(2);
            table.SetWidthPercentage(new float[] { 75f, 25f }, doc.PageSize); //Pourcentage de largeur pourles colonnes
            table.WidthPercentage = 100; //Occupation du tableau dans le pdf
            //La colonne désignations
            PdfPCell desCell = new PdfPCell(new Phrase("Désignation", policeTh));
            desCell.BackgroundColor = blue;
            desCell.Padding = 7;
            desCell.BorderColor = blue;
            table.AddCell(desCell);
            //La colonne montant ht
            PdfPCell montantCell = new PdfPCell(new Phrase("Montant HT", policeTh));
            montantCell.BackgroundColor = blue;
            montantCell.Padding = 7;
            montantCell.BorderColor = blue;
            table.AddCell(montantCell);

            //Ajouter les lignes du dataGridView dans le pdf
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!isLastRow(row))
                {
                    if (row.Cells[0].Value != null || row.Cells[1].Value != null)
                    {
                        addCellTab(row.Cells[0].Value.ToString(), normal, gris, table);
                        addCellTab(row.Cells[1].Value.ToString(), normal, gris, table);
                    }
                    else
                    {
                        MessageBox.Show("Toutes les colonnes doivent être remplies");
                    }
                }
            }
            doc.Add(table);
            doc.Add(new Paragraph("\n"));
            #endregion

            #region Total
            //Afficher le total
            PdfPTable total = new PdfPTable(2);
            total.WidthPercentage = 30;
            total.HorizontalAlignment = Element.ALIGN_RIGHT;
            //Ligne 1
            //Colonne 1
            PdfPCell cell1 = new PdfPCell(new Phrase("Total HT", policeTotalBlanc));
            cell1.BackgroundColor = blue;
            cell1.BorderColor = blanc;
            total.AddCell(cell1);
            //Colonne 2
            PdfPCell cell11 = new PdfPCell(new Phrase(totalHtTextBox.Text + " €", policeTotalNoir));
            cell11.BackgroundColor = gris;
            cell11.BorderColor = blanc;
            total.AddCell(cell11);
            //Ligne2
            //Colonne 1
            PdfPCell cell2 = new PdfPCell(new Phrase("Tva", policeTotalBlanc));
            cell2.BackgroundColor = blue;
            cell2.BorderColor = blanc;
            total.AddCell(cell2);
            //Colonne 2
            PdfPCell cell21 = new PdfPCell(new Phrase(tvaTextBox.Text + " €", policeTotalNoir));
            cell21.BackgroundColor = gris;
            cell21.BorderColor = blanc;
            total.AddCell(cell21);
            //Ligne3
            //Colonne 1
            PdfPCell cell3 = new PdfPCell(new Phrase("Total TTC", policeTotalBlanc));
            cell3.BackgroundColor = blue;
            cell3.BorderColor = blanc;
            total.AddCell(cell3);
            //Colonne 2
            PdfPCell cell31 = new PdfPCell(new Phrase(ttcLabel.Text + " €", policeTotalNoir));
            cell31.BackgroundColor = gris;
            cell31.BorderColor = blanc;
            total.AddCell(cell31);
            //Ligne pour l'acompte
            if (!acompteCheckBox.Checked)
            {
                //Colonne 1
                PdfPCell cell411 = new PdfPCell(new Phrase("Acompte", policeTotalBlanc));
                cell411.BackgroundColor = blue;
                cell411.BorderColor = blanc;
                total.AddCell(cell411);
                //Colonne 2
                PdfPCell cell412 = new PdfPCell(new Phrase(acompteTextBox.Text + " €", policeTotalNoir));
                cell412.BackgroundColor = gris;
                cell412.BorderColor = blanc;
                total.AddCell(cell412);
            }
            //Ligne4
            //Colonne 1
            PdfPCell cell4 = new PdfPCell(new Phrase("Réglé", policeTotalGold));
            cell4.BackgroundColor = blue;
            cell4.BorderColor = blanc;
            total.AddCell(cell4);
            //Colonne 2
            PdfPCell cell41 = new PdfPCell(new Phrase(ttcLabel.Text + " €", policeTotalNoir));
            cell41.BackgroundColor = gris;
            cell41.BorderColor = blanc;
            total.AddCell(cell41);

            doc.Add(total);
            #endregion

            doc.Close();
        }

        /// <summary>
        /// Actualise les calucls des montants ht tva ttc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView.Rows[e.RowIndex].Cells[1].Value != null && !dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString().Contains("€"))
                {
                    dataGridView.Rows[e.RowIndex].Cells[1].Value += " €";
                }
                calculer();
            }
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Instancie les variables nécessaires pour remplir ensuite le form Facture
        /// </summary>
        private void remplirDonnées()
        {
            numFactureTextBox.Text = numFacture().ToString();

            dateTextBox.Text = date();

            Entite_Client leClient = client();

            clientTextBox.Text = leClient.ToString();
            adresseTextBox.Text = leClient.adresse;
            codePostalTextBox.Text = leClient.codePostal;
            villeTextBox.Text = leClient.ville;
            telTextBox.Text = leClient.tel;
            mailTextBox.Text = leClient.mail;

            débutTextBox.Text = réservation.début.ToString("dd/MM/yyyy");
            finTextBox.Text = réservation.fin.ToString("dd/MM/yyyy");

            emplacementTextBox.Text = réservation.emplacement.ToString();

            //Aller chercher la description de l'incident
            connexion.Open();
            string desc = "";
            string query = "select incident.description " +
                            "from incident " +
                            "inner join reservation on incident.id_reservation = reservation.id " +
                            "where reservation.id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", réservation.id);
            DbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    incidentsListBox.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                incidentsListBox.Items.Add("Pas d'incidents");
            }
            reader.Close();
            connexion.Close();

            //Remplir la première ligne du dataGrid avec la location comme désignaiton
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
            row.Cells[0].Value = "Location de l'emplacement" + emplacementTextBox.Text + " du " + débutTextBox.Text + " au " + finTextBox.Text;
            TimeSpan temps = réservation.fin - réservation.début;
            double jours = temps.TotalDays;
            double somme = 50 * jours; //On dit qu'un jour coûte 50€
            totalHt = somme;
            row.Cells[1].Value = somme + " €";
            dataGridView.Rows.Add(row);

            calculer();
        }

        /// <summary>
        /// Calcule et met à jour les valeurs des montants ht tva ttc
        /// </summary>
        private void calculer()
        {
            totalHt = 0;
            double tva = 0;
            //somme ht de toutes les désignations
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!isLastRow(row) && row.Cells[1].Value != null)
                {
                    string[] tab = row.Cells[1].Value.ToString().Split(' ');
                    try
                    {
                        totalHt += double.Parse(tab[0]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Conversion impossible du montant : " + row.Cells[1].Value.ToString());
                    }
                }
            }

            // Remplir total Ht, tva, ttc, acompte, réglé dans cet ordre
            totalHtTextBox.Text = totalHt.ToString();

            //Établir le montant tva
            try
            {
                tva = totalHt * double.Parse(tvaComboBox.SelectedItem.ToString()) / 100;
                tvaTextBox.Text = tva.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible de convertir la valeur de tva en un numéro");
            }

            //Remplir ttc
            double ttc = totalHt + tva;
            ttcLabel.Text = ttc.ToString();

            //Remplir acompte
            double acompte = 30 * ttc / 100;
            acompteTextBox.Text = acompte.ToString();

            //remplir le montant réglé
            double reste = 70 * ttc / 100;
            if (acompteCheckBox.Checked)
            {
                régléTextBox.Text = acompte.ToString();
            }
            else
            {
                régléTextBox.Text = reste.ToString();
            }
        }

        /// <summary>
        /// Retourne un string de la date actuelle
        /// </summary>
        /// <returns></returns>
        private string date()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Retourne lentité client selon l'idClient
        /// </summary>
        /// <returns></returns>
        private Entite_Client client()
        {
            return Outils.findClient(réservation.idClient);
        }

        /// <summary>
        /// Le numéro de facture est le même que le numéro de la réservation
        /// </summary>
        /// <returns>renvoie le numéro de la facture</returns>
        private int numFacture()
        {
            return réservation.id;
        }

        /// <summary>
        /// Ajoute une cellule dans un tableau
        /// </summary>
        /// <param name="s">le texte à mettre deans la cellule</param>
        /// <param name="f">la fonte pour le texte</param>
        /// <param name="c">une couleur</param>
        /// <param name="t">le tableau</param>
        private void addCellTab(string s, Font f, BaseColor c, PdfPTable t)
        {
            PdfPCell cell = new PdfPCell(new Phrase(s));
            cell.BackgroundColor = c;
            cell.Padding = 7;
            cell.BorderColor = new BaseColor(240, 240, 240);
            t.AddCell(cell);
        }

        /// <summary>
        /// Créer un nouveau paragraphe pour le pdf
        /// </summary>
        /// <param name="s">le texte à mettre dans le paragraphe</param>
        /// <param name="font">la font pour le paragraphe</param>
        /// <returns>renvoie un paragraphe</returns>
        private Paragraph addParagraph(string s, Font font)
        {
            return new Paragraph(s + "\n", font);
        }

        /// <summary>
        /// Vérifie si c'est la dernière ligne car la dernière ligne d'un dataGridView est toujours vide
        /// </summary>
        /// <param name="row">la ligne courante</param>
        /// <returns></returns>
        private bool isLastRow(DataGridViewRow row)
        {
            return (row.Index == dataGridView.Rows.Count - 1);
        }
        #endregion
    }
}
