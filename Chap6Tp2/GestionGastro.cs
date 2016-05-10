using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap6Tp2
{
    public partial class GestionGastro : Form
    {
        string entree;
        string plat;
        string dessert;
        

        public GestionGastro()
        {
            InitializeComponent();
        }

        private void btnAfficherChoix_Click(object sender, EventArgs e)
        {
            lblEntree.Text = "";
            lblPlat.Text = "";
            lblDessert.Text = "";
            string error = "";

            // Saisie du label entrée
            if (optEntree1.Checked == true)
            {
                entree = optEntree1.Text;
            }
            if (optEntree2.Checked == true)
            {
                entree = optEntree2.Text;
            }
            if (optEntree3.Checked == true)
            {
                entree = optEntree3.Text;
            }
            if (optEntree1.Checked == false && optEntree2.Checked == false && optEntree3.Checked == false)
            {
                error = error + "\n Veuillez saisir une entree";
            }

            // Saisie du label plat
            if(optPlats1.Checked == true)
            {
                plat = optPlats1.Text;
            }
            if(optPlats2.Checked == true)
            {
                plat = optPlats2.Text;
            }
            if(optPlats3.Checked == true)
            {
                plat = optPlats3.Text;
            }
            if (optPlats1.Checked == false && optPlats2.Checked == false && optPlats3.Checked == false)
            {
                error = error + "\n Veuillez saisir un plat";
            }

            // Saisie du label dessert
            if (optDessert1.Checked == true)
            {
                dessert = optDessert1.Text;
            }
            if (optDessert2.Checked == true)
            {
                dessert = optDessert2.Text;
            }
            if (optDessert3.Checked == true)
            {
                dessert = optDessert3.Text;
            }
            if (optDessert4.Checked == true)
            {
                dessert = optDessert4.Text;
            }
            if (optDessert1.Checked == false && optDessert2.Checked == false && optDessert3.Checked == false && optDessert4.Checked == false)
            {
                error = error + "\n Veuillez saisir un plat";
            }
            if (error != "")
            {
                MessageBox.Show(error, "Message d'erreur");
            }
            lblEntree.Text = entree;
            lblPlat.Text = plat;
            lblDessert.Text = dessert;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            lblEntree.Text = "";
            lblPlat.Text = "";
            lblDessert.Text = "";
            optEntree1.Checked = false;
            optEntree2.Checked = false;
            optEntree3.Checked = false;
            optPlats1.Checked = false;
            optPlats2.Checked = false;
            optPlats3.Checked = false;
            optDessert1.Checked = false;
            optDessert2.Checked = false;
            optDessert3.Checked = false;
            optDessert4.Checked = false;
            lblEntree.Text = "";
            lblPlat.Text = "";
            lblDessert.Text = "";
        }


    }
}
