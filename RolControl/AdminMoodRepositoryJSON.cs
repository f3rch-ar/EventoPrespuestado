using EventoPresupuestado.RolControl.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl
{
    public class AdminMoodRepositoryJSON : IConfigRepository
    {
        private readonly string _rutaArchivo;

        public AdminMoodRepositoryJSON()
        {
            string carpetaApp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EventoPresupuestado");

            if (!Directory.Exists(carpetaApp))
            {
                Directory.CreateDirectory(carpetaApp);
            }

            _rutaArchivo = Path.Combine(carpetaApp, "config.json");
        }

        public AdminMood ObtenerConfiguracion()
        {
            try
            {
                if (File.Exists(_rutaArchivo))
                {
                    string json = File.ReadAllText(_rutaArchivo);
                    return JsonSerializer.Deserialize<AdminMood>(json);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la configuración del sistema: " + ex.Message);
            }

            return null;
        }

        public void GuardarConfiguracion(AdminMood config)
        {
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(config, opciones);
                File.WriteAllText(_rutaArchivo, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la configuración en el disco: " + ex.Message);
            }
        }
    }
}
