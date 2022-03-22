﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            //Remplir la première ligne du dataGrid avec la location comme désignaiton
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
            row.Cells[0].Value = "Location de l'emplacement" + emplacementTextBox.Text + " du " + débutTextBox.Text + " au " + finTextBox.Text;
            TimeSpan temps = réservation.fin - réservation.début;
            double jours = temps.TotalDays;
            double somme = 50 * jours; //On dit qu'un jour coûte 50€
            row.Cells[1].Value = somme + " €";
            dataGridView.Rows.Add(row);

            calculer();
        }

        /// <summary>
        /// Calcule et met à jour les valeurs des montants ht tva ttc
        /// </summary>
        private void calculer()
        {
            double ht = 0;
            double tva = 0;
            //somme ht de toutes les désignations
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!isLastRow(row))
                {
                    string[] tab = row.Cells[1].Value.ToString().Split(' ');
                    try
                    {
                        ht += double.Parse(tab[0]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Conversion impossible du montant : " + row.Cells[1].Value.ToString());
                    }
                }
            }
            totalHtTextBox.Text = ht.ToString();
            //Établir le montant tva
            try
            {
                tva = ht + (ht * double.Parse(tvaComboBox.SelectedItem.ToString()) / 100);
                tvaTextBox.Text = tva.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible de convertir la valeur de tva en un numéro");
            }
            ttcLabel.Text = (ht + tva).ToString();
            régléTextBox.Text = ttcLabel.Text;
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
        /// Récupére le dernier numéro de facture dans la bd et incrémente
        /// </summary>
        /// <returns>renvoie le numéro de la dernière facture +1</returns>
        private int numFacture()
        {
            int numFacture = 0;
            SqlCommand cmd = new SqlCommand("select count(*) from facture", connexion);
            try
            {
                connexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                numFacture = reader.GetInt32(0) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return numFacture;
        }

        /// <summary>
        /// Savoir si la facture est un acompte ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acompteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acompteCheckBox.Checked)
            {
                acompteCheckBox.Text = "Facture d'acompte";
            }
            else
            {
                acompteCheckBox.Text = "Facture";
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
            string outFile = Environment.CurrentDirectory + "/facture.pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();

            //Palette de couleurs
            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor red = BaseColor.RED;
            BaseColor gris = new BaseColor(240, 240, 240);
            BaseColor blanc = new BaseColor(255, 255, 255);
            BaseColor noir = BaseColor.BLACK;
            //Fonts
            Font titre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
            Font titreRed = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, red);
            Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, 1, blanc);
            Font normal = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, 1, noir);


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

            //Afficher le total

            doc.Add(table);
            #endregion

            doc.Close();
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

        /// <summary>
        /// Actualise les calucls des montants ht tva ttc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                calculer();
            }
        }
    }
}
