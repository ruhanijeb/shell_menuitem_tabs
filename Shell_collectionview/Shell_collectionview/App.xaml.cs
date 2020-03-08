using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Shell_collectionview.Services;
using Shell_collectionview.Views;

namespace Shell_collectionview
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
           // MainPage = new MainShell();
            MainPage = new TabShell();
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
