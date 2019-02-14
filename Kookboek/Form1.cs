using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kookboek
{
    public partial class Form1 : Form
    {
        private readonly ReceptRepository repo = new ReceptRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadHomeScreen();
        }

        private void loadHomeScreen()
        {
            var recepten = repo.GetRecepten().ToList();

            for (int i = 0; i < 9; i++)
            {
                GroupBox receptBox = (GroupBox)this.Controls.Find("recept" + (i + 1), true)[0];

                if (recepten.Count <= i)
                {
                    receptBox.Visible = false;
                }
                else
                {
                    var recept = recepten[i];
                    receptBox.Text = recept.Naam;

                    PictureBox picRecept = (PictureBox)receptBox.Controls.Find("pictureBox" + (i + 1), true)[0];
                    picRecept.ImageLocation = recept.ImageUrl;

                    picRecept.Click += new EventHandler((obj, args) =>
                    {
                        //Recept openen
                    });
                }
            }
        }

        private void receptToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoekReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
