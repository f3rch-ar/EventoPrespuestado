using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Util
{
    public static class ValidationViews
    {
        public static bool isDecimalValido(string textDecimal)
        {
            if (string.IsNullOrWhiteSpace(textDecimal)) return false;
            return decimal.TryParse(textDecimal, out _);
        }

        public static bool isLettersAndSpaces(string textString)
        {
            if (string.IsNullOrWhiteSpace(textString)) return false;

            foreach (char c in textString)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }

        public static bool isAlphanumericAndHyphenWithText(string textString)
        {
            if (string.IsNullOrWhiteSpace(textString)) return false;

            string textClean = textString.Trim();

            bool tieneTexto = textClean.Any(char.IsLetter);
            bool caracteresValidos = textClean.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == '-');

            return tieneTexto && caracteresValidos;
        }

        public static bool validarDescripcionUI(string textoDescripcion, string nombreEntidad)
        {
            if (!isAlphanumericAndHyphenWithText(textoDescripcion))
            {
                MessageUser.mostrarAdvertencia($"La descripción de la {nombreEntidad} debe contener texto obligatoriamente y solo puede incluir letras, números, espacios y guiones (-).");
                return false;
            }
            return true;
        }

        public static bool validarSeleccionUI(int idSeleccionado, string accion, string nombreEntidad)
        {
            if (idSeleccionado == 0)
            {
                MessageUser.mostrarAdvertencia($"Por favor, seleccione primero un registro de {nombreEntidad} de la tabla para poder {accion}.");
                return false;
            }
            return true;
        }

        public static bool validarPrecioUI(string textoPrecio, string nombreEntidad)
        {
            if (!isDecimalValido(textoPrecio))
            {
                MessageUser.mostrarAdvertencia($"Por favor, ingrese un valor numérico válido para el precio de la {nombreEntidad}.");
                return false;
            }
            return true;
        }

        public static bool confirmarAccionUI(string accion, string nombreEntidad)
        {
            string mensaje = string.Empty;

            if (accion == "crear")
            {
                mensaje = $"¿Desea crear un nuevo registro de {nombreEntidad}?";
            }
            else if (accion == "modificar")
            {
                mensaje = $"¿Está seguro de que desea aplicar los cambios a esta {nombreEntidad}?";
            }
            else if (accion == "dar de baja" || accion == "eliminar")
            {
                mensaje = $"¿Desea dar de baja la {nombreEntidad} seleccionada? Dejará de mostrarse en la aplicación.";
            }
            else if (accion == "activar")
            {
                mensaje = $"¿Desea activar nuevamente la {nombreEntidad} seleccionada?";
            }
            else if (accion == "eliminar definitivamente")
            {
                mensaje = $"¿Está totalmente seguro de eliminar definitivamente el registro de {nombreEntidad}? Esta acción no se puede deshacer.";
            }
            else
            {
                mensaje = $"¿Desea {accion} el registro de {nombreEntidad}?";
            }

            return MessageUser.confirmarAccion(mensaje, "Confirmar Operación");
        }
    }
}
