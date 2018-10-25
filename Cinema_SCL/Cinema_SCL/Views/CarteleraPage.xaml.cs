using Cinema_SCL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_SCL.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarteleraPage : ContentPage
	{
		public CarteleraPage ()
		{
			InitializeComponent ();
            ListarPeliculas();
		}

        private async void ListarPeliculas()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            var request = await client.GetAsync("/api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Cartelera>>(responseJson);
                listPeliculas.ItemsSource = response;
            }
        }
    }
}