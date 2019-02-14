using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Recept
    {
        [Key]
        public int ID { get; set; }
        public string Naam { get; set; }
        public string ImageUrl { get; set; }
        public string Omschrijving { get; set; }
        public int AantalPersonen { get; set; }
        public int DuurInMinuten { get; set; }
        public virtual List<IngrediëntEenheid> Ingrediënten { get; set; }
        public virtual List<Bereiding> Bereiding { get; set; }

        public virtual List<Tag> Tags { get; set; }

        public override string ToString()
        {
            return Naam;
        }

        public string BereidingToString()
        {
            string retValue = "";

            foreach(var bereiding in Bereiding)
            {
                retValue += bereiding.ToString() + Environment.NewLine;
            }

            return retValue;
        }

        public string IngrediëntToString()
        {
            string retValue = "";

            foreach(var ingrediënt in Ingrediënten)
            {
                retValue += ingrediënt.ToString() + Environment.NewLine;
            }

            return retValue;
        }
    }
}
