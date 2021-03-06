﻿using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.PageModels;
using FreshMvvmDemo.Pages;
using FreshMvvmDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FreshMvvmDemo
{
    public class App : Application
    {
        public App()
        {
            ConfigureIOC();

            var contactList = FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshNavigationContainer(contactList);
            MainPage = navContainer;
        }

        private void ConfigureIOC()
        {
            FreshIOC.Container.Register<IContactsService, ContactsService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
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
