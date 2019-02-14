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
    public partial class AddBereiding : Form
    {
        public Bereiding Bereiding;

        public AddBereiding(Bereiding bereiding)
        {
            InitializeComponent();

            this.Bereiding = bereiding;
        }

        private void AddBereiding_Load(object sender, EventArgs e)
        {
            lblStap.Text = (Bereiding.Volgorde + 1) + ")";
            if (Bereiding.Omschrijving != null)
            {
                txtBereiding.Text = Bereiding.Omschrijving;
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Bereiding.Omschrijving = txtBereiding.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
