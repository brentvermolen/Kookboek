using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static BindingList<T> Copy<T>(this List<T> list)
        {
            BindingList<T> l = new BindingList<T>();

            if (list == null || list.Count == 0)
            {
                return l;
            }

            foreach(var t in list)
            {
                l.Add(t);
            }

            return l;
        }

        public static void Opslaan(this Recept recept)
        {
            Recept receptDb = Repository.GetRecept(recept.ID);
            if (receptDb != null)
            {
                receptDb.Delete();
            }
            
            recept = Repository.AddRecept(recept);
        }

        public static void Update(this Recept recept, Recept receptUpdate)
        {
            recept.Naam = receptUpdate.Naam;
            recept.Omschrijving = receptUpdate.Naam;
            recept.AantalPersonen = receptUpdate.AantalPersonen;
            recept.DuurInMinuten = receptUpdate.DuurInMinuten;
            recept.Ingrediënten = receptUpdate.Ingrediënten;
            recept.Bereiding = receptUpdate.Bereiding;
            recept.ImageUrl = receptUpdate.ImageUrl;
            recept.Tags = receptUpdate.Tags;

            recept.Edit();
        }

        public static void Delete(this Recept recept)
        {
            Repository.DeleteRecept(recept);
        }

        public static void Edit(this Recept recept)
        {
            Repository.EditRecept(recept);
        }

        public static void Opslaan(this Ingrediënt ingrediënt)
        {
            Repository.AddIngrediënt(ingrediënt);
        }

        public static void Delete(this Ingrediënt ingrediënt)
        {
            Repository.DeleteIngrediënt(ingrediënt);
        }

        public static void Edit(this Ingrediënt ingrediënt)
        {
            Repository.EditIngrediënt(ingrediënt);
        }

        public static Tag FindTag(this string tag)
        {
            return Repository.AddOrFindTag(tag);
        }
    }
}
