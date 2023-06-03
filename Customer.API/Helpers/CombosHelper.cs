using Customer.API.Data;
using Customer.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TypeOutdoorInstallation>> GetComboTypeOutdoorInstallationsAsync()
        { 
            return await _context.TypeOutdoorInstallations.ToListAsync();
        }

        public async Task<List<TypeSiteOwner>> GetComboTypeSiteOwnersAsync()
        {
            return await _context.TypeSiteOwners.ToListAsync();
        }

        public async Task<List<TypeStand>> GetComboTypeStandsAsync()
        {
            return await _context.TypeStands.ToListAsync();
        }

        public async Task<List<TypeStation>> GetComboTypeStationsAsync()
        {
            return await _context.TypeStations.ToListAsync();
        }
    }
}