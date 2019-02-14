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
    public partial class Home : Form
    {
        private readonly ReceptRepository repo = new ReceptRepository();
        private List<GroupBox> receptBoxen = new List<GroupBox>();

        public Home()
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
                PictureBox picRecept = (PictureBox)receptBox.Controls.Find("pictureBox" + (i + 1), true)[0];
                receptBox.Tag = picRecept;

                if (recepten.Count <= i)
                {
                    receptBox.Visible = false;
                }
                else
                {
                    var recept = recepten[i];
                    receptBox.VulMetRecept(recept);

                    picRecept.Click += new EventHandler((obj, args) =>
                    {
                        ReceptBekijken frmReceptBekijken = new ReceptBekijken(recept);
                        frmReceptBekijken.Show();
                    });
                }

                receptBoxen.Add(receptBox);
            }
        }

        private void receptToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceptToevoegen frmReceptToevoegen = new ReceptToevoegen();
            if (frmReceptToevoegen.ShowDialog() == DialogResult.OK && frmReceptToevoegen.recept != null)
            {
                var prevRecept = frmReceptToevoegen.recept;

                foreach (var box in receptBoxen)
                {
                    if (prevRecept != null)
                    {
                        box.Visible = true;

                        var curRecept = prevRecept;
                        prevRecept = box.GetRecept();
                        box.VulMetRecept(curRecept);
                    }
                }
            }
        }

        private void zoekReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
