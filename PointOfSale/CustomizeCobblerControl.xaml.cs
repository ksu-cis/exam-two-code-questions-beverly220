using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        /// <summary>
        /// Creates a CustomizeCobblerControl instance
        /// </summary>
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            PeachWCream.Click += OnAddPeachCreamClicked;
            PeachWOCream.Click += OnAddPeachWithoutCreamClicked;
            BlueWCream.Click += OnAddBlueCreamClicked;
            BlueWOCream.Click += OnAddBlueWithoutCreamClicked;
            CherryWCream.Click += OnAddCherryCreamClicked;
            CherryWOCream.Click += OnAddCherryWithoutCreamClicked;
        }

        /// <summary>
        /// Handles if the Peach with Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPeachCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if(DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Peach;
                c.WithIceCream = true;
            }
        }

        /// <summary>
        /// Handles if the Peach without Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPeachWithoutCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if (DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Peach;
                c.WithIceCream = false;
            }
        }

        /// <summary>
        /// Handles if the Cherry with Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCherryCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if (DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Cherry;
                c.WithIceCream = true;
            }
        }

        /// <summary>
        /// Handles if the Cherry without Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCherryWithoutCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if (DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Cherry;
                c.WithIceCream = false;
            }
        }

        /// <summary>
        /// Handles if the Blueberry with Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddBlueCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if (DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Blueberry;
                c.WithIceCream = true;
            }
        }

        /// <summary>
        /// Handles if the Blueberry with Cream Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddBlueWithoutCreamClicked(object sender, RoutedEventArgs e) {
            DataContext = new Cobbler();
            if (DataContext is Cobbler c) {
                c.Fruit = FruitFilling.Blueberry;
                c.WithIceCream = false;
            }
        }

    }
}
