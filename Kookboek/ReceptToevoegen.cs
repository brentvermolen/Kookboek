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

        BindingList<IngrediëntEenheid> ingrediënten;
        BindingList<Bereiding> bereiding;

        private bool edit;

        public ReceptToevoegen(Recept recept = null)
        {
            InitializeComponent();
            
            this.origineel = recept;
            this.recept = new Recept();
        }

        private void ReceptToevoegen_Load(object sender, EventArgs e)
        {
            if (origineel != null)
            {
                edit = true;

                this.Text = "Wijzig '" + origineel.Naam + "'";

                bereiding = origineel.Bereiding.Copy();
                ingrediënten = origineel.Ingrediënten.Copy();

                recept.ID = origineel.ID;
                txtTitel.Text = origineel.Naam;
                txtOmschrijving.Text = origineel.Omschrijving;
                txtImageUrl.Text = origineel.ImageUrl;
                picRecept.ImageLocation = origineel.ImageUrl;
                nudAantalPersonen.Value = origineel.AantalPersonen;
                nudDuur.Value = origineel.DuurInMinuten;

                foreach(var tag in origineel.Tags)
                {
                    txtTags.Text += tag.Naam + " ";
                }

                lstIngrediënten.DataSource = ingrediënten;
                lstBereiding.DataSource = bereiding;

                btnVerwijder.Enabled = true;
            }
            else
            {
                edit = false;

                bereiding = new BindingList<Bereiding>();
                ingrediënten = new BindingList<IngrediëntEenheid>();

                recept.Ingrediënten = new List<IngrediëntEenheid>();
                recept.Bereiding = new List<Bereiding>();

                btnVerwijder.Enabled = false;
            }

            lstBereiding.DisplayMember = "Volledig";
            lstBereiding.ValueMember = "Volgorde";
            lstBereiding.DataSource = bereiding;

            lstIngrediënten.DisplayMember = "Volledig";
            lstIngrediënten.ValueMember = "IngredientID";
            lstIngrediënten.DataSource = ingrediënten;
        }

        private void txtImageUrl_Leave(object sender, EventArgs e)
        {
            picRecept.ImageLocation = txtImageUrl.Text;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            List<Tag> tags = new List<Tag>();
            foreach(string tag in txtTags.Text.Split(' '))
            {
                if (!tag.Equals("") || !tag.Equals(" "))
                {
                    tags.Add(tag.FindTag());
                }
            }

            recept.Naam = txtTitel.Text;
            recept.Omschrijving = txtOmschrijving.Text;
            recept.AantalPersonen = (int)nudAantalPersonen.Value;
            recept.DuurInMinuten = (int)nudDuur.Value;
            recept.Ingrediënten = ingrediënten.ToList();
            recept.Bereiding = bereiding.ToList();
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
            }
        }

        private void btnAddIngrediënt_Click(object sender, EventArgs e)
        {
            AddIngrediënt addIngrediënt = new AddIngrediënt(new IngrediëntEenheid());
            if (addIngrediënt.ShowDialog() == DialogResult.OK)
            {
                if (ingrediënten.Contains(addIngrediënt.Ingrediënt))
                {
                    ingrediënten.Remove(addIngrediënt.Ingrediënt);
                }

                ingrediënten.Add(addIngrediënt.Ingrediënt);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                recept.Delete();
                DialogResult = DialogResult.No;
            }
        }

        private void lstBereiding_DoubleClick(object sender, EventArgs e)
        {
            AddBereiding editBereiding = new AddBereiding(bereiding[lstBereiding.SelectedIndex]);
            if (editBereiding.ShowDialog() == DialogResult.OK)
            {
                bereiding[lstBereiding.SelectedIndex] = editBereiding.Bereiding;
            }
        }

        private void lstIngrediënten_DoubleClick(object sender, EventArgs e)
        {
            AddIngrediënt editIngrediënt = new AddIngrediënt(ingrediënten[lstIngrediënten.SelectedIndex]);
            if (editIngrediënt.ShowDialog() == DialogResult.OK)
            {
                ingrediënten[lstIngrediënten.SelectedIndex] = editIngrediënt.Ingrediënt;
            }
        }
    }
}
