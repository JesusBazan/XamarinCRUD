using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCRUD.View;

namespace XamarinCRUD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PersonaPage());
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
