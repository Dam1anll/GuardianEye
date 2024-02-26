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
        private string _nombre;
        private string _correo;
        private string _contra;
        #endregion
        #region CONTRUCTOR
        public VMRegistro(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Nombre 
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public string Correo
        {
            get { return _correo; }
            set { SetValue(ref _correo, value); }
        }
        public string Contra
        {
            get { return _contra; }
            set { SetValue(ref _contra, value); }
        }
        #endregion
        #region PROCESOS
        public async Task IrAInicioSesion()
        {
            if (Nombre != null && Correo != null && Contra != null) 
            {
                await Navigation.PushAsync(new InicioSesionView());
            }
            else 
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Ingresa los datos necesarios", "Ok");
            }
        }
        #endregion
        #region COMANDOS
        public ICommand IrAInicioSesionCommand => new Command(async () => await IrAInicioSesion());
        #endregion
    }
}
