using System;
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
using System.Windows.Shapes;
using UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Ventanas
{
    /// <summary>
    /// Lógica de interacción para VentanaAddNacionalidad.xaml
    /// </summary>
    public partial class VentanaAddNacionalidad : Window
    {
        AddNacionalidadVM vm;
        public VentanaAddNacionalidad()
        {
            InitializeComponent();
            vm = new AddNacionalidadVM();
            this.DataContext = vm;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            //Código antes de cerrar la ventana (método VM)
            //vm.NuevaNacionalidad();
            DialogResult = true;
        }
    }
}
