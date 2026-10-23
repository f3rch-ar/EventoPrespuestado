using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class Lugar : ModelBase
    {
        private string nombreLugar;
        private string descripcionLugar;
        private decimal precioBase;
        private int cantMaxPersonas;
        private bool ocupado;
        private string? rutaImagen;

        // CONSTRUCTORES


        public Lugar(string nombreLugar, string descpLugar, decimal precio, int cantMaxPers, string? rutaImg)
        {
            NombreLugar = nombreLugar;
            PrecioBase = precio;
            DescripcionLugar = descpLugar;
            CantMaxPersonas = cantMaxPers;
            Ocupado = false;
            RutaImagen = rutaImg;
        }

        public Lugar(int idLugar, string nombreLugar, string descpLugar, decimal precio, int cantMaxPers, string? rutaImg)
        {
            Id = idLugar;
            NombreLugar = nombreLugar;
            PrecioBase = precio;
            DescripcionLugar = descpLugar;
            CantMaxPersonas = cantMaxPers;
            Ocupado = false;
            RutaImagen = rutaImg;
        }

        // METODOS


        // PROPIEDADES

        public string NombreLugar
        {
            get { return nombreLugar; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(value), "La descripcion no debe estar vacia");
                }
                nombreLugar = value;
            }
        }

        public string DescripcionLugar
        {
            get { return descripcionLugar; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(value), "La descripcion no debe estar vacia");
                }
                descripcionLugar = value;
            }
        }

        public bool Ocupado
        {
            get { return ocupado; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException(nameof(value), "El campo no debe ser nulo o estar vacio");
                }

                ocupado = value;
            }
        }

        public decimal PrecioBase
        {
            get { return precioBase; }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor no puede ser menor o igual a cero");
                }

                precioBase = value;
            }
        }

        public int CantMaxPersonas
        {
            get { return cantMaxPersonas; }
         
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La cantidad Maxima no puede ser menor o igual a cero");
                }

                cantMaxPersonas = value;
            
            }
        }


        public string? RutaImagen
        {
            get
            {
                return rutaImagen;
            }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    rutaImagen = null;
                    return;
                }

                if (value != null)
                {
                    string extension = System.IO.Path.GetExtension(value).ToLower();

                    if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
                    {
                        throw new ArgumentException("El archivo seleccionado debe ser una imagen válida (.jpg, .jpeg, .png).", nameof(value));
                    }
                }

                rutaImagen = value;
            }
        }
    }
}
