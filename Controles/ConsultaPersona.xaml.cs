﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Controles
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersona.xaml
    /// </summary>
    public partial class ConsultaPersona : UserControl
    {
        ConsultaPersonaVM vm;
        public ConsultaPersona()
        {
            InitializeComponent();
            vm = new ConsultaPersonaVM();
            this.DataContext = vm;
        }
    }
}
