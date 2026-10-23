using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Dto
{
    public class LugarDto
    {
        public int idLugar { get; set; }
        public string nombreLugar { get; set; }
        public string descripcionLugar { get; set; }
        public decimal precioBase { get; set; }
        public int cantMaxPersonas { get; set; }
        public bool ocupado { get; set; } = false;
        public string rutaImagen { get; set; }

        public bool activo { get; set; }

        public LugarDto() { }

        
        public LugarDto(string nombre, string descpLugar, decimal precio, int cantMaxPers, string? rutaImg)
        {
            nombreLugar = nombre;
            descripcionLugar = descpLugar;
            precioBase = precio;
            cantMaxPersonas = cantMaxPers;
            rutaImagen = rutaImg;
            ocupado = false;
            activo = true;
        }

        public LugarDto(int id, string nombre, string descpLugar, decimal precio, int cantMaxPers, bool estaOcupado, string? rutaImg, bool estaActivo)
        {
            idLugar = id;
            nombreLugar = nombre;
            descripcionLugar = descpLugar;
            precioBase = precio;
            cantMaxPersonas = cantMaxPers;
            ocupado = estaOcupado;
            rutaImagen = rutaImg;
            activo = estaActivo;
        }
    }
}
