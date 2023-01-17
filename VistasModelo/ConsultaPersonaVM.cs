using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Mensajes;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class ConsultaPersonaVM : ObservableRecipient
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { SetProperty(ref persona, value);}
        }

        public ConsultaPersonaVM()
        {
            Persona = WeakReferenceMessenger.Default.Send<PersonaRequestMessage>() ;
            

        }
    }
}
