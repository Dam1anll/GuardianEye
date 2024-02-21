using ProyectoIntegrador.Views;
using ProyectoIntegrador.Views.RecuperarContraseña;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoIntegrador.ViewModels
{
    public class VMCambioContraseña : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMCambioContraseña(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrinicioSesion()
        {
            await Navigation.PushAsync(new InicioSesionView());
        }
        



        #endregion
        #region COMANDOS
        public ICommand IrinicioSesionCommand => new Command(async () => await IrinicioSesion());
      
        #endregion
    }
}
