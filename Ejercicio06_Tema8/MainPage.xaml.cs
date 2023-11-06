
using Microsoft.Maui.Graphics.Text;

namespace Ejercicio06_Tema8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EntryNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EntryApellidos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EntryFechaNac_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Guardar_Pressed(object sender, EventArgs e)
        {
            if (!DateGood())
            {
                Estado.Text = "Datos introducidos incorrectos";
                Estado.TextColor = Colors.Red;
            } else
            {
                Estado.Text = "Usuario Registrado";
                Estado.TextColor = Colors.Green;
            }
        }

        private void Añadir_Pressed(object sender, EventArgs e)
        {
            if (EntryNombre.Text.Length > 0)
            {
                EntryNombre.Text = "";
            }
            if (EntryApellidos.Text.Length > 0) 
            {
                EntryApellidos.Text = "";
            } 
            if (EntryFechaNac.Text.Length > 0) {
                EntryFechaNac.Text = "";
            }
        }

        private void Eliminar_Pressed(object sender, EventArgs e)
        {

        }
        private bool DateGood()
        {
            bool isGoodDate = true;
            string fechaNac = EntryFechaNac.Text;
            string[] fechas = fechaNac.Split("/");

            if (Int32.Parse(fechas[0]) < 0 && Int32.Parse(fechas[0]) > 31)
            {
                isGoodDate = false;
            }
            else if (Int32.Parse(fechas[1]) < 0 && Int32.Parse(fechas[1]) > 12)
            {
                isGoodDate = false;
            }
            else if (Int32.Parse(fechas[2]) > 0)
            {
                isGoodDate = false;
            }

            return isGoodDate;
        }
    }
}