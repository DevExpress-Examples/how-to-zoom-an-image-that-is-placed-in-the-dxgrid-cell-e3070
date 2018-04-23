using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Core.WPFCompatibility;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;

namespace _1721___CellImageZoom {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            gridControl1.ItemsSource = GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)e.OriginalSource;
            image.DataContext = ((Image)button.Content).Source;
            image.Visibility = Visibility.Visible;
            image.Width = 700;
            image.Height = 700;
        }

        private void image_MouseLeave(object sender, MouseEventArgs e) {
            image.Visibility = Visibility.Collapsed;
            image.DataContext = null;
        }

        public class Vehicle {
            public Vehicle(string name, string category, string picture){
                Name = name;
                Category = category;
                Picture = picture;
            }
            public string Name {get; set;}

            public string Category {get; set;}

            public string Picture {get; set;}
        }

        private List<Vehicle> GetData() {
            return new List<Vehicle>() { 
                new Vehicle("Mercedes", "Coupe", "/1721%20-%20CellImageZoom;component/Pictures/Mercedes.png"),
                new Vehicle("Ford", "Truck", "/1721%20-%20CellImageZoom;component/Pictures/Ford.png"),
                new Vehicle("Jaguar", "Fourdoor", "/1721%20-%20CellImageZoom;component/Pictures/Jaguar.png")          
            };           
        }
    }
}
