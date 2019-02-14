using DAL.EF;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository
    {
        private KookboekContext ctx;

        public Repository()
        {
            ctx = new KookboekContext();
        }

        public IEnumerable<Recept> GetRecepten(OrderBy orderBy = OrderBy.Naam, int Top = 20)
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

        public bool AddRecept(Recept recept)
        {
            try
            {
                ctx.Recepten.Add(recept);
                ctx.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool EditRecept(Recept recept)
        {
            try
            {                
                ctx.Entry(recept).State = System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();
            } 
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool DeleteRecept(Recept recept)
        {
            try
            {
                ctx.Recepten.Remove(recept);
                ctx.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public Recept GetRecept(int ID)
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

        public IEnumerable<Ingrediënt> GetIngrediënten(OrderBy orderBy = OrderBy.Naam)
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

        public Ingrediënt GetIngrediënt(string naam)
        {
            return ctx.Ingrediënten.Where(i => i.Naam.ToLower().Equals(naam.ToLower())).FirstOrDefault();
        }

        public Ingrediënt GetIngrediënt(int ID)
        {
            return ctx.Ingrediënten.Find(ID);
        }

        public bool AddIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ctx.Ingrediënten.Add(ingrediënt);
                ctx.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool EditIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ctx.Entry<Ingrediënt>(ingrediënt).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool DeleteIngrediënt(Ingrediënt ingrediënt)
        {
            try
            {
                ctx.Ingrediënten.Remove(ingrediënt);
                ctx.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
