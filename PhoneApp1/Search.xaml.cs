using System;
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
    public partial class Search : PhoneApplicationPage
    {
        public Search()
        {
            InitializeComponent();
            WebBrowser.VisibilityProperty.Equals(true);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}