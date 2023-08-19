using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace midproj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            homeb.Clicked += Homeb_Clicked;
            witchespathb.Clicked += Witchespathb_Clicked;
            modernwitchcraftb.Clicked += Modernwitchcraftb_Clicked;
            herbsathomeb.Clicked += Herbsathomeb_Clicked;
            contactb.Clicked += Contactb_Clicked;
        }

        private void Contactb_Clicked(object sender, EventArgs e)
        {
            var sp = Parent as FlyoutPage;
            sp.Detail = new NavigationPage(new ContactPage());
            sp.IsPresented = false;
        }

        private void Herbsathomeb_Clicked(object sender, EventArgs e)
        {
            var sp = Parent as FlyoutPage;
            sp.Detail = new NavigationPage(new Page3());
            sp.IsPresented = false;
        }

        private void Modernwitchcraftb_Clicked(object sender, EventArgs e)
        {
            var sp = Parent as FlyoutPage;
            sp.Detail = new NavigationPage(new Page2());
            sp.IsPresented = false;
        }

        private void Witchespathb_Clicked(object sender, EventArgs e)
        {
            var sp = Parent as FlyoutPage;
            sp.Detail = new NavigationPage(new Page1());
            sp.IsPresented = false;
        }

        private void Homeb_Clicked(object sender, EventArgs e)
        {
            var sp = Parent as FlyoutPage;
            sp.Detail = new NavigationPage(new MainPage());
            sp.IsPresented = false;
        }
    }
}