using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectDMI
{
    /// <summary>
    /// Interaction logic for CarPage.xaml
    /// </summary>
    public partial class CarPage : Page
    {
        Policy newPolicy1;
        public CarPage()
        {           
            InitializeComponent();          
        }

        public void AddDriverbutton_Click(object sender, RoutedEventArgs e)
        {
            newPolicy1.AddDriver(DriverNameText.Text, DriverOccupationComboBox.SelectedValue.ToString(), DriverDOBDatePicker.SelectedDate.Value);
            AddDriverToListbox();
        }

        private void AddDriverToListbox()
        {
            DriverListBox.Items.Clear();
            foreach (Driver driver in newPolicy1.GetDrivers())
            {
                DriverListBox.Items.Add(driver.Name);
            }
        }

        private void DriverListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Claim2TextBlock.Text = DriverListBox.SelectedValue.ToString();
        }

        private void AddClaimbutton_Click(object sender, RoutedEventArgs e)
        {
            //ClaimListBox.Items.Add(DriverDOBDatePicker.SelectedDate.Value.Date);
            newPolicy1.addClaimDate(DriverDOBDatePicker.SelectedDate.Value.Date);
        }

        private void CreatePolicy_Click(object sender, RoutedEventArgs e)
        {
            Policy newPolicy = new Policy(DriverNameText.Text, DriverOccupationComboBox.SelectedValue.ToString(), DriverDOBDatePicker.SelectedDate.Value);
            newPolicy1 = newPolicy;
            //newPolicy1.AddDriver(DriverNameText.Text, DriverOccupationComboBox.SelectedValue.ToString(), DriverDOBDatePicker.SelectedDate.Value);
            newPolicy1.StartDate = PolicyDatePicker.SelectedDate.Value;
            AddDriverToListbox();
        }
    }
}
