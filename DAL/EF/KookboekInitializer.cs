using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.EF
{
    public class KookboekInitializer : DropCreateDatabaseIfModelChanges<KookboekContext>
    {
        protected override void Seed(KookboekContext context)
        {
            InsertTags(context);
            context.SaveChanges();

            InsertTest(context);
            context.SaveChanges();
        }

        private void InsertTest(KookboekContext context)
        {
            Ingrediënt sjalot = new Ingrediënt()
            {
                Naam = "Sjalot"
            };
            Ingrediënt kraanwater = new Ingrediënt()
            {
                Naam = "Kraanwater"
            };

            context.Ingrediënten.Add(sjalot);
            context.Ingrediënten.Add(kraanwater);

            Bereiding deel1 = new Bereiding()
            {
                Volgorde = 0,
                Omschrijving = "Snijd de sjalot"
            };
            Bereiding deel2 = new Bereiding()
            {
                Volgorde = 1,
                Omschrijving = "Snijd het brood"
            };

            List<Bereiding> bereiding = new List<Bereiding>();
            bereiding.Add(deel1);
            bereiding.Add(deel2);

            List<IngrediëntEenheid> ingrediënten = new List<IngrediëntEenheid>();
            ingrediënten.Add(new IngrediëntEenheid() { Ingrediënt = sjalot, Aantal = 1, Eenheid = Eenheid.Aantal });
            ingrediënten.Add(new IngrediëntEenheid() { Ingrediënt = kraanwater, Aantal = 150, Eenheid = Eenheid.Milliliter });

            List<Tag> tags = new List<Tag>();
            tags.Add(new Tag { Naam = "Soep" });
            tags.Add(context.Tags.Find("Vis"));

            Recept recept1 = new Recept()
            {
                Naam = "Bouillabaisse",
                Omschrijving = "Franse vissoep",
                ImageUrl = "https://img.static-rmg.be/a/food/image/q75/w640/h400/2666/gebakken-zeetong-met-pasta.jpg",
                AantalPersonen = 1,
                DuurInMinuten = 20,
                Ingrediënten = ingrediënten,
                Bereiding = bereiding,
                Tags = tags
            };

            context.Recepten.Add(recept1);
        }

        private void InsertTags(KookboekContext context)
        {
            context.Tags.Add(new Tag { Naam = "Vlees" });
            context.Tags.Add(new Tag { Naam = "Vis" });
            context.Tags.Add(new Tag { Naam = "Wok" });
            context.Tags.Add(new Tag { Naam = "Dessert" });
            context.Tags.Add(new Tag { Naam = "Voorgerecht" });
            context.Tags.Add(new Tag { Naam = "Hoofdgerecht" });
            context.Tags.Add(new Tag { Naam = "Apperitief" });
            context.Tags.Add(new Tag { Naam = "Drankje" });
        }
    }
}