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
	public partial class UsuarioView : ContentPage
	{
        private bool editar = false;
        public UsuarioView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
			BindingContext = new VMUsuario(Navigation);
        }

        private void EditarClicked(object sender, EventArgs e)
        {
            if (!editar)
            {
                nombreEntry.IsEnabled = true;
                correoEntry.IsEnabled = true;
                telefonoEntry.IsEnabled = true;
                lugarEntry.IsEnabled = true;

                editarButton.Text = "Guardar";
                editarButton.BackgroundColor = Color.Green;

                editar = true;
            }
            else
            {
                nombreEntry.IsEnabled = false;
                correoEntry.IsEnabled = false;
                telefonoEntry.IsEnabled = false;
                lugarEntry.IsEnabled = false;

                editarButton.Text = "Editar";
                editarButton.BackgroundColor = Color.FromHex("#033076");

                editar = false;
            }
        }
    }
}