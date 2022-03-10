using System;
using Venta_AEA_App.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Venta_AEA_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //The root page of your application


            MainPage = new NavigationPage(new DispositivosPage());
        }

        protected override void OnStart()
        {
            //Handle when your app starts
        }

        protected override void OnSleep()
        {
            //Handle when your app sleeps
        }

        protected override void OnResume()
        {
            //Handle when your app resumes
        }
    }
}
