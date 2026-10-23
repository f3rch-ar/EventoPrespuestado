using EventoPresupuestado.RolControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl.helpers
{
    public interface IConfigRepository
    {
        AdminMood ObtenerConfiguracion();
        void GuardarConfiguracion(AdminMood config);
    }
}
