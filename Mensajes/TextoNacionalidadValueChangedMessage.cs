using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Mensajes
{
    class TextoNacionalidadValueChangedMessage : ValueChangedMessage<string>
    {
        public TextoNacionalidadValueChangedMessage(string texto) : base(texto) { }
    }
}
