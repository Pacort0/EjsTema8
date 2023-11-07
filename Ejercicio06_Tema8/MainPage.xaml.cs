
using Microsoft.Maui.Graphics.Text;

namespace Ejercicio06_Tema8
{
    public partial class MainPage : ContentPage
    {
        bool nombreCambiado = false;
        bool apellidosCambiados = false;
        public MainPage()
        {
            InitializeComponent();
            DateFechaNac.MaximumDate = DateTime.Today;
        }

        private void EntryNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            nombreCambiado = true;  
        }

        private void EntryApellidos_TextChanged(object sender, TextChangedEventArgs e)
        {
            apellidosCambiados=true;
        }

        private void Guardar_Pressed(object sender, EventArgs e)
        {
            bool fechaBien = true;

            if (DateTime.Now.Year - DateFechaNac.Date.Year < 12)
            {
                EstadoFecha.Text = "Debes ser mayor de 12 años";
                EstadoFecha.TextColor = Colors.Red;
                fechaBien = false;
            } else {
                EstadoFecha.Text = "";
            }

            if (compruebaNombre() && compruebaApellidos() && fechaBien)
            {
                Estado.Text = "Usuario registrado con éxito";
                Estado.TextColor = Colors.Green;
            } else
            {
                Estado.Text = "Datos introducidos inválidos";
                Estado.TextColor = Colors.Red;
            }
        }

        private void Añadir_Pressed(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;

            EntryNombre.Text = "";
            EntryApellidos.Text = "";
            DateFechaNac.Date = fechaActual;
        }

        private void Eliminar_Pressed(object sender, EventArgs e)
        {

        }

        private void DateFechaNac_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private bool compruebaNombre()
        {
            bool formularioBien = true;

            if (EntryNombre.Text == null || !nombreCambiado || EntryNombre.Text == "")
            {
                EstadoNombre.Text = "Nombre incorrecto";
                EstadoNombre.TextColor = Colors.Red;
                formularioBien = false;
            }
            else
            {
                EstadoNombre.Text = "";
            }
            return formularioBien;
        }
        private bool compruebaApellidos()
        {
            bool formularioBien = true;
            if (EntryApellidos == null || !apellidosCambiados || EntryApellidos.Text == "")
            {
                EstadoApellidos.Text = "Apellidos incorrectos";
                EstadoApellidos.TextColor = Colors.Red;
                formularioBien = false;
            }
            else
            {
                EstadoApellidos.Text = "";
            }
            return formularioBien;
        }
    }
}