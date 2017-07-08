using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GUI_13t
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PartiesPage : ContentPage
    {
        private List<car> cars = new List<car>();
        public PartiesPage()
        {
            InitializeComponent();
            cars.Add(new car { CarName = "Rob Finnerty" });
            cars.Add(new car { CarName = "Bill Wrestler" });
            cars.Add(new car { CarName = "Dr. Geri-Beth Hooper" });
            cars.Add(new car { CarName = "Dr. Keith Joyce-Purdy" });
            cars.Add(new car { CarName = "Sheri Spruce" });
            cars.Add(new car { CarName = "Burt Indybrick" });
            listView.ItemsSource = cars;

        }

        private void New_Plate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPlate());
        }
    }
}