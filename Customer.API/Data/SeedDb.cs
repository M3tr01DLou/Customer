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
            await CheckTipoEstadoDisenoAsync();
            await CheckTipoInstalacionExteriorAsync();
            await CheckTipoPropiertarioEmplazamientoAsync();
            await CheckTipoCasetaAsync();
			await CheckTipoEstacionAsync();
			await CheckTipoOKAsync();
			await CheckTipoTonelajeAsync();
			await CheckTipoGruaAsync();
			await CheckTipoLlaveAsync();
			await CheckTipoAccesoAsync();
            await CheckTipoRangoHorarioAsync();
            await CheckTipoSiNoAsync();
        }

        private async Task CheckTipoEstadoDisenoAsync()
        {
            if (!_context.TipoEstadoDiseno.Any())
			{
				_context.TipoEstadoDiseno.Add(new TipoEstadoDiseno { Estado = string.Empty, Activo = true });
				_context.TipoEstadoDiseno.Add(new TipoEstadoDiseno { Estado = "On Going", Activo = true });
                _context.TipoEstadoDiseno.Add(new TipoEstadoDiseno { Estado = "Finish", Activo = true });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoInstalacionExteriorAsync()
        {
            if (!_context.TipoInstalacionExterior.Any())
			{
				_context.TipoInstalacionExterior.Add(new TipoInstalacionExterior { Nombre = string.Empty });
				_context.TipoInstalacionExterior.Add(new TipoInstalacionExterior { Nombre = "Azotea" });
                _context.TipoInstalacionExterior.Add(new TipoInstalacionExterior { Nombre = "Torre" });
                _context.TipoInstalacionExterior.Add(new TipoInstalacionExterior { Nombre = "Suelo" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoPropiertarioEmplazamientoAsync()
        {
            if (!_context.TipoPropiertarioEmplazamiento.Any())
			{
				_context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = string.Empty });
				_context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "ORANGE" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "TME" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "VODAFONE" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "YOIGO" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "ABERTIS" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "AENA" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "ADIF" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "EL CORTE INGLÉS" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "OTRO(Indicar)" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "CELLNEX" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "TELXIUS" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "VANTAGE" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "AMERICAN TOWER ESPAÑA" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "TOTEM" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "TCLM" });
                _context.TipoPropiertarioEmplazamiento.Add(new TipoPropiertarioEmplazamiento { Nombre = "AXION" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoEstacionAsync()
        {
            if (!_context.TipoEstacion.Any())
			{
				_context.TipoEstacion.Add(new TipoEstacion { Nombre = string.Empty });
				_context.TipoEstacion.Add(new TipoEstacion { Nombre = "Indoor" });
                _context.TipoEstacion.Add(new TipoEstacion { Nombre = "Outdoor" });
                _context.TipoEstacion.Add(new TipoEstacion { Nombre = "Indoor/Outdoor" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoCasetaAsync()
        {
            if (!_context.TipoCaseta.Any())
			{
				_context.TipoCaseta.Add(new TipoCaseta { Nombre = string.Empty });
				_context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAF01" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAF02" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAH01" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAH02" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAH03" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAH04" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM01" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM02" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM03" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM04" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM05" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM06" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM07" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "CAM08" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 10" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 12" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 17" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 5" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "ICSA fibra de vidiro" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "ISOPAGE Fibra de vidrio" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "ISOPAGE Metalica" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "SI - 5" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 15" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 7" });
                _context.TipoCaseta.Add(new TipoCaseta { Nombre = "EB - 30" });
                _context.TipoCaseta.Add(new TipoCaseta {Nombre = "OTROS(Indicar en observaciones)" });
                await _context.SaveChangesAsync();
            }
        }

		private async Task CheckTipoOKAsync()
		{
			if (!_context.TipoOK.Any())
			{
				_context.TipoOK.Add(new TipoOK { Nombre = string.Empty });
				_context.TipoOK.Add(new TipoOK { Nombre = "OK" });
				_context.TipoOK.Add(new TipoOK { Nombre = "No OK" });
				_context.TipoOK.Add(new TipoOK { Nombre = "NP" });
				await _context.SaveChangesAsync();
			}
		}

		private async Task CheckTipoTonelajeAsync()
		{
			if (!_context.TipoTonelaje.Any())
			{
				_context.TipoTonelaje.Add(new TipoTonelaje { Nombre = string.Empty });
				_context.TipoTonelaje.Add(new TipoTonelaje { Nombre = "40T" });
				_context.TipoTonelaje.Add(new TipoTonelaje { Nombre = "60T" });
				_context.TipoTonelaje.Add(new TipoTonelaje { Nombre = "80T" });
				await _context.SaveChangesAsync();
			}
		}

		private async Task CheckTipoGruaAsync()
		{
			if (!_context.TipoGrua.Any())
			{
				_context.TipoGrua.Add(new TipoGrua { Nombre = string.Empty });
				_context.TipoGrua.Add(new TipoGrua { Nombre = "Grúa" });
				_context.TipoGrua.Add(new TipoGrua { Nombre = "Grúa cesta" });
				await _context.SaveChangesAsync();
			}
		}

		private async Task CheckTipoLlaveAsync()
		{
			if (!_context.TipoLlave.Any())
			{
				_context.TipoLlave.Add(new TipoLlave { Nombre = string.Empty });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Abloy" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Locken" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Tarjeta TESA" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Otros" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "No Procede" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Tarjeta CT" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Propia del emplazamiento" });
				_context.TipoLlave.Add(new TipoLlave { Nombre = "Propias, solicitar acceso a TME" });
				await _context.SaveChangesAsync();
			}
		}

		private async Task CheckTipoAccesoAsync()
		{
			if (!_context.TipoAcceso.Any())
			{
				_context.TipoAcceso.Add(new TipoAcceso { Nombre = string.Empty });
				_context.TipoAcceso.Add(new TipoAcceso { Nombre = "Restringido" });
				_context.TipoAcceso.Add(new TipoAcceso { Nombre = "No restringido" });
				_context.TipoAcceso.Add(new TipoAcceso { Nombre = "Nocturno" });
				await _context.SaveChangesAsync();
			}
		}

		private async Task CheckTipoRangoHorarioAsync()
		{
			if (!_context.TipoRangoHorario.Any())
			{
				_context.TipoRangoHorario.Add(new TipoRangoHorario { Nombre = string.Empty });
				_context.TipoRangoHorario.Add(new TipoRangoHorario { Nombre = "24 horas" });
				_context.TipoRangoHorario.Add(new TipoRangoHorario { Nombre = "Lunes a viernes" });
				_context.TipoRangoHorario.Add(new TipoRangoHorario { Nombre = "Horario de oficinas" });
				await _context.SaveChangesAsync();
			}
		}

        private async Task CheckTipoSiNoAsync()
        {
            if (!_context.TipoSiNo.Any())
            {
                _context.TipoSiNo.Add(new TipoSiNo { Nombre = string.Empty });
                _context.TipoSiNo.Add(new TipoSiNo { Nombre = "Si" });
                _context.TipoSiNo.Add(new TipoSiNo { Nombre = "No" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
