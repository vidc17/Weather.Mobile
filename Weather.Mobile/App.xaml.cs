﻿namespace Weather.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.RegionsPage());
        }
    }
}