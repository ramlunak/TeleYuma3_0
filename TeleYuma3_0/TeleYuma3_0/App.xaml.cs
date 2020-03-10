using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeleYuma3_0
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           // DependencyService.Register<MockDataStore>();
            MainPage = new PagesInicio.Login();
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
