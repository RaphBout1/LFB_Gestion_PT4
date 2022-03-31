﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using System.Data.SqlClient;
using static LFB_gestion.Formulaires.Form_Client;

namespace TEST_LFB_gestion
{
    [TestClass]
    public class Outils_Tests
    {
        [TestMethod]
        public void testsChiffrage()
        {
            // On créé une chaine de caractères
            string s = "motdepasse";
            // On crypte la chaine de caractères
            string sCrypte = LFB_gestion.Outils.chiffrer(s);
            // On vérifie que la chaine de départ (s) est différente de sa version chiffré
            Assert.AreNotEqual(s, sCrypte);

            // On vérifie si le chiffrage fonctionne sur une chaine complexe
            string sComplexe = "aMoR78_@&é'==SSi, P";
            sCrypte = LFB_gestion.Outils.chiffrer(sComplexe);
            Assert.AreNotEqual(sComplexe, sCrypte);


        }

        [TestMethod]
        public void testsMailEstValide()
        {
            // Sur adresse mail valide
            // On créer plusieurs adresses mails valide
            string valide = "tonyStark@gmail.com";
            string valideAvecTiret = "tony-stark@gmail.com";
            string valideAvecPoint = "tony-stark@gmail.com";
            string valideAvecChiffre = "tony2-stark@gmail.com";
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valide));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecTiret));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecChiffre));
            Assert.IsTrue(LFB_gestion.Outils.mailEstValide(valideAvecPoint));

            // sur adresse mail invalide
            string nonValideAvecEspace = "tony stark@gmail.com";
            string nonValideSansArobase = "tonystarkgmail.com";
            string nonValideSansDomaine = "tonystark@gmail";
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecEspace));
            // Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecCaractereSpecial));
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideSansArobase));
            // Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideAvecTiretApresArobase));
            Assert.IsFalse(LFB_gestion.Outils.mailEstValide(nonValideSansDomaine));


        }
    }
}