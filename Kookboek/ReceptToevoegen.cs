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
    public partial class ReceptToevoegen : Form
    {
        public Recept recept;
        private List<IngrediëntEenheid> ingrediënten;
        private List<Bereiding> bereiding;

        private bool edit;

        public ReceptToevoegen(Recept recept = null)
        {
            InitializeComponent();

            this.recept = recept;
        }

        private void ReceptToevoegen_Load(object sender, EventArgs e)
        {
            if (recept != null)
            {
                edit = true;

                txtTitel.Text = recept.Naam;
                txtOmschrijving.Text = recept.Omschrijving;
                txtImageUrl.Text = recept.ImageUrl;
                picRecept.ImageLocation = recept.ImageUrl;
                nudAantalPersonen.Value = recept.AantalPersonen;
                nudDuur.Value = recept.DuurInMinuten;

                ingrediënten = recept.Ingrediënten;
                bereiding = recept.Bereiding;

                lblIngrediënten.InsertIngrediënten(ingrediënten);
                lblBereiding.InsertBereiding(bereiding);
            }
            else
            {
                edit = false;

                ingrediënten = new List<IngrediëntEenheid>();
                bereiding = new List<Bereiding>();
            }
        }

        private void txtImageUrl_Leave(object sender, EventArgs e)
        {
            picRecept.ImageLocation = txtImageUrl.Text;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            List<Tag> tags = new List<Tag>();

            recept = new Recept()
            {
                Naam = txtTitel.Text,
                Omschrijving = txtOmschrijving.Text,
                AantalPersonen = (int)nudAantalPersonen.Value,
                DuurInMinuten = (int)nudDuur.Value,
                Tags = tags,
                ImageUrl = txtImageUrl.Text
            };

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnAddBereiding_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIngrediënt_Click(object sender, EventArgs e)
        {

        }
    }
}
