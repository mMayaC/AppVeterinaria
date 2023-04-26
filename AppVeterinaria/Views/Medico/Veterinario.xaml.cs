using AppVeterinaria.Views.Medico;
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
    public partial class Veterinario : MasterDetailPage
    {
        public Veterinario()
        {
            InitializeComponent();
            Master = new MenuMed();
            Detail = new NavigationPage(new DetailMed());
            App.Modificador = this;
        }
    }
}