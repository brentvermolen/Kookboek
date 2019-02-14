using Domain;
using Kookboek.Dialogs;
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
        public Recept origineel;
        private List<IngrediëntEenheid> ingrediënten;
        private List<Bereiding> bereiding;

        private bool edit;

        public ReceptToevoegen(Recept recept = null)
        {
            InitializeComponent();

            this.recept = recept;
            this.origineel = recept;
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

            recept.Naam = txtTitel.Text;
            recept.Omschrijving = txtOmschrijving.Text;
            recept.AantalPersonen = (int)nudAantalPersonen.Value;
            recept.DuurInMinuten = (int)nudDuur.Value;
            recept.Ingrediënten = ingrediënten;
            recept.Bereiding = bereiding;
            recept.Tags = tags;
            recept.ImageUrl = txtImageUrl.Text;

            recept.Opslaan();
            DialogResult = DialogResult.OK;
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

            if (edit)
            {
                ReceptBekijken receptBekijken = new ReceptBekijken(origineel);
                receptBekijken.Show();
                this.Close();
            }
        }

        private void btnAddBereiding_Click(object sender, EventArgs e)
        {
            AddBereiding addBereiding = new AddBereiding(new Bereiding() { Volgorde = bereiding.Count });
            if (addBereiding.ShowDialog() == DialogResult.OK)
            {
                if (bereiding.Contains(addBereiding.Bereiding))
                {
                    bereiding.Remove(addBereiding.Bereiding);
                }

                bereiding.Add(addBereiding.Bereiding);
                lblBereiding.InsertBereiding(bereiding);
            }
        }

        private void btnAddIngrediënt_Click(object sender, EventArgs e)
        {
            AddIngrediënt addIngrediënt = new AddIngrediënt();
            if (addIngrediënt.ShowDialog() == DialogResult.OK)
            {
                if (ingrediënten.Contains(addIngrediënt.Ingrediënt))
                {
                    ingrediënten.Remove(addIngrediënt.Ingrediënt);
                }

                ingrediënten.Add(addIngrediënt.Ingrediënt);
                lblIngrediënten.InsertIngrediënten(ingrediënten);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                recept.Delete();
            }
        }
    }
}
