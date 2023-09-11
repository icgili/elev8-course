using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Infrastructure.OrganizationRepository _organizationRepository;
        private readonly IMemoryCache _cache;

        public IndexModel(Infrastructure.OrganizationRepository organizationRepository, IMemoryCache cache, ILogger<IndexModel> logger)
        {
            _organizationRepository = organizationRepository;
            _cache = cache;
            _logger = logger;
        }

        public List<Models.Organization> Organizations { get; private set; }
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; } = 20;
        public int TotalPages { get; private set; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;

        public async Task OnGet(int pageNumber = 1, int pageSize = 20)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;

            var cacheKey = $"OrganizationsPage_{pageNumber}_Size_{pageSize}";

            if (!_cache.TryGetValue(cacheKey, out List<Models.Organization> cachedOrganizations))
            {
                cachedOrganizations = await _organizationRepository.GetOrganizationsAsync(pageNumber, pageSize);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10) // Cache for 10 minutes
                };
                _cache.Set(cacheKey, cachedOrganizations, cacheEntryOptions);
            }

            Organizations = cachedOrganizations;

            var totalRecords = await _organizationRepository.GetTotalOrganizationCountAsync();
            TotalPages = (int)System.Math.Ceiling((double)totalRecords / pageSize);
        }
    }
}
