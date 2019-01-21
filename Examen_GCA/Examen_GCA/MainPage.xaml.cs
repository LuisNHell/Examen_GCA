using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Examen_GCA.Models;
using Examen_GCA.ViewModels;
using Examen_GCA.DataSource;
namespace Examen_GCA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PersonaViewModel();

        }
    }
}
