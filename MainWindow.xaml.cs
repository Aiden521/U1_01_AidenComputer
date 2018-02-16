/*
 Aiden Jolley Ruhn
 Febuary 16, 2018
 U1_03_AidenComputer
 Aiden Computer - Displays all the neccasary and compatible parts that will work together to create a PC
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U1_01_AidenComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int imageCount = 0;

        public MainWindow()
        {


            InitializeComponent();
        }


        private void ForwardPart_Click(object sender, RoutedEventArgs e)
        {

            imageCount++;
            if (imageCount == 0)
            {
                BackPart.Visibility = Visibility.Hidden;
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/51kDgQgexzL.jpg")); // CPU image
                PartImage.Source = bi;
                PartName.Content = ("Intel - Xeon E5-2650 V2 2.6GHz 8-Core Processor");


            }
            else if (imageCount == 1)
            {
                BackPart.Visibility = Visibility.Visible;
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/41L1psoCFDL.jpg")); // Case image
                PartImage.Source = bi;
                PartName.Content = ("Raidmax - Vampire ATX Full Tower Case");
            }
            else if (imageCount == 2)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://images-eu.ssl-images-amazon.com/images/I/41avFAKhcVL.jpg")); // Gpu Image
                PartImage.Source = bi;
                PartName.Content = ("PNY - Quadro GP100 16GB Video Card");
            }
            else if (imageCount == 3)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://cdn.pcpartpicker.com/static/forever/images/product/1d57cf53a1289e4dfff1aed9b1cc272a.1600.jpg")); // Power Supply Image
                PartImage.Source = bi;
                PartName.Content = ("Corsair - 1600W 80+ Titanium Certified Fully-Modular ATX Power Supply");
            }
            else if (imageCount == 4)
            {
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/21Yymj%2BMdzL.jpg")); // Memory Image
                PartImage.Source = bi;
                PartName.Content = ("G.Skill - Ripjaws Z Series 64GB (8 x 8GB) DDR3-2133 Memory");
            }
            else if (imageCount == 5)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://cdn.pcpartpicker.com/static/forever/images/product/77cfc76e4bad07d94ddb71ea975206a2.1600.jpg")); // Storage Image
                PartImage.Source = bi;
                PartName.Content = ("Seagate - IronWolf 12TB 3.5 7200RPM Internal Hard Drive");

            }
            else if (imageCount == 6)
            {
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/617GiunMqqL.jpg")); // Motherboard Image
                PartImage.Source = bi;
                ForwardPart.Visibility = Visibility.Hidden;
                PartName.Content = ("ASRock - X79 Extreme9 ATX LGA2011 Motherboard");
            }

        }

        private void BackPart_Click(object sender, RoutedEventArgs e)
        {
            imageCount--;
            ForwardPart.Visibility = Visibility.Visible;
            if (imageCount == 0)
            {
                //runs if imageCount is 0
                BackPart.Visibility = Visibility.Hidden;
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/51kDgQgexzL.jpg")); // CPU image
                PartImage.Source = bi;
                PartName.Content = ("Intel - Xeon E5-2650 V2 2.6GHz 8-Core Processor");

            }
            else if (imageCount == 1)
            {

                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/41L1psoCFDL.jpg")); // Case image
                PartImage.Source = bi;
                PartName.Content = ("Raidmax - Vampire ATX Full Tower Case");
            }
            else if (imageCount == 2)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://images-eu.ssl-images-amazon.com/images/I/41avFAKhcVL.jpg")); // Gpu Image
                PartImage.Source = bi;
                PartName.Content = ("PNY - Quadro GP100 16GB Video Card");
            }
            else if (imageCount == 3)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://cdn.pcpartpicker.com/static/forever/images/product/1d57cf53a1289e4dfff1aed9b1cc272a.1600.jpg")); // Power Supply Image
                PartImage.Source = bi;
                PartName.Content = ("Corsair - 1600W 80+ Titanium Certified Fully-Modular ATX Power Supply");

            }
            else if (imageCount == 4)
            {
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/21Yymj%2BMdzL.jpg")); // Memory Image
                PartImage.Source = bi;
                PartName.Content = ("G.Skill - Ripjaws Z Series 64GB (8 x 8GB) DDR3-2133 Memory");
            }
            else if (imageCount == 5)
            {
                BitmapImage bi = new BitmapImage(new Uri("https://cdn.pcpartpicker.com/static/forever/images/product/77cfc76e4bad07d94ddb71ea975206a2.1600.jpg")); // Storage Image
                PartImage.Source = bi;
                PartName.Content = ("Seagate - IronWolf 12TB 3.5 7200RPM Internal Hard Drive");
            }
            else if (imageCount == 6)
            {
                BitmapImage bi = new BitmapImage(new Uri("http://ecx.images-amazon.com/images/I/617GiunMqqL.jpg")); // Motherboard Image
                PartImage.Source = bi;
                ForwardPart.Visibility = Visibility.Hidden;
                PartName.Content = ("ASRock - X79 Extreme9 ATX LGA2011 Motherboard");
            }
        }
    }
}
