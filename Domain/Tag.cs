using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Tag
    {
        [Key]
        public string Naam { get; set; }

        public List<Recept> Recepten { get; set; }
    }
}