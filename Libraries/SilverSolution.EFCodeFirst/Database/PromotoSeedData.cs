using SilverSolution.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;

namespace SilverSolution.EFCodeFirst.Database
{
    public class PromotoSeedData : DropCreateDatabaseIfModelChanges<SilverSolutionContext>
    {

        protected override void Seed(SilverSolutionContext context)
        {

            initSeed(context);

            base.Seed(context);
        }


        public static void initSeed(SilverSolutionContext context)
        {
            //GetCategory()
            //    .ForEach(p => context.SiteCategory.Add(p));
            //context.Commit();
        }



        private static List<Category> GetCategory()
        {
            return new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Kat1"

                },
                    new Category
                {
                    Id = 2,
                    Name = "Kat2"

                    },


                     new Category
                {
                    Id = 3,
                    Name = "Kat3"


                     },
                      new Category
                {
                    Id = 4,
                    Name = "Kat4"


                      },


            };
        }

    }
}
