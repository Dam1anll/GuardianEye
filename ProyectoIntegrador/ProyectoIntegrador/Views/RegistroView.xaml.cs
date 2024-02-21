using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroView : ContentPage
    {

        private StackLayout correoLayout;
        private StackLayout nombreLayout;
        public RegistroView()
        {
            InitializeComponent();
            BindingContext = new VMRegistro(Navigation);
            correoLayout = correoLayoutStack;
            nombreLayout = nombreLayoutStack;
        }

        private void SiguienteNombre_Clicked(object sender, EventArgs e)
        {
            nombreLayout.IsVisible = false;
            correoLayout.IsVisible = true;
        }
    }
}