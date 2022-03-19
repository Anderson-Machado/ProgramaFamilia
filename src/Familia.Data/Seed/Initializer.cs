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
                Dependents = new List<Dependent>() { new Dependent() { Age = 22, IdFamily = 1, Income = 900 } },

            };

            var fam2 = new Family()
            {
                
                Name = "Continentino",
                Dependents = new List<Dependent>() { new Dependent() { Age = 22, IdFamily = 2, Income = 2200 },
                              new Dependent() { Age = 19, IdFamily = 2, Income = 500 }
                },

            };

            var listFamily = new List<Family>();
            listFamily.Add(fam);
            listFamily.Add(fam2);

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
