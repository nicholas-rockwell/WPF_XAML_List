using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Practice
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
        string coffee;
        string size;
        private string ComboSelection(string drink, SelectionChangedEventArgs e)
        {

            // Add "using Windows.UI;" for Color and Colors.
            string drinkName = drink;
            switch (drinkName)
            {
                case "Latte":
                    drink = "Latte";
                    break;
                case "Capuccino":
                    drink = "Capuccino";
                    break;
                case "Americano":
                    drink = "Americano";
                    break;
                case "Espresso":
                    drink = "Espresso";
                    break;
            }
            coffee = drink;
            return coffee;
        }

        private string HandleCheck(object sender, RoutedEventArgs e)
        {
            size = "small";
            return size;
        }

        private void orderSummary_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string text = "";
            text += coffee;
            text += size;
            
        }















        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(txtName.Text) && !firstNames.Items.Contains(txtName.Text))
        //    {
        //        firstNames.Items.Add(txtName.Text);
        //        txtName.Clear();
        //    }
        //    else if (string.IsNullOrWhiteSpace(txtName.Text))
        //    {
        //        Debug.WriteLine("A name was not entered");
        //    }
        //}
    }
}
