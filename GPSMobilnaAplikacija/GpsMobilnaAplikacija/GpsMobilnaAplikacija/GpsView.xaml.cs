﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GpsMobilnaAplikacija
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GpsView : Page
    {
        public GpsView()
        {
            this.InitializeComponent();
            //moze se mijenjati da bude mapa sa ulicama ili satelitski snimak (ako ima i 3D ili cak streetview)
            mapa.Style = MapStyle.Aerial3DWithRoads;
            mapa.ZoomLevel = 20;
            this.DataContext = new GpsViewModel(mapa);
        }
    }
}
