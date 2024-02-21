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
	public partial class HistorialView : ContentPage
	{
		public HistorialView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
			BindingContext = new VMHistorial(Navigation);
        }
    }
}