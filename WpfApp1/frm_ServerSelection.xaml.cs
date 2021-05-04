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
    /// Interaction logic for frm_ServerSelection.xaml
    /// </summary>
    public partial class frm_ServerSelection : Window
    {
        List<RecentLocationData> lstRecentLocationData = new List<RecentLocationData>();

        /// <summary>
        /// Initializes a new instance of the frm_ServerSelection class.
        /// </summary>
        public frm_ServerSelection()
        {
            InitializeComponent();
            SetStyleOnStartUp();

            //// NOTE : Here demo items are added for display purpose, please fill your own data here for actual scenario.
            RecentLocationData dm = new RecentLocationData();
            dm.strImagePath = "/Icon/flag_1.png";
            dm.strServerName = "USA Servers - Test Server";
            dm.strTime = "";

            lstRecentLocationData.Add(dm);

            RecentLocationData dm1 = new RecentLocationData();
            dm1.strImagePath = "/Icon/flag_1.png";
            dm1.strServerName = "USA Servers - Test Server";
            dm1.strTime = "";

            lstRecentLocationData.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            lstRecentLocation.ItemsSource = lstRecentLocationData;
        }

        private void SetStyleOnStartUp()
        {
            Style style = Application.Current.FindResource("SetServerSelectionButton") as Style;
            btnRecommended.Style = style;
        }

        /// <summary>
        /// Handles the Click event of the BtnRecommended control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnRecommended_Click(object sender, RoutedEventArgs e)
        {
            Style stySetStyle = Application.Current.FindResource("SetServerSelectionButton") as Style;
            Style styResetSetStyle = Application.Current.FindResource("ResetServerSelectionButton") as Style;
            btnRecommended.Style = stySetStyle;
            btnAllLocations.Style = styResetSetStyle;
            lblRecent.Visibility = Visibility.Visible;
            lblAllLocation.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Handles the Click event of the BtnAllLocations control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnAllLocations_Click(object sender, RoutedEventArgs e)
        {
            Style styResetSetStyle = Application.Current.FindResource("ResetServerSelectionButton") as Style;
            Style stySetStyle = Application.Current.FindResource("SetServerSelectionButton") as Style;
            btnAllLocations.Style = stySetStyle;
            btnRecommended.Style = styResetSetStyle;
            lblRecent.Visibility = Visibility.Collapsed;
            lblAllLocation.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Click event of the BtnSmartLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnSmartLocation_Click(object sender, RoutedEventArgs e)
        {
            ////TO DO : Here add code for smart location button click
        }

        /// <summary>
        /// Handles the Click event of the BtnServerSelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnServerSelect_Click(object sender, RoutedEventArgs e)
        {
            frm_CountryServicesList objFrm_CountryServicesList = new frm_CountryServicesList();
            this.Close();
            objFrm_CountryServicesList.Show();
        }
    }
}
