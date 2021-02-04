using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mine.Services;
using Mine.Views;

namespace Mine
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //Comment out the Mock Data Store so that we can use the database instead
            DependencyService.Register<DatabaseService>();

            MainPage = new MainPage();
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
