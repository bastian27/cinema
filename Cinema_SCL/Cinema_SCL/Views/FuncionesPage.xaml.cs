using Cinema_SCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_SCL.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionesPage : ContentPage
	{
		public FuncionesPage(Cartelera cartelera)
        {
			InitializeComponent ();
		}

        private void listFunciones_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}