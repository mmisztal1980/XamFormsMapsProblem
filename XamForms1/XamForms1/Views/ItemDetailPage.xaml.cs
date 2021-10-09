using System.ComponentModel;
using Xamarin.Forms;
using XamForms1.ViewModels;

namespace XamForms1.Views
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