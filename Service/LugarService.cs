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
    public class LugarService
    {
        private readonly IRepository<Lugar> _lugarRepository;

        public LugarService()
        {
            _lugarRepository = LugarRepository.getInstance();
        }

        public void CreateLugar(LugarDto lugarDto)
        {
            // 1. Procesar copia de la imagen seleccionada al directorio de la app (si se adjuntó una)
            string? rutaFinalImagen = GuardarImagenLocalmente(lugarDto.rutaImagen);

            // 2. Mapear DTO a Modelo de Dominio
            Lugar lugarModel = new Lugar(
                lugarDto.nombreLugar,
                lugarDto.descripcionLugar,
                lugarDto.precioBase,
                lugarDto.cantMaxPersonas,
                rutaFinalImagen
            );

            // 3. Persistir en el Repositorio
            _lugarRepository.Create(lugarModel);
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
            // Si la ruta cambió a una ruta absoluta local (nueva foto elegida), la copiamos
            string? rutaFinalImagen = lugarDto.rutaImagen;
            if (!string.IsNullOrWhiteSpace(lugarDto.rutaImagen) && File.Exists(lugarDto.rutaImagen) && Path.IsPathRooted(lugarDto.rutaImagen))
            {
                rutaFinalImagen = GuardarImagenLocalmente(lugarDto.rutaImagen);
            }

            Lugar lugarModel = new Lugar(
                lugarDto.idLugar,
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
                // Carpeta destino dentro del entorno local de la aplicación
                string carpetaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagenesLugares");

                if (!Directory.Exists(carpetaImagenes))
                {
                    Directory.CreateDirectory(carpetaImagenes);
                }

                // Generar nombre de archivo único con GUID para evitar sobreescrituras
                string extension = Path.GetExtension(rutaOrigen);
                string nombreArchivoUnico = $"lugar_{Guid.NewGuid()}{extension}";
                string rutaDestinoCompleta = Path.Combine(carpetaImagenes, nombreArchivoUnico);

                // Copiar el archivo
                File.Copy(rutaOrigen, rutaDestinoCompleta, overwrite: true);

                // Retornar la ruta relativa para persistir en la BD
                return Path.Combine("ImagenesLugares", nombreArchivoUnico);
            }
            catch
            {
                // En caso de fallo de E/S, no bloqueamos la creación del registro y dejamos la ruta nula
                return null;
            }
        }

    }
}
