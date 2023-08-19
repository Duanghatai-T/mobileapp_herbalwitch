using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("PlayfairDisplay-Bold.ttf")]
namespace midproj
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new NavigationPage(new MainPage());


            MainPage =fp;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
