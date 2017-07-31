using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.ListViewMVVMApi.Annotations;
using Xamarin.ListViewMVVMApi.Model;
using Xamarin.ListViewMVVMApi.Utils;

namespace Xamarin.ListViewMVVMApi.ViewModel
{
    public class CarroViewModel : INotifyPropertyChanged
    {


        private ObservableCollection<Carro> _items;

        public ObservableCollection<Carro> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(nameof(Items)); }
        }

        public CarroViewModel()
        {
            Items = new ObservableCollection<Carro>()
            {
                new Carro() {Id = 1, Ano = 2015, Marca = "Volkwagen"},
                new Carro() {Id = 2, Ano = 2014, Marca = "Tesla Model S"},
                new Carro() {Id = 3, Ano = 2016, Marca = "Fiat"},
                new Carro() {Id = 4, Ano = 2017, Marca = "Renault"},
                new Carro() {Id = 5, Ano = 2016, Marca = "Nissan"}
            };
            //this.GetNewCars();
             MyHTTP.GetAllNewsAsync(list =>
            {
                foreach (Carro carro in list)
                {
                    Items.Add(carro);
                }
            });
        }

        public async void GetNewCars()
        {
            await MyHTTP.GetAllNewsAsync(list =>
             {
                 foreach (Carro carro in list)
                 {
                     Items.Add(carro);
                 }
             });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
