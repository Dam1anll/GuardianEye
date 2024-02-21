using ProyectoIntegrador.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoIntegrador.ViewModels
{
    public class VMRegistro : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMRegistro(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        #endregion
        #region PROCESOS
        public async Task IrAInicioSesion()
        {
            await Navigation.PushAsync(new InicioSesionView());
        }
        #endregion
        #region COMANDOS
        public ICommand IrAInicioSesionCommand => new Command(async () => await IrAInicioSesion());
        #endregion
    }
}
