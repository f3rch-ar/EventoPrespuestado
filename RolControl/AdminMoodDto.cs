using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl

{
    public class AdminDto
    {
        public string? passwordActual { get; set; }

        public string? passwordNew { get; set; }
        public string? passwordNewConfirm { get; set; }

        public string? Email { get; set; }
    }
}
