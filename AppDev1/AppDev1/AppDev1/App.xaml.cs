﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDev1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("000000"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
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
