using DAL.EF;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Repository
    {
        private static KookboekContext ctx = new KookboekContext();

        public static IEnumerable<Recept> GetRecepten(OrderBy orderBy = OrderBy.Naam, int Top = 20)
        {
            switch (orderBy)
            {
                case OrderBy.Toegevoegd:
                    return ctx.Recepten.OrderBy(r => r.ID).Take(Top);
                case OrderBy.ToegevoegdDesc:
                    return ctx.Recepten.OrderByDescending(r => r.ID).Take(Top);
                default:
                    return ctx.Recepten.OrderBy(r => r.Naam).Take(Top);
            }
        }

        public static Recept AddRecept(Recept recept)
        {
            try
            {
                recept = ctx.Recepten.Add(recept);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }

            return recept;
        }

        public static bool EditRecept(Recept recept)
        {
            try
            { 


                ctx.SaveChanges();
            } 
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static bool DeleteRecept(Recept recept)
        {
            try
            {
                ctx.Recepten.Remove(GetRecept(recept.ID));
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Recept GetRecept(int ID)
        {
            return ctx.Recepten.Find(ID);
        }

        //public IEnumerable<Ingrediënt> GetIngrediënten(OrderBy orderBy = OrderBy.Naam, int Top = 20)
        //{
        //    switch (orderBy)
        //    {
        //        default:
        //            return ctx.Ingrediënten.OrderBy(i => i.Naam).Take(Top);
        //        case OrderBy.Toegevoegd:
        //            return ctx.Ingrediënten.OrderBy(i => i.ID).Take(Top);
        //        case OrderBy.ToegevoegdDesc:
        //            return ctx.Ingrediënten.OrderByDescending(i => i.ID).Take(Top);
        //    }
        //}

        public static IEnumerable<Ingrediënt> GetIngrediënten(OrderBy orderBy = OrderBy.Naam)
        {
            switch (orderBy)
            {
                default:
                    return ctx.Ingrediënten.OrderBy(i => i.Naam);
                case OrderBy.Toegevoegd:
                    return ctx.Ingrediënten.OrderBy(i => i.ID);
                case OrderBy.ToegevoegdDesc:
                    return ctx.Ingrediënten.OrderByDescending(i => i.ID);
            }
        }

        public static Ingrediënt GetIngrediënt(string naam)
        {
            return ctx.Ingrediënten.Where(i => i.Naam.ToLower().Equals(naam.ToLower())).FirstOrDefault();
        }

        public static Ingrediënt GetIngrediënt(int ID)
        {
            return ctx.Ingrediënten.Find(ID);
        }

        public static Ingrediënt AddIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ingrediënt = ctx.Ingrediënten.Add(ingrediënt);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }

            return ingrediënt;
        }

        public static bool EditIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ctx.Entry<Ingrediënt>(ingrediënt).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Tag AddOrFindTag(string tag)
        {
            Tag t = ctx.Tags.Find(tag);

            if (t == null)
            {
                //t = ctx.Tags.Add(new Tag() { Naam = tag });
                t = new Tag() { Naam = tag };
            }

            return t;
        }

        public static bool DeleteIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ctx.Ingrediënten.Remove(ingrediënt);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
