using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new StackLayoutDemo();
             MainPage = new GridDemo();

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
