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
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Move_ForgotPass(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Move_SignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void Move_Parties(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PartiesPage());
        }
    }
}