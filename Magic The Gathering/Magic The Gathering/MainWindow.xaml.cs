using Magic_The_Gathering.Screens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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

// Source for API: http://magicthegathering.io/

namespace Magic_The_Gathering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            downloadCards();
        }

        private void downloadCards()
        {
            //https://api.magicthegathering.io/v1/cards
            /*         using (var client = new HttpClient())
                     {
                         var responseString = client.GetStringAsync("https://api.magicthegathering.io/v1/cards");

                     }*/

            Task t = new Task(DownloadPageAsync);
            t.Start();


        }

        static async void DownloadPageAsync()
        {
            // ... Target page.
            string page = "https://api.magicthegathering.io/v1/cards";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                // ... Display the result.
                if (result != null &&
                result.Length >= 50)
                {
                    Console.WriteLine(result);
                }
            }
        }


        private void Guttersnipe_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close();
            
        }

        private void Sphinx_btn_Click (object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close(); 
        }

        private void Badger_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close(); 
        }

        private void Island_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close(); 
        }

        private void Mountain_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close(); 
        }

        private void Negate_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View(); 
            handView.Show(); 
            this.Close(); 
        }

         private void Sorin_btn_Click(object sender, RoutedEventArgs e)
        {
            var handView = new Hand_View();
            handView.Show(); 
            this.Close(); 
        }

    }
}
