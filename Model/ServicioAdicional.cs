using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class ServicioAdicional
    {
        private int idServicio;
        private string descripcion;
        private decimal valorServicio;

// CONSTRUCTORES

        public ServicioAdicional() { }

        public ServicioAdicional(string descp, decimal valorServ)
        {
            Descripcion = descp;
            ValorServicio = valorServ;
        }

        public ServicioAdicional(int idServ, string descp, decimal valorServ)
        {
            IdServicio = idServ;
            Descripcion = descp;
            ValorServicio = valorServ;
        }
        // METODOS


        // PROPIEDADES

        public int IdServicio
        {
            get { return idServicio; }
            set
            {
                if (value > 0)
                {
                    idServicio = value;
                }
            }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                //Verifica que no este vacio y que solo sea numero y letras
                if (string.IsNullOrEmpty(value) && !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException(nameof(value), "La descripción no debe estar vacio o contener un caracter especial");
                }

                descripcion = value;
            }
        }

        public decimal ValorServicio 
        {
            get { return valorServicio; }

            set
            {
                if (value <= 0)
                { 
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor no puede ser menor a cero");
                }

                valorServicio = value;
            }
        }

    }
}
