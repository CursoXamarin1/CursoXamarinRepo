using CursoXam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CursoXam.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}