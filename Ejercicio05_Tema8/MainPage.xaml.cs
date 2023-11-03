using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Ejercicio05_Tema8.DAL;
using Ejercicio05_Tema8.Entidades;

namespace Ejercicio05_Tema8
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<clsPersona> Personas {  get { return clsListadoPersonasDAL.getListadoCompletoPersonas(); } }
        public MainPage()
        {
            InitializeComponent();
            PersonasListView.ItemsSource = Personas;
        }

    }
}