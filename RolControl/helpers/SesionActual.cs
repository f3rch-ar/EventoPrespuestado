using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl.helpers
{
    public static class SesionActual
    {
        public static bool isAdminActivo { get; set; } = false;
        public static bool ShowInactivos { get; set; } = false;
    }
}
