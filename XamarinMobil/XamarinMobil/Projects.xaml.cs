﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Projects : TabbedPage
    {
        public static string Name;
        public Projects(Proj proj)
        {
            Name = proj.Name;
            InitializeComponent();
        }
    }
}