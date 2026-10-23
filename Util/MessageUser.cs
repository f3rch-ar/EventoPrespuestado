using EventoPresupuestado.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Util
{
    public static class MessageUser
    {
        public static void mostrarResultado(ResultDto resultado)
        {
            if (resultado == null)
            {
                mostrarErrorFatal("El sistema devolvió una respuesta nula inesperada al procesar la operación.");
                return;
            }
            if (resultado.IsSuccess)
            {
                mostrarExito(resultado.Message);
            }
            else
            {
                if (resultado.IsFatal)
                {
                    mostrarErrorFatal(resultado.Message);
                }
                else
                {
                    mostrarAdvertencia(resultado.Message);
                }
            }
        }

        public static void mostrarExito(string messageOK)
        {
            MessageBox.Show(messageOK, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mostrarAdvertencia(string messageAdver)
        {
            MessageBox.Show(messageAdver, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mostrarErrorFatal(string messageFatal)
        {
            MessageBox.Show(messageFatal, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool confirmarAccion(string messageConfir, string action = "Confirmar Acción")
        {
            DialogResult messageFinal = MessageBox.Show(messageConfir, action, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return messageFinal == DialogResult.Yes;
        }
    }
}
