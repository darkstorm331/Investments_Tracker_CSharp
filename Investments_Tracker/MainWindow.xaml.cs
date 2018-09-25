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

namespace Investments_Tracker
{
    /// <summary>
    /// Created by Michael Brand 25/09/2018
    /// 
    /// This code handles the logic behind the main page that the user first sees
    /// </summary>
    public partial class MainWindow : Window
    {
        int selectedPlatform = 0;
        List<int> currentSelections = new List<int>();
        string postResponse;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_FirstConnect_Click(object sender, RoutedEventArgs e)
        {           
            selectedPlatform = cmb_FirstSelection.SelectedIndex;
            System.Console.WriteLine(selectedPlatform); //For dev purposes
            
            //If the selected option is '*Select Platform*' then display an error message to the user
            if(selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            } else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    bool? result = false;
                    //Bring up the login box for the selected platform
                    switch (selectedPlatform)
                    {
                        case 1:
                            LendyLoginPage llp = new LendyLoginPage();
                            result = llp.ShowDialog();
                            Console.WriteLine(result); //For dev purposes 
                            
                            if(result == true)
                            {
                                postResponse = llp.lendyResponse;
                                                            
                            } else
                            {

                            }

                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            break;

                        default:
                            System.Console.WriteLine("Index not found");
                            break;
                    }

                    if(result == true)
                    {
                        //Add the current selection to the list
                        currentSelections.Add(selectedPlatform);
                        cmb_FirstSelection.IsEnabled = false;
                        btn_FirstConnect.IsEnabled = false;
                    }
                }             
            }

        }

        private void btn_SecondConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_SecondSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_SecondSelection.IsEnabled = false;
                }
            }
        }

        private void btn_ThirdConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_ThirdSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_ThirdSelection.IsEnabled = false;
                }
            }
        }

        private void btn_FourthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_FourthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_FourthSelection.IsEnabled = false;
                }
            }
        }

        private void btn_FifthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_FifthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_FifthSelection.IsEnabled = false;
                }
            }
        }

        private void btn_SixthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_SixthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_SixthSelection.IsEnabled = false;
                }
            }
        }

        private void btn_SeventhConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_SeventhSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_SeventhSelection.IsEnabled = false;
                }
            }
        }

        private void btn_EighthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_EighthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_EighthSelection.IsEnabled = false;
                }
            }
        }

        private void btn_NinthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_NinthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_NinthSelection.IsEnabled = false;
                }
            }
        }

        private void btn_TenthConnect_Click(object sender, RoutedEventArgs e)
        {
            selectedPlatform = cmb_TenthSelection.SelectedIndex;

            //If the selected option is '*Select Platform*' then display an error message to the user
            if (selectedPlatform == 0)
            {
                MessageBox.Show("Please select a platform", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else
            {
                //If the selected platform has already been connected to in another row then display an error message
                if (currentSelections.Contains(selectedPlatform))
                {
                    MessageBox.Show("You have already connected to this platform in another row", "Already connected", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    //Add the current selection to the list
                    currentSelections.Add(selectedPlatform);
                    cmb_TenthSelection.IsEnabled = false;
                }
            }
        }
    }
}
