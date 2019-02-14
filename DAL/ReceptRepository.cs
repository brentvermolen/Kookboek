using DAL.EF;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceptRepository
    {
        private KookboekContext ctx;

        public ReceptRepository()
        {
            ctx = new KookboekContext();
        }

        public IEnumerable<Recept> GetRecepten()
        {
            return ctx.Recepten;
        }
    }
}
