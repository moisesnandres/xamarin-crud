﻿using System;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(XamarinEmpleados.iOS.Config))]

namespace XamarinEmpleados.iOS
{
    class Config : IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;

        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    var directorio = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    directorioDB = System.IO.Path.Combine(directorio, "..", "Library");
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return plataforma;
            }
        }
                    
    }
}
