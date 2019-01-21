using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen_GCA.ViewModels;

namespace Examen_GCA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonaPage : ContentPage
	{
		public PersonaPage()
		{
            InitializeComponent();
            BindingContext = new PersonaViewModel();
        }
	}
}