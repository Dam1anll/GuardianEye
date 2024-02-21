using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoIntegrador.Views;
using System.Linq;
using ProyectoIntegrador.Views.MenuDesplegable;
using ProyectoIntegrador.Views.RecuperarContraseña;

namespace ProyectoIntegrador.ViewModels
{
    public class VMInicioSesion : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMInicioSesion(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new RegistroView());
        }
        public async Task IrSolicitud()
        {
            await Navigation.PushAsync(new SolicitudView());
        }

        public async Task IrAHome()
        {

            await Application.Current.MainPage.Navigation.PopToRootAsync();

            var paginaPrincipal = new NavigationPage(new PaginaPrincipal());

            NavigationPage.SetHasBackButton(paginaPrincipal, false);

            Application.Current.MainPage = paginaPrincipal;
        }


        #endregion
        #region COMANDOS
        public ICommand IrARegistroCommand => new Command(async () => await IrARegistro());
        public ICommand IrAHomeCommand => new Command(async () => await IrAHome());
        public ICommand IrSolicitudCommand => new Command(async () => await IrSolicitud());

        #endregion
    }
}

