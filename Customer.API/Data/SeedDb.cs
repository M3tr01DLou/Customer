using Customer.Common.Entities;
using Microsoft.AspNetCore.Routing;
using System;

namespace Customer.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckStatesAsync();
            await CheckTypeOutdoorInstallationAsync();
            await CheckTypeSiteOwnerAsync();
            await CheckTypeStandAsync();
            await CheckTypeStationAsync();
        }

        private async Task CheckStatesAsync()
        {
            if (!_context.States.Any())
            {
                _context.States.Add(new State { Status = "On Going", Active = true });
                _context.States.Add(new State { Status = "Finish", Active = true });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeOutdoorInstallationAsync()
        {
            if (!_context.TypeOutdoorInstallations.Any())
            {
                _context.TypeOutdoorInstallations.Add(new TypeOutdoorInstallation { Name = "Azotea" });
                _context.TypeOutdoorInstallations.Add(new TypeOutdoorInstallation { Name = "Torre" });
                _context.TypeOutdoorInstallations.Add(new TypeOutdoorInstallation { Name = "Suelo" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeSiteOwnerAsync()
        {
            if (!_context.TypeSiteOwners.Any())
            {
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "ORANGE" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "TME" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "VODAFONE" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "YOIGO" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "ABERTIS" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "AENA" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "ADIF" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "EL CORTE INGLÉS" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "OTRO(Indicar)" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "CELLNEX" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "TELXIUS" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "VANTAGE" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "AMERICAN TOWER ESPAÑA" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "TOTEM" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "TCLM" });
                _context.TypeSiteOwners.Add(new TypeSiteOwner { Name = "AXION" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeStationAsync()
        {
            if (!_context.TypeStations.Any())
            {
                _context.TypeStations.Add(new TypeStation { Name = "Indoor" });
                _context.TypeStations.Add(new TypeStation { Name = "Outdoor" });
                _context.TypeStations.Add(new TypeStation { Name = "Indoor/Outdoor" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeStandAsync()
        {
            if (!_context.TypeStands.Any())
            {
                _context.TypeStands.Add(new TypeStand { Name = "CAF01" });
                _context.TypeStands.Add(new TypeStand { Name = "CAF02" });
                _context.TypeStands.Add(new TypeStand { Name = "CAH01" });
                _context.TypeStands.Add(new TypeStand { Name = "CAH02" });
                _context.TypeStands.Add(new TypeStand { Name = "CAH03" });
                _context.TypeStands.Add(new TypeStand { Name = "CAH04" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM01" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM02" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM03" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM04" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM05" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM06" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM07" });
                _context.TypeStands.Add(new TypeStand { Name = "CAM08" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 10" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 12" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 17" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 5" });
                _context.TypeStands.Add(new TypeStand { Name = "ICSA fibra de vidiro" });
                _context.TypeStands.Add(new TypeStand { Name = "ISOPAGE Fibra de vidrio" });
                _context.TypeStands.Add(new TypeStand { Name = "ISOPAGE Metalica" });
                _context.TypeStands.Add(new TypeStand { Name = "SI - 5" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 15" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 7" });
                _context.TypeStands.Add(new TypeStand { Name = "EB - 30" });
                _context.TypeStands.Add(new TypeStand {Name = "OTROS(Indicar en observaciones)" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
