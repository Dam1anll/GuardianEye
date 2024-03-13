using ProyectoIntegrador.Models;
using ProyectoIntegrador.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;


namespace ProyectoIntegrador.ViewModels
{
    public class VMCamara : BaseViewModel
    {
        #region VARIABLES
        private string _ubicacion;
        private string _estado;
        private string _modelo;

        #endregion
        #region CONTRUCTOR
        public VMCamara(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
      
        public string Ubicacion
        {
            get { return _ubicacion; }
            set { SetValue(ref _ubicacion, value); }
        }
        public string Estado
        {
            get { return _estado; }
            set { SetValue(ref _estado, value); }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { SetValue(ref _modelo, value); }
        }

        #endregion
        #region PROCESOS
        public async Task AgregarCamara() 
        {
            CamaraModel camaraModel = new CamaraModel
            {
                Ubicacion = Ubicacion,
                Estado = Estado,
                Modelo = Modelo
            };

            Uri Request = new Uri("http://guardianeyeapi.somee.com/Api/Camara");

            var Client = new HttpClient();
            var json = JsonConvert.SerializeObject(camaraModel);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(Request, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                await DisplayAlert("Mensaje", "Camara Agregada Correctamente", "Ok");
              
            }
            else
            {
                await DisplayAlert("Mensaje", "Camara no agregada", "OK");
            }

        }
        #endregion
        #region COMANDOS
        public ICommand AgregarCamaraCommand => new Command(async () => await AgregarCamara());
        #endregion
    }
}
