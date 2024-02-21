using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoIntegrador.Views;
using Xamarin.Forms;

namespace ProyectoIntegrador.ViewModels
{
    public class VMHistorial : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMHistorial(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrANotificacion()
        {
            await Navigation.PushAsync(new NotificacionView());
        }
        #endregion
        #region COMANDOS
        public ICommand IrANotificacionCommand => new Command(async () => await IrANotificacion());
        #endregion
    }
}
