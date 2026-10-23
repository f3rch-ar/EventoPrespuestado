using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Util
{
    public class ExceptionTest : Exception
    {
        public ExceptionTest(string mensaje) : base(mensaje) { }
    }
}
