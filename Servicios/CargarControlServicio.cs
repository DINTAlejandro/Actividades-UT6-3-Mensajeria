using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UT6_2_Aplicaciones_con_más_de_una_vista.Controles;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Servicios
{
    class CargarControlServicio
    {
        private ListadoPersonas listadoPersonas;
        public CargarControlServicio()
        {
            listadoPersonas = new ListadoPersonas();
        }
        public UserControl CargarNuevaPersona()
        {
            return new NuevaPersona();
        }

        public UserControl CargarConsultaPersona()
        {
            return new ConsultaPersona();
        }

        public UserControl CargarListaPersonas()
        {
            return listadoPersonas;
        }
    }
}
