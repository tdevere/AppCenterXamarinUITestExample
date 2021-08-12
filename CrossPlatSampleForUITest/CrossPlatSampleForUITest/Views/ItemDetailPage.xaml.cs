using CrossPlatSampleForUITest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CrossPlatSampleForUITest.Views
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