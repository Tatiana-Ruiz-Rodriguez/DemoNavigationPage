using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigationPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{
			InitializeComponent ();
            this.btnInicial.Clicked += BtnInicial_Clicked;
            this.btnModal.Clicked += BtnModal_Clicked;
            this.btnAtras.Clicked += BtnAtras_Clicked;
		}

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void BtnModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pagina4());
        }

        private async void BtnInicial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}