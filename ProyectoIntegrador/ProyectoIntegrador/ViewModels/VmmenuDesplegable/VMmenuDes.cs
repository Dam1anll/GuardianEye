using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoIntegrador.Views;
using ProyectoIntegrador.Views.RecuperarContraseña;

namespace ProyectoIntegrador.ViewModels.VmmenuDesplegable
{
    public class VMmenuDes : BaseViewModel
    {
        #region Variables
        #endregion
        #region Navigation
        public VMmenuDes(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos

        #endregion
        #region Procesos
        public async Task IrHome()
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new HomeView());

        }
        public async Task IrHistorial()
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new HistorialView());
        }
        public async Task IrTransmicion()
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new TransmicionView());
        }
        public async Task IrUsuario()
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new UsuarioView());
        }
        public async Task IrACamaras() 
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new CámarasView());
        }
       
#pragma warning disable CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica
        public async Task Retroceder()
#pragma warning restore CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica
        {
            App.MasterDet.IsPresented = false;

        }
        public async Task IrCerrarSesion()
        {
            await Navigation.PushAsync(new InicioSesionView());
        }

        #endregion
        #region Comands
        public ICommand IrHomeCommand => new Command(async () => await IrHome());
        public ICommand IrHistorialCommand => new Command(async () => await IrHistorial());
        public ICommand IrTrasnmicionCommand => new Command(async () => await IrTransmicion());
        public ICommand IrAUsuarioCommand => new Command(async () => await IrUsuario());
        public ICommand IrACamarasCommand => new Command(async () => await IrACamaras());
        public ICommand RetrocederCommand => new Command(async () => await Retroceder());
        public ICommand IrCerrarSesionCommand => new Command(async () => await IrCerrarSesion());
        #endregion
    }
}
