using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using ProyectoIntegrador.Models;
using System.Net.Http;
using System.Net;

namespace ProyectoIntegrador.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GestionCamaraView : ContentPage
    {
        public GestionCamaraView()
        {
            InitializeComponent();
            BindingContext = new VMCamara(Navigation);
        }
    }
}