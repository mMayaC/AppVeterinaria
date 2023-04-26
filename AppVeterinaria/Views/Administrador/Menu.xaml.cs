using AppVeterinaria.Views.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVeterinaria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {

        public Menu()
        {
            InitializeComponent();

        }

        private void salir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void RegistroEmTxt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegistroEmp());
        }


        private async void VerEmplTxt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VistaEmpleados());
        }
    }
}