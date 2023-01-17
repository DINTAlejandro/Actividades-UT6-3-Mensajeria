using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Servicios;
using UT6_2_Aplicaciones_con_más_de_una_vista.Mensajes;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class NuevaPersonaVM : ObservableRecipient
    {
        //Servicios
        private AbrirVentanaServicio abrirVentanaServicio;

        //Comandos
        public RelayCommand AceptarCommand { get; }
        public RelayCommand AddNacionalidadCommand{ get; }

        //Propiedades
        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { listaNacionalidades = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }


        public NuevaPersonaVM()
        {
            WeakReferenceMessenger.Default.Register<TextoNacionalidadValueChangedMessage>(this, (r, m) =>
            {
                ListaNacionalidades.Add(m.Value);

            });

            //Servicios
            abrirVentanaServicio = new AbrirVentanaServicio();

            //Comandos
            AceptarCommand = new RelayCommand(Aceptar);
            AddNacionalidadCommand = new RelayCommand(AddNacinalidad);

            //Propiedades
            ListaNacionalidades = RellenarNacionalidades();
        }

        private void Aceptar()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaValueChangedMessage(new Persona(Nombre,Edad,Nacionalidad)));
        }

        private void AddNacinalidad()
        {
            abrirVentanaServicio.AbrirAddNacionalidad();
        }

        private ObservableCollection<string> RellenarNacionalidades()
        {
            ObservableCollection<String> listaNacionalidades = new ObservableCollection<string>();
            listaNacionalidades.Add("Española");
            listaNacionalidades.Add("Alemana");
            listaNacionalidades.Add("Portuguesa");
            listaNacionalidades.Add("Italiana");
            listaNacionalidades.Add("China");
            return listaNacionalidades;
        }
    }
}
