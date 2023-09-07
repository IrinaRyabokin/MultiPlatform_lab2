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

namespace lab2_checkboxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            childItems = new CheckBox[] { CheckBoxItem1, CheckBoxItem2, CheckBoxItem3 };
        }

        private void CheckBoxItem1_Checked(object sender, RoutedEventArgs e)
        {
            int checkedItems = 0;
            foreach(CheckBox item in childItems)
            {
                if (item.IsChecked==true)
                    checkedItems++;
            }

            if (checkedItems == 0)
                CheckBoxAllItems.IsChecked = false;
            else if (checkedItems == childItems.Length)
                CheckBoxAllItems.IsChecked = true;
            else
                CheckBoxAllItems.IsChecked = null;
        }

        private CheckBox[] childItems;

        private void CheckBoxAllItems_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxAllItems.IsChecked == null)
                return;

            foreach (CheckBox item in childItems)
                item.IsChecked = CheckBoxAllItems.IsChecked == true;
        }
    }
}
