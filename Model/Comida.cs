using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventoPresupuestado.Model.Enums;

namespace EventoPresupuestado.Model
{
    public class Comida : ModelBase
    {
        
        private string descripcionComida;
        private EnumTipoCom estadoComida;
        private decimal valorComida;

// CONSTRUCTORES

        public Comida() { }

        public Comida(int idComd, string descp, EnumTipoCom estadoCom, decimal valorComid)
        {
            Id = idComd;
            TipoDeComida = estadoCom;
            DescripcionComida = descp;
            ValorComida = valorComid;
        }


        public Comida(string descp, EnumTipoCom estadoCom, decimal valorComid)
        {
            TipoDeComida = estadoCom;
            DescripcionComida = descp;
            ValorComida = valorComid;
        }




    //GETTES && SETTERS


        public EnumTipoCom TipoDeComida
        {
            get { return estadoComida; }
            set {
                if (!EnumTipoCom.IsDefined(typeof(EnumTipoCom), value))
                {
                    throw new ArgumentException("El tipo de comida proporcionado no es válido.");
                }
                estadoComida = value;
            }
        }

        public string DescripcionComida
        {
            get { return descripcionComida; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede estar vacía.");

                string textClean = value.Trim();

                bool tieneTexto = textClean.Any(char.IsLetter);
                bool caracteresValidos = textClean.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == '-');

                if (!tieneTexto || !caracteresValidos)
                {
                    throw new ArgumentException("La descripción debe contener texto obligatoriamente y solo se permiten letras, números, espacios y guiones (-).");
                }

                descripcionComida = textClean;
            }
        }

        public decimal ValorComida
        {
            get { return valorComida; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio de la comida no puede ser menor a 0.");
                }
                valorComida = value;
            }
        }
    }
}
