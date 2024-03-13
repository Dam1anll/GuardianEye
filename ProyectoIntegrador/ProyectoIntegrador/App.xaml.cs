using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoIntegrador.Views;
using ProyectoIntegrador.Views.MenuDesplegable;

namespace ProyectoIntegrador
{
    public partial class App : Application
    {
        #pragma warning disable CS0618 
        public static MasterDetailPage MasterDet { get; set; }
        #pragma warning restore CS0618 
        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = OSAppTheme.Light;
            MainPage = new NavigationPage(new GestionCamaraView());
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
