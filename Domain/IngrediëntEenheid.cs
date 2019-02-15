using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class IngrediëntEenheid
    {
        [Key, Column(Order = 0)]
        public int ReceptID { get; set; }
        [Key, Column(Order = 1)]
        public int IngredientID { get; set; }

        public virtual Recept Recept { get; set; }
        public virtual Ingrediënt Ingrediënt { get; set; }

        public double Aantal { get; set; }
        public Eenheid Eenheid { get; set; }

        [NotMapped]
        public string Volledig
        {
            get
            {
                try
                {
                    return Aantal + Eenheid.ToAfkorting() + " " + Ingrediënt.ToString();
                }
                catch { return ""; }
            }
        }

        public override string ToString()
        {
            return Volledig;
        }
    }
}