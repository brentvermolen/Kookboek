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
    public partial class ReceptBekijken : Form
    {
        public Recept recept;

        public ReceptBekijken(Recept recept)
        {
            InitializeComponent();

            this.recept = recept;
        }

        private void ReceptBekijken_Load(object sender, EventArgs e)
        {
            VulDialoog(recept);
        }

        private void VulDialoog(Recept recept)
        {
            lblNaam.Text = recept.Naam;
            this.Text = recept.Naam + " - " + recept.AantalPersonen + "personen - " + recept.DuurInMinuten + "min.";

            lblOmschrijving.Text = recept.Omschrijving;
            nudAantalPersonen.Value = recept.AantalPersonen;
            lblDuur.Text = recept.DuurInMinuten + " min.";
            picRecept.ImageLocation = recept.ImageUrl;

            lblIngrediënten.InsertIngrediënten(recept.Ingrediënten);
            lblBereiding.InsertBereiding(recept.Bereiding);

            VulTags(recept);
        }

        private void VulTags(Recept recept)
        {
            grpTags.Controls.Clear();

            int startX = 6;
            int y = 16;

            foreach (var tag in recept.Tags)
            {
                LinkLabel linkLabel = new LinkLabel()
                {
                    Text = tag.Naam,
                    AutoSize = true,
                    Location = new Point(startX, y)
                };

                linkLabel.Click += new EventHandler((obj, args) =>
                {
                    MessageBox.Show(tag.Naam);
                    //Lijst met usages tonen en ook clickable maken --> bij klik VulRecept doen
                });

                grpTags.Controls.Add(linkLabel);

                startX += linkLabel.Width;
            }
        }

        private void nudAantalPersonen_ValueChanged(object sender, EventArgs e)
        {
            double multiplier = (double)nudAantalPersonen.Value / recept.AantalPersonen;
            lblIngrediënten.InsertIngrediënten(recept.Ingrediënten, multiplier);
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBewerk_Click(object sender, EventArgs e)
        {
            ReceptToevoegen receptToevoegen = new ReceptToevoegen(recept);
            this.Hide();
            if (receptToevoegen.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                recept = receptToevoegen.recept;
                VulDialoog(recept);
            }
        }
    }
}
