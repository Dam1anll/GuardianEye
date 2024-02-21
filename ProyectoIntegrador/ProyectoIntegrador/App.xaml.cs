using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoIntegrador.Views;
using ProyectoIntegrador.Views.MenuDesplegable;

namespace ProyectoIntegrador
{
    public partial class App : Application
    {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
        public static MasterDetailPage MasterDet { get; set; }
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new InicioSesionView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
