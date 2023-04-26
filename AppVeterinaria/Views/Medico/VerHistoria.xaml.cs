using AppVeterinaria.Model;
using AppVeterinaria.Views.Administrador;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVeterinaria.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVeterinaria.Views.Medico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerHistoria : ContentPage
    {
        public VerHistoria()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            IList<HistoriaClinicaModel> register = await App.SQLiteDBH.GetHistoriaAsync();
            lstHistoria.ItemsSource = register;
        }
        // Método para invocar a la pagina de contenido de registrar nuevo usuario
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HistoriaClinica
            {
                BindingContext = new HistoriaClinicaModel()
            });
        }
        // Método para seleccionar y vincular los datos con la pagina, para editar y eliminar
        private async void lstHistoria_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushModalAsync(new EditHistoria
                {
                    BindingContext = e.SelectedItem as HistoriaClinicaModel
                });
            }
        }

        private void bntsalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Veterinario());
        }

        private void Buscador_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}

