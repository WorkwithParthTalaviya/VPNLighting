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
    /// Interaction logic for frm_CountryServicesList.xaml
    /// </summary>
    public partial class frm_CountryServicesList : Window
    {
        List<RecentLocationData> lstCountrywiseLocations = new List<RecentLocationData>();

        /// <summary>
        /// Initializes a new instance of the frm_CountryServicesList class.
        /// </summary>
        public frm_CountryServicesList()
        {
            InitializeComponent();

            RecentLocationData dm = new RecentLocationData();
            dm.strImagePath = "/Icon/flag_1.png";
            dm.strServerName = "Test Server";
            dm.strTime = "309MS";

            lstCountrywiseLocations.Add(dm);

            RecentLocationData dm1 = new RecentLocationData();
            dm1.strImagePath = "/Icon/flag_1.png";
            dm1.strServerName = "Belgium";
            dm1.strTime = "313MS";

            lstCountrywiseLocations.Add(dm1);

            RecentLocationData dm2 = new RecentLocationData();
            dm2.strImagePath = "/Icon/flag_1.png";
            dm2.strServerName = "France";
            dm2.strTime = "313MS";

            lstCountrywiseLocations.Add(dm2);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            ////lst.Add(dm1);
            lstbxCountrywiseLocations.ItemsSource = lstCountrywiseLocations;
        }

        /// <summary>
        /// Handles the MouseRightButtonDown event of the LblServerSelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void LblServerSelect_Click(object sender, MouseButtonEventArgs e)
        {
            CountryPopUp cp = new CountryPopUp();
            cp.Owner = this;
            cp.ShowDialog();
        }

        /// <summary>
        /// Handles the MouseDown event of the Uc_SelectLocation control.
        /// NOTE : For not its used for displying next screen
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The MouseButtonEventArgs instance containing the event data.</param>
        private void Uc_SelectLocation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frm_Settings ObjFrm_Settings = new frm_Settings();
            ObjFrm_Settings.Show();
            this.Close();
        }
    }
}
