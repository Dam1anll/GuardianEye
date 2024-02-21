using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoIntegrador.Views;
using ProyectoIntegrador.Views.MenuDesplegable;
using ProyectoIntegrador.Views.RecuperarContraseña;
using Xamarin.Forms;

namespace ProyectoIntegrador.ViewModels
{
    public class VMTransmision : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMTransmision(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrACamara()
        {
            await Navigation.PushAsync(new TransmisionCamara());
        }

        #endregion
        #region COMANDOS
        public ICommand IrACamaraCommand => new Command(async () => await IrACamara());
        #endregion
    }
}
