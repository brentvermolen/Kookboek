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

namespace Kookboek.Dialogs
{
    public partial class AddIngrediënt : Form
    {
        public IngrediëntEenheid Ingrediënt { get; set; }

        private readonly Repository repo = new Repository();

        private List<Ingrediënt> Ingrediënten = new List<Ingrediënt>();
        private List<Ingrediënt> DataSource = new List<Ingrediënt>();

        public AddIngrediënt()
        {
            InitializeComponent();
        }

        private void AddIngrediënt_Load(object sender, EventArgs e)
        {
            Ingrediënten = repo.GetIngrediënten().ToList();
            DataSource = Ingrediënten;

            lstIngrediënten.DataSource = DataSource;
            lstIngrediënten.DisplayMember = "Naam";
            lstIngrediënten.ValueMember = "ID";

            lstEenheden.DataSource = Enum.GetValues(typeof(Eenheid));
        }

        private void txtIngrediënt_TextChanged(object sender, EventArgs e)
        {
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            DataSource = Ingrediënten.Where(i => i.Naam.ToLower().Contains(txtIngrediënt.Text.ToLower())).ToList();
            lstIngrediënten.DataSource = DataSource;

            if (DataSource.Count == 0)
            {
                btnNieuwToevoegen.Visible = true;
            }
            else
            {
                btnNieuwToevoegen.Visible = false;
            }
        }

        private void btnNieuwToevoegen_Click(object sender, EventArgs e)
        {
            RequestString requestString = new RequestString("Nieuw Ingrediënt", txtIngrediënt.Text);

            if (requestString.ShowDialog() == DialogResult.OK)
            {
                string nieuwIngrediënt = requestString.Tekst;

                Ingrediënt ingrediënt = repo.GetIngrediënt(nieuwIngrediënt);
                if (ingrediënt == null)
                {
                    ingrediënt = new Ingrediënt() { Naam = nieuwIngrediënt };
                    ingrediënt.Opslaan();

                    Ingrediënten.Add(ingrediënt);
                    DataSource.Add(ingrediënt);

                    UpdateDataSource();
                }
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Eenheid eenheid;
            Enum.TryParse<Eenheid>(lstEenheden.SelectedValue.ToString(), out eenheid);

            double aantal;
            double.TryParse(txtAantal.Text, out aantal);

            if (aantal == 0)
            {
                MessageBox.Show("Controleer het aantal\n\nAantal kan niet 0 zijn");
                return;
            }

            Ingrediënt = new IngrediëntEenheid()
            {
                Ingrediënt = repo.GetIngrediënt((int)lstIngrediënten.SelectedValue),
                Eenheid = eenheid,
                Aantal = aantal
            };

            DialogResult = DialogResult.OK;
        }
    }
}
