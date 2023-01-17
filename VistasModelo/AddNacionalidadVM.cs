using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Mensajes;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class AddNacionalidadVM : ObservableRecipient
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        //Comandos
        public RelayCommand AceptarCommand { get; }

        public AddNacionalidadVM()
        {
            AceptarCommand = new RelayCommand(NuevaNacionalidad);
        }

        public void NuevaNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new TextoNacionalidadValueChangedMessage(Nacionalidad));
        }
    }
}
