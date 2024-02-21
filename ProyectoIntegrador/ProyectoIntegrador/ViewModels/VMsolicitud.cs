using ProyectoIntegrador.Views.MenuDesplegable;
using ProyectoIntegrador.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoIntegrador.Views.RecuperarContraseña;

namespace ProyectoIntegrador.ViewModels
{
    public class VMsolicitud : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMsolicitud(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrCambioContraseña()
        {
            await Navigation.PushAsync(new CambioContraseñaView());
        }
        public async Task IrRetroceder()
        {
            await Navigation.PopAsync();
        }



        #endregion
        #region COMANDOS
        public ICommand IrCambioContraseñaCommand => new Command(async () => await IrCambioContraseña());
        public ICommand RetrocederCommand => new Command(async () => await IrRetroceder());
        #endregion
    }
}
