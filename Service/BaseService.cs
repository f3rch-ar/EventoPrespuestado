using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Service
{
    public abstract class BaseService
    {
        protected string NormalizarTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return string.Empty;
            }

            string textoNormalizado = texto.Trim().Normalize(System.Text.NormalizationForm.FormD);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            foreach (char caracter in textoNormalizado)
            {
                System.Globalization.UnicodeCategory categoria = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(caracter);
                if (categoria != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(caracter);
                }
            }

            return stringBuilder.ToString().Normalize(System.Text.NormalizationForm.FormC).ToLowerInvariant();
        }
    }
}
