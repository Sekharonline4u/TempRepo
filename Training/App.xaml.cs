using System;
using Training.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new TriggersDemo());
            //MainPage = new NavigationPage(new BehaviorsDemo());
            MainPage = new NavigationPage(new SessionView());
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
