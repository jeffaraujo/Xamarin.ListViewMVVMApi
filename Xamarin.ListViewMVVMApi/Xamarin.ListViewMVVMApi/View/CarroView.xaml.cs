using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.ListViewMVVMApi.ViewModel;

namespace Xamarin.ListViewMVVMApi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarroView : ContentPage
    {
        public CarroView()
        {
            InitializeComponent();
            this.BindingContext = new CarroViewModel();
        }
    }
}