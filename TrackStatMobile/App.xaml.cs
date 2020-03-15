﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrackStatMobile.Services;
using TrackStatMobile.Views;
using TrackStatMobile.Models;
using System.Diagnostics;

namespace TrackStatMobile
{
    public partial class App : Application
    {
        public static Repo Repository;
        public App(string dbPath)
        {
            InitializeComponent();

            Repository = new Repo(dbPath);

            Debug.WriteLine($"Database located at: {dbPath}");

            MainPage = new AppShell();
        }

        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
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
