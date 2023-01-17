using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Mensajes;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class ListaPersonasVM : ObservableObject
    {
        //Propiedades
        private Persona personaActual;

        public Persona PersonaActual
        {
            get { return personaActual; }
            set { SetProperty(ref personaActual, value); }
        }

        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        public ListaPersonasVM()
        {
            personaActual = null;
            Personas = AddPersonas();
            WeakReferenceMessenger.Default.Register<NuevaPersonaValueChangedMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);

            });

            WeakReferenceMessenger.Default.Register<ListaPersonasVM, PersonaRequestMessage>
            (this, (r, m) =>
            {
                m.Reply(personaActual);
            }
            );
        }

        private ObservableCollection<Persona> AddPersonas()
        {
            ObservableCollection<Persona> nuevasPersonas = new ObservableCollection<Persona>();
            nuevasPersonas.Add(new Persona("Peter",20,"Inglesa"));
            nuevasPersonas.Add(new Persona("Paco", 50, "Española"));
            nuevasPersonas.Add(new Persona("Wagner", 32, "Alemana"));
            nuevasPersonas.Add(new Persona("Alfonso", 21, "Española"));

            return nuevasPersonas;
        }
    }
}
