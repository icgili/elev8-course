using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationList.Infrastructure
{
    public class OrganizationRepository
    {
        private readonly Context _context;

        public OrganizationRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Models.Organization>> GetOrganizationsAsync(int pageNumber, int pageSize)
        {
            return await _context.Organizations
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalOrganizationCountAsync()
        {
            return await _context.Organizations.CountAsync();
        }
    }
}
