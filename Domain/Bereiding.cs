using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Bereiding
    {
        [Key, Column(Order = 0)]
        public int ReceptID { get; set; }
        [Key, Column(Order = 1)]
        public int Volgorde { get; set; }
        public string Omschrijving { get; set; }

        public override string ToString()
        {
            return (Volgorde + 1) + ") " + Omschrijving;
        }
    }
}