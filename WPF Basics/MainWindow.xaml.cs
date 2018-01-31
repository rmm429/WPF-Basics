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

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            //Showing a MessageBox with the Text of the TextBox DescriptionText
            MessageBox.Show($"The description is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //Changing all Check Boxes to unchecked when the Reset Button is clicked
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked =
                this.LatheCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.RollCheckBox.IsChecked = this.SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Appending to the text of TextBox LengthText the Content of the CheckBox that was checked
            this.LengthText.Text += (string)((CheckBox)sender).Content; //Casting the sender as a CheckBox and casting the Content as a string
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Checking if the TextBox NoteText is null
            if (this.NoteText == null)
                return;

            //Storing the sent ComboBox in the variable combo
            var combo = (ComboBox)sender; // casting the sender as a ComboBox

            //Storing the Selected Value of combo in the varible value
            var value = (ComboBoxItem)combo.SelectedValue; //Casting the SelectedValue of combo as a ComboBoxItem

            //Setting the text of TextBox LengthText to the variable value
            this.NoteText.Text = (string)value.Content; //Casting the Content of value as a String
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Calling the FinishDropdown_SelectionChanged() function upon window load with parameters FinishDropDown and null
            FinishDropdown_SelectionChanged(this.FinishDropDown, null); //Setting the text of the TextBox LengthText to the auto-selected SelectedVale of the ComboBox FinishDropDown upon window load
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Copies the text form the TextBox SupplierNameText and places it in the TextBox MassText
            this.MassText.Text = this.SupplierNameText.Text;
        }
    }
}
