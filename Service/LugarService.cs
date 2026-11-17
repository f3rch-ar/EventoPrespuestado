using EventoPresupuestado.Dto;
using EventoPresupuestado.Model;
using EventoPresupuestado.Repository;
using EventoPresupuestado.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Service
{
    public class LugarService : BaseService
    {
        private readonly IRepository<Lugar> _lugarRepository;

        public LugarService()
        {
            _lugarRepository = LugarRepository.getInstance();
        }

        public void CreateLugar(LugarDto lugarDto)
        {
            compareLugar(lugarDto);

            string? rutaFinalImagen = GuardarImagenLocalmente(lugarDto.rutaImagen);

            Lugar lugarModel = new Lugar(
                lugarDto.nombreLugar,
                lugarDto.descripcionLugar,
                lugarDto.precioBase,
                lugarDto.cantMaxPersonas,
                rutaFinalImagen
            );
            _lugarRepository.Create(lugarModel);
        }

        private void compareLugar(LugarDto lugarDto)
        {
            List<LugarDto> lugaresExistentes = GetLugares();

            string nombreNuevoNormalizado = NormalizarTexto(lugarDto.nombreLugar);
            string descripcionNuevaNormalizada = NormalizarTexto(lugarDto.descripcionLugar);

            foreach (LugarDto existente in lugaresExistentes)
            {
                string nombreExistenteNormalizado = NormalizarTexto(existente.nombreLugar);
                string descripcionExistenteNormalizada = NormalizarTexto(existente.descripcionLugar);

                bool mismoNombre = nombreExistenteNormalizado.Equals(nombreNuevoNormalizado);
                bool mismaDescripcion = descripcionExistenteNormalizada.Equals(descripcionNuevaNormalizada);

                if ((mismoNombre || mismaDescripcion) && existente.Id != lugarDto.Id)
                {
                    if (mismoNombre)
                    {
                        throw new ArgumentException("Ya existe un salón o lugar registrado con ese nombre en el sistema.");
                    }
                    else
                    {
                        throw new ArgumentException("Ya existe un salón o lugar registrado con esa descripción en el sistema.");
                    }
                }
            }
        }

        public List<LugarDto> GetLugares()
        {
            return _lugarRepository.GetAlls()
                .Select(lugar => new LugarDto(
                    lugar.Id,
                    lugar.NombreLugar,
                    lugar.DescripcionLugar,
                    lugar.PrecioBase,
                    lugar.CantMaxPersonas,
                    lugar.Ocupado,
                    lugar.RutaImagen,
                    lugar.Activo
                )).ToList();
        }

        public List<LugarDto> GetLugaresNoActivos()
        {
            return _lugarRepository.GetAlls_NoActivos()
                .Select(lugar => new LugarDto(
                    lugar.Id,
                    lugar.NombreLugar,
                    lugar.DescripcionLugar,
                    lugar.PrecioBase,
                    lugar.CantMaxPersonas,
                    lugar.Ocupado,
                    lugar.RutaImagen,
                    lugar.Activo
                )).ToList();
        }

        public void UpdateLugar(LugarDto lugarDto)
        {
            compareLugar(lugarDto);

            string? rutaFinalImagen = lugarDto.rutaImagen;
            if (!string.IsNullOrWhiteSpace(lugarDto.rutaImagen) && File.Exists(lugarDto.rutaImagen) && Path.IsPathRooted(lugarDto.rutaImagen))
            {
                rutaFinalImagen = GuardarImagenLocalmente(lugarDto.rutaImagen);
            }

            Lugar lugarModel = new Lugar(
                lugarDto.Id,
                lugarDto.nombreLugar,
                lugarDto.descripcionLugar,
                lugarDto.precioBase,
                lugarDto.cantMaxPersonas,
                rutaFinalImagen
            );

            _lugarRepository.Update(lugarModel);
        }

        public void DeleteLugar(int id)
        {
            _lugarRepository.Delete(id);
        }

        public void ReactivateLugar(int id)
        {
            _lugarRepository.Reactivar(id);
        }

        public void DeleteLugarPermanente(int id)
        {
            _lugarRepository.DeletePermanent(id);
        }

        private string? GuardarImagenLocalmente(string? rutaOrigen)
        {
            if (string.IsNullOrWhiteSpace(rutaOrigen) || !File.Exists(rutaOrigen))
                return null;

            try
            {
                string carpetaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagenesLugares");

                if (!Directory.Exists(carpetaImagenes))
                {
                    Directory.CreateDirectory(carpetaImagenes);
                }

                string extension = Path.GetExtension(rutaOrigen);
                string nombreArchivoUnico = $"lugar_{Guid.NewGuid()}{extension}";
                string rutaDestinoCompleta = Path.Combine(carpetaImagenes, nombreArchivoUnico);

                File.Copy(rutaOrigen, rutaDestinoCompleta, overwrite: true);

                return Path.Combine("ImagenesLugares", nombreArchivoUnico);
            }
            catch
            {
                return null;
            }
        }

    }
}
