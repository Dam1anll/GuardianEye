using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CámarasView : ContentPage
    {
        public CámarasView()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        private void BtnActivar_Clicked(object sender, System.EventArgs e)
        {
            btnActivar.BackgroundColor = Color.Green;
            btnDesactivar.BackgroundColor = Color.Gray;
        }

        private void BtnDesactivar_Clicked(object sender, System.EventArgs e)
        {
            btnDesactivar.BackgroundColor = Color.Red;
            btnActivar.BackgroundColor = Color.Gray;
        }
        private void BtnActivar1_Clicked(object sender, System.EventArgs e)
        {
            btnActivar1.BackgroundColor = Color.Green;
            btnDesactivar1.BackgroundColor = Color.Gray;
        }

        private void BtnDesactivar1_Clicked(object sender, System.EventArgs e)
        {
            btnDesactivar1.BackgroundColor = Color.Red;
            btnActivar1.BackgroundColor = Color.Gray;
        }



    }
}