using Customer.Common.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Customer.API.Helpers
{
    public interface ICombosHelper
    {
        Task<List<TypeStation>> GetComboTypeStationsAsync();

        Task<List<TypeStand>> GetComboTypeStandsAsync();

        Task<List<TypeSiteOwner>> GetComboTypeSiteOwnersAsync();

        Task<List<TypeOutdoorInstallation>> GetComboTypeOutdoorInstallationsAsync();

    }
}
