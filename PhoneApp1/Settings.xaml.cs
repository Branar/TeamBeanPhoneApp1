﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Device.Location;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class Settings : PhoneApplicationPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            GeoCoordinateWatcher watchGeo = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watchGeo.MovementThreshold = 1.0;
            watchGeo.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate holdGeo = new GeoCoordinate();
            holdGeo = watchGeo.Position.Location;
        }

    }
}