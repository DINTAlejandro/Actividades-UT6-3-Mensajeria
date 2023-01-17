using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Ventanas;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Servicios
{
    class AbrirVentanaServicio
    {
        public bool? AbrirAddNacionalidad()
        {
            VentanaAddNacionalidad nuevaVentana = new VentanaAddNacionalidad();
            return nuevaVentana.ShowDialog();
        }
    }
}
