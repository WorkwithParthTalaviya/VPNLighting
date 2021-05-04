using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        /// <summary>
        /// Login constructor.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            OnStartUp();
        }

        /// <summary>
        /// on click of hyperlink
        /// </summary>
        /// <param name="sender">obj sender</param>
        /// <param name="e">event args param</param>
        private void LnkSite_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
        }

        /// <summary>
        /// call on startup to set values of variables
        /// </summary>
        private void OnStartUp()
        {
            try
            {
                ////NOTE : Please assign this in startup.
                lnkSite.NavigateUri = null;
                lnkSite.NavigateUri = new Uri("https://www.vpnlighting.com");
                lnkSite.Inlines.Clear();
                lnkSite.Inlines.Add("www.vpnlighting.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "OnStartUp", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            ////NOTE : this is for display puppose only, please change according to Req in future.
            frm_ConnectionPage frmCon = new frm_ConnectionPage();
            this.Close();
            frmCon.Show();
            ////CountryPopUp temp = new CountryPopUp();
            ////temp.Owner = this;
            ////temp.ShowDialog();
        }
    }
}
