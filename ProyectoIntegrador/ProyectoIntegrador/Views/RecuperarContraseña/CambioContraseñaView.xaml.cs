using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views.RecuperarContraseña
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CambioContraseñaView : ContentPage
	{
		public CambioContraseñaView()
		{
			InitializeComponent();
			BindingContext = new VMCambioContraseña(Navigation);
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}