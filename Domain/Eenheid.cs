using System.Windows.Forms;

namespace Domain
{
    public enum Eenheid
    {
        Aantal,
        Milligram,
        Gram,
        Milliliter,
        Centiliter,
        Deciliter,
        Eetlepel,
        Koffielepel
    }

    public static class EenheidMethods
    {
        public static string ToAfkorting(this Eenheid eenheid)
        {
            switch (eenheid)
            {
                case Eenheid.Milligram:
                    return "mg";
                case Eenheid.Gram:
                    return "g";
                case Eenheid.Milliliter:
                    return "ml";
                case Eenheid.Centiliter:
                    return "cl";
                case Eenheid.Deciliter:
                    return "dl";
                case Eenheid.Eetlepel:
                    return "el";
                case Eenheid.Koffielepel:
                    return "kl";
                case Eenheid.Aantal:
                    return "";
                default:
                    return null;
            }
        }
    }
}