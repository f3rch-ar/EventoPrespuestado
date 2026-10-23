using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public abstract class ModelBase
    {
        private int id;
        private bool activo = true;

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El ID no puede ser menor a 0.");
                }
                id = value;
            }
        }
    

    public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}