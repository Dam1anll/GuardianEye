using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.ViewModels;
using ProyectoIntegrador.ViewModels.VmmenuDesplegable;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views.MenuDesplegable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDes : ContentPage
    {
        public MenuDes()
        {
            InitializeComponent();
            BindingContext = new VMmenuDes(Navigation);
            
        }
        
    }
}