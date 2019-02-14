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
    public partial class RequestString : Form
    {
        public string Tekst { get; set; }

        public RequestString(string titel, string voor = "")
        {
            InitializeComponent();

            this.Text = titel;
            txtString.Text = voor;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Tekst = txtString.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
