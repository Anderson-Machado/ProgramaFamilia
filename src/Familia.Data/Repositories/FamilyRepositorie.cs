using Familia.Data.Context;
using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Data.Repositories
{
    public class FamilyRepositorie : IFamilyRepositorie
    {
        private readonly DatabaseContext _db;
        public FamilyRepositorie(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Family>> GeFamilia()
        {
            return await _db.Family.Include(x => x.Dependents).ToListAsync();
        }
    }
}
