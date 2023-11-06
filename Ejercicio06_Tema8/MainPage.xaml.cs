
using Microsoft.Maui.Graphics.Text;

namespace Ejercicio06_Tema8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DateFechaNac.MaximumDate = DateTime.Today;
        }

        private void Guardar_Pressed(object sender, EventArgs e)
        {
            bool formularioMal = false;

            if (EntryNombre.Text.Length <= 0)
            {
                EstadoNombre.Text = "Nombre incorrecto";
                EstadoNombre.TextColor = Colors.Red;
                formularioMal = true;
            } 
            if (EntryApellidos.Text.Length <= 0)
            {
                EstadoApellido.Text = "Apellidos incorrectos";
                EstadoApellido.TextColor = Colors.Red;
                formularioMal = true;

            }
            if (DateTime.Now.Year - DateFechaNac.Date.Year < 12)
            {
                EstadoFecha.Text = "Debes ser mayor de 12 años";
                EstadoFecha.TextColor = Colors.Red;
                formularioMal = true;
            }

            if (!formularioMal)
            {
                Estado.Text = "Usuario registrado";
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
    }
}