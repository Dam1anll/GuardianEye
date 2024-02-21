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
	public partial class SolicitudView : ContentPage
	{
		public SolicitudView ()
		{
			InitializeComponent ();
			BindingContext = new VMsolicitud(Navigation);
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}