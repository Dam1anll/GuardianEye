using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoIntegrador.ViewModels;

namespace ProyectoIntegrador.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioSesionView : ContentPage
    {
        public InicioSesionView()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMInicioSesion(Navigation);
        }
    }
}