using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Investments_Tracker
{
    /// <summary>
    /// Interaction logic for LendyLoginPage.xaml
    /// </summary>
    public partial class LendyLoginPage : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public string lendyResponse { get; set; }

        public LendyLoginPage()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            string emailAdd = txt_EmailAddress.Text;
            string password = txt_Password.Password;

            var values = new Dictionary<string, string>
            {
                {"email", emailAdd},
                {"password", password}
            };

            var content = new FormUrlEncodedContent(values);

            var postTask = Task.Run(async () => {
                var response = await client.PostAsync("https://lendy.co.uk/login", content);

                var responseString = await response.Content.ReadAsStringAsync();

                lendyResponse = responseString;
            });

            postTask.Wait();
            Console.WriteLine(lendyResponse);

            if (lendyResponse.Contains("<p class='c-flash-message__message'>Couldn't login with those details</p>"))
            {
                MessageBox.Show("The given username or password was incorrect", "Invalid Credentials", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {               
                DialogResult = true;                
                Close();
            }
        }

        private static async Task<string> HttpPost(string emailAddress, string password)
        {
            var values = new Dictionary<string, string>
            {
                {"email", emailAddress},
                {"password", password}
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://lendy.co.uk/login", content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

    }
}
