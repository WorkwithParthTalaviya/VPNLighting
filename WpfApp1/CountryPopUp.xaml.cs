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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CountryPopUp.xaml
    /// </summary>
    public partial class CountryPopUp : Window
    {
        /// <summary>
        /// Initializes a new instance of the CountryPopUp class.
        /// </summary>
        public CountryPopUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the BtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the BtnDone control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
