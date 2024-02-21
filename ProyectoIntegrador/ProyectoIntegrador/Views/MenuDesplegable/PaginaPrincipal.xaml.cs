using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views.MenuDesplegable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
    public partial class PaginaPrincipal : MasterDetailPage
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            this.Master = new MenuDes();
            this.Detail = new NavigationPage(new HomeView());
            App.MasterDet = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}