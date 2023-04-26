using AppVeterinaria.Data;
using AppVeterinaria.Model;
using AppVeterinaria.Views;
using AppVeterinaria.Views.Administrador;
using AppVeterinaria.Views.Medico;
using AppVeterinaria.Views.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppVeterinaria
{
    public partial class MainPage : ContentPage
    {
        UsuariosModel user = new UsuariosModel();
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            var user = await App.SQLiteDB.GetUserAsync(usuariotxt.Text, Conttxt.Text);
            string docum = usuariotxt.Text;
            string cont = Conttxt.Text;
            if (docum == "43065" && cont == "123")
            {
                await Navigation.PushModalAsync(new Admin());
            }
            else if (user != null)
            {
                if (user.Idrol == 1)
                {
                    // Si el usuario es un administrador, mostrar la vista de administrador
                    await Navigation.PushModalAsync(new Admin());
                }
                else if (user.Idrol == 2)
                {

                    await Navigation.PushModalAsync(new Veterinario());
                }
                else if (user.Idrol == 3)
                {

                    await Navigation.PushModalAsync(new Vend());
                }
            }
            else
            {
                // Si las credenciales son incorrectas, mostrar un mensaje de error
                await DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }
    }

}
