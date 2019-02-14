using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kookboek
{
    public static class Methods
    {
        public static void VulMetRecept(this GroupBox box, Recept recept)
        {
            box.Text = recept.Naam;

            ((PictureBox)box.Tag).ImageLocation = recept.ImageUrl;
            ((PictureBox)box.Tag).Tag = recept;
        }

        public static Recept GetRecept(this GroupBox box)
        {
            return (Recept)((PictureBox)box.Tag).Tag;
        }

        public static void InsertIngrediënten(this TextBox label, List<IngrediëntEenheid> ingrediënten)
        {
            label.Text = "";

            foreach(var ingrediënt in ingrediënten)
            {
                label.Text += ingrediënt.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }

        public static void InsertIngrediënten(this TextBox label, List<IngrediëntEenheid> ingrediënten, int multiplier)
        {
            label.Text = "";

            foreach (var ingrediënt in ingrediënten)
            {
                label.Text += (ingrediënt.Aantal * multiplier) + ingrediënt.Eenheid.ToAfkorting() + " " + ingrediënt.Ingrediënt.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }

        public static void InsertBereiding(this TextBox label, List<Bereiding> bereidingen)
        {
            label.Text = "";

            foreach(var bereiding in bereidingen)
            {
                label.Text += bereiding.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
