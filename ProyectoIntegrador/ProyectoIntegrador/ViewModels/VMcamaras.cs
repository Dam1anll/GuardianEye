using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoIntegrador.ViewModels
{
    public class VMcamaras : BaseViewModel
    {


        bool _Activar = true;
        bool _Desactivar = false;

        public ICommand ActivarCommand { get; private set; }
        public ICommand DesactivarCommand { get; private set; }

        public VMcamaras(INavigation navigation)
        {
            Navigation = navigation;
            ActivarCommand = new Command(OnActivarClicked);
            DesactivarCommand = new Command(OnDesactivarClicked);
        }

        public bool Activar
        {
            get { return _Activar; }
            set { SetProperty(ref _Activar, value); }
        }

        public bool Desactivar
        {
            get { return _Desactivar; }
            set { SetProperty(ref _Desactivar, value); }
        }

        public Color ActivarColor
        {
            get { return Activar ? Color.Green : Color.Default; }
        }

        public Color DesactivarColor
        {
            get { return Desactivar ? Color.Red : Color.Default; }
        }

        void OnActivarClicked()
        {
            Activar = true;
            Desactivar = false;
            Debug.WriteLine("Botón Activar clicado.");
        }

        void OnDesactivarClicked()
        {
            Activar = false;
            Desactivar = true;
            Debug.WriteLine("Botón Desactivar clicado.");
        }
    }
}


