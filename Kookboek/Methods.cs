using DAL;
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
        private static readonly Repository receptRepo = new Repository();
        private static readonly Repository ingrediëntRepo = new Repository();

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

        public static void InsertIngrediënten(this TextBox label, List<IngrediëntEenheid> ingrediënten, double multiplier)
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

            foreach(var bereiding in bereidingen.OrderBy(b => b.Volgorde))
            {
                label.Text += bereiding.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }

        public static void Opslaan(this Recept recept)
        {
            if (receptRepo.GetRecept(recept.ID) == null)
            {
                receptRepo.AddRecept(recept);
            }
            else
            {
                receptRepo.EditRecept(recept);
            }
        }

        public static void Delete(this Recept recept)
        {
            receptRepo.DeleteRecept(recept);
        }

        public static void Edit(this Recept recept)
        {
            receptRepo.EditRecept(recept);
        }

        public static void Opslaan(this Ingrediënt ingrediënt)
        {
            ingrediëntRepo.AddIngrediënt(ingrediënt);
        }

        public static void Delete(this Ingrediënt ingrediënt)
        {
            ingrediëntRepo.DeleteIngrediënt(ingrediënt);
        }

        public static void Edit(this Ingrediënt ingrediënt)
        {
            ingrediëntRepo.EditIngrediënt(ingrediënt);
        }
    }
}
