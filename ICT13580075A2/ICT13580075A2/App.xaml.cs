using ICT13580075A2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ICT13580075A2
{
    public partial class App : Application
    {

        public static Dbhelpers Dbhelper { get; set; }

        public App()
        {
            InitializeComponent();
        }


        public App(string dbpath)
        {
            InitializeComponent();

            Dbhelper = new Dbhelpers(dbpath);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
