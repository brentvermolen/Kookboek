using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Ingrediënt
    {
        [Key]
        public int ID { get; set; }
        public string Naam { get; set; }

        public virtual List<IngrediëntEenheid> Usages { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}