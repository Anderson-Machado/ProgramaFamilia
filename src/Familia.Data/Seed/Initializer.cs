using Familia.Data.Context;
using Familia.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Familia.Data.Seed
{
    public class Initializer
    {
        private readonly DatabaseContext _context;

        public Initializer(DatabaseContext context)
        {
            _context = context;
        }


        public void Initialize()
        {
            var fam = new Family()
            {

                Name = "Machado",
                Dependents = new List<Dependent>() { new Dependent() { Age = 22, Income = 1200 } },

            };

            var fam2 = new Family()
            {

                Name = "Continentino",
                Dependents = new List<Dependent>() { new Dependent() { Age = 22, Income = 600 },
                                                     new Dependent() { Age = 17, Income = 500 }
                },

            };

            var fam3 = new Family()
            {

                Name = "Badini",
                Dependents = new List<Dependent>() { new Dependent() { Age = 22, Income = 2200 },
                                                     new Dependent() { Age = 44, Income = 2200 }},

            };

            var fam4 = new Family()
            {

                Name = "Bernado",
                Dependents = new List<Dependent>() { new Dependent() { Age = 17, Income = 400 },
                                                     new Dependent() { Age = 15, Income = 300 }},

            };

            var listFamily = new List<Family>();
            listFamily.Add(fam);
            listFamily.Add(fam2);
            listFamily.Add(fam3);
            listFamily.Add(fam4);


            CreateInfo(listFamily);



        }
        private void CreateInfo(List<Family> family)
        {
            if (_context.Family.ToList().Count == 0)
            {
                _context.Family.AddRange(family);
                _context.SaveChanges();
            }
        }


    }
}
