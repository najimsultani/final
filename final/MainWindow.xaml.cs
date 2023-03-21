using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;
//Najim Sultani
//3-21-23
//Finals


namespace final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";
        public MainWindow()
        {
            InitializeComponent();

            DateTime date = new DateTime();
            txtDisplay.Text = calDate.ToString();
        }

        //Image Importer
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            //find the path
            OpenFileDialog files = new OpenFileDialog();

            if (files.ShowDialog() == true)
            {//file path 
                filePath = files.FileName;
                //display the file path 
                lblfilePath.Content = filePath;
                //image import
                BitmapImage image = new BitmapImage();
                Uri uri = new Uri(filePath);

                image.BeginInit();
                image.UriSource = uri;
                image.EndInit();

                //display
                imgDisplay.Source = image;

            }
        }

        private void btnSumit_Click(object sender, RoutedEventArgs e)
        {           
            txtDisplay.Text = calDate + "\n"
            //name
                + txtname.Text + "\n"
                + txtArtist.Text + "\n"
                + txtArtInformartion.Text + "\n";

            listView.Items.Add(txtDisplay.Text);


        }
        //darl color
        private void rbDark_Checked(object sender, RoutedEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            Uri uri = new Uri(filePath);

            image.BeginInit();
            image.UriSource = uri;
            image.EndInit();

            //display
            imgDisplay.Source = image;
            //Convert to black and white
            FormatConvertedBitmap greyscale = new FormatConvertedBitmap();
            //Initilaizing
            greyscale.BeginInit();
            //source
            greyscale.Source = image;
            //pass a destiation format
            //pixelFormats.Gray32Float
            greyscale.DestinationFormat = PixelFormats.Gray32Float;

            //end 
            greyscale.EndInit();

            imgDisplay.Source = greyscale;
        }
        //light color
        private void rbLight_Checked(object sender, RoutedEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            Uri uri = new Uri(filePath);

            image.BeginInit();
            image.UriSource = uri;
            image.EndInit();

            //display
            imgDisplay.Source = image;

            //Convert to black and white
            FormatConvertedBitmap greyscale = new FormatConvertedBitmap();
            //Initilaizing
            greyscale.BeginInit();
            //source
            greyscale.Source = image;
            //pass a destiation format
            //pixelFormats.Gray32Float
            greyscale.DestinationFormat = PixelFormats.Cmyk32;

            //end 
            greyscale.EndInit();

            imgDisplay.Source = greyscale;
        }

       
    }
}
