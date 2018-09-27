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
        private CookieContainer cookieContainer;
        private HttpClientHandler clienthandler;
        private HttpClient client;
        public string lendyResponse { get; set; }

        public LendyLoginPage()
        {
            InitializeComponent();

            cookieContainer = new CookieContainer();
            clienthandler = new HttpClientHandler { AllowAutoRedirect = true, UseCookies = true, CookieContainer = cookieContainer };
            client = new HttpClient(clienthandler);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            string emailAdd = txt_EmailAddress.Text;
            string password = txt_Password.Password;

            string loginOutput = await HttpPost("https://lendy.co.uk/login", emailAdd, password);          
            Console.WriteLine(loginOutput);

            if (loginOutput.Contains("<p class='c-flash-message__message'>Couldn't login with those details</p>"))
            {
                MessageBox.Show("The given username or password was incorrect", "Invalid Credentials", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                string detailsPageOutput = await HttpGet("https://lendy.co.uk/account/statement?start=01%2F01%2F2016");
                Console.WriteLine(detailsPageOutput);

                lendyResponse = detailsPageOutput;

                DialogResult = true;                
                Close();
            }
        }

        private async Task<string> HttpPost(string url, string emailAddress = "", string password = "")
        {
            string responseString = "";
            HttpResponseMessage response;
            FormUrlEncodedContent content;

            if (emailAddress != "" && password != "")
            {
                var values = new Dictionary<string, string>
                {
                    {"email", emailAddress},
                    {"password", password}
                };

                content = new FormUrlEncodedContent(values);

                response = await client.PostAsync(url, content);

                responseString = await response.Content.ReadAsStringAsync();
            } else
            {
                responseString = "";
            }

            return responseString;
        }

        private async Task<string> HttpGet(string url)
        {
            string responseString = "";
            HttpResponseMessage response;

            response = await client.GetAsync(url);

            responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

    }
}
