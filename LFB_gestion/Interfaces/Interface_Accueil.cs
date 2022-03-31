using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Accueil : Interface_Abstraite
    {

        public Interface_Accueil()
        {
            InitializeComponent();
            dataBase.refreshDataBase();
        }
    }
}
