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
    /// Interaction logic for frm_Settings.xaml
    /// </summary>
    public partial class frm_Settings : Window
    {
        List<KillSwitchAppData> lstKillSwitchAppData = new List<KillSwitchAppData>();

        /// <summary>
        /// Initializes a new instance of the frm_Settings class.
        /// </summary>
        public frm_Settings()
        {
            InitializeComponent();
            grdGeneral.Visibility = Visibility.Visible;
            SetTabVisibility(ClsEnum.Tabs.GENERAL);

            KillSwitchAppData dm = new KillSwitchAppData();
            dm.strImagePath = "/Icon/Chrome.png";
            dm.strAppName = "Google Chrome";

            lstKillSwitchAppData.Add(dm);
            lstKillSwitchAppData.Add(dm);
            lstKillSwitchAppData.Add(dm);
            lstKillSwitchAppData.Add(dm);
            lstKillSwitchAppData.Add(dm);

            lstAppList.ItemsSource = lstKillSwitchAppData;
            lstAppList1.ItemsSource = lstKillSwitchAppData;
            //#4EB8EA
        }


        /// <summary>
        /// Handles the Click event of the BtnGeneral control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnGeneral_Click(object sender, RoutedEventArgs e)
        {
            SetTabVisibility(ClsEnum.Tabs.GENERAL);
        }

        /// <summary>
        /// Handles the Click event of the BtnAutoConnect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnAutoConnect_Click(object sender, RoutedEventArgs e)
        {
            SetTabVisibility(ClsEnum.Tabs.AUTO_CONNECT);
        }

        /// <summary>
        /// Handles the Click event of the BtnKillSwitch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnKillSwitch_Click(object sender, RoutedEventArgs e)
        {
            SetTabVisibility(ClsEnum.Tabs.KILL_SWITCH);
        }

        /// <summary>
        /// Handles the Click event of the BtnSplitTunneling control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnSplitTunneling_Click(object sender, RoutedEventArgs e)
        {
            SetTabVisibility(ClsEnum.Tabs.SPLIT_TUNNELING);
        }

        /// <summary>
        /// Handles the Click event of the BtnAdvanced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnAdvanced_Click(object sender, RoutedEventArgs e)
        {
            SetTabVisibility(ClsEnum.Tabs.ADVANCE);
        }

        /// <summary>
        /// Sets the tab visibility.
        /// </summary>
        /// <param name="objTabs">tab to be selected</param>
        private void SetTabVisibility(ClsEnum.Tabs objTabs)
        {
            try
            {
                switch (objTabs)
                {
                    case ClsEnum.Tabs.GENERAL:
                        grdGeneral.Visibility = Visibility.Visible;
                        grdAutoConnect.Visibility = Visibility.Collapsed;
                        grdKillSwitch.Visibility = Visibility.Collapsed;
                        grdSplitTunneling.Visibility = Visibility.Collapsed;
                        grdAdvanced.Visibility = Visibility.Collapsed;
                        lblLine1.Visibility = Visibility.Visible;
                        lblLine2.Visibility = Visibility.Collapsed;
                        lblLine3.Visibility = Visibility.Collapsed;
                        lblLine4.Visibility = Visibility.Collapsed;
                        lblLine5.Visibility = Visibility.Collapsed;
                        break;
                    case ClsEnum.Tabs.AUTO_CONNECT:
                        grdGeneral.Visibility = Visibility.Collapsed;
                        grdAutoConnect.Visibility = Visibility.Visible;
                        grdKillSwitch.Visibility = Visibility.Collapsed;
                        grdSplitTunneling.Visibility = Visibility.Collapsed;
                        grdAdvanced.Visibility = Visibility.Collapsed;
                        lblLine1.Visibility = Visibility.Collapsed;
                        lblLine2.Visibility = Visibility.Visible;
                        lblLine3.Visibility = Visibility.Collapsed;
                        lblLine4.Visibility = Visibility.Collapsed;
                        lblLine5.Visibility = Visibility.Collapsed;
                        break;
                    case ClsEnum.Tabs.KILL_SWITCH:
                        grdGeneral.Visibility = Visibility.Collapsed;
                        grdAutoConnect.Visibility = Visibility.Collapsed;
                        grdKillSwitch.Visibility = Visibility.Visible;
                        grdSplitTunneling.Visibility = Visibility.Collapsed;
                        grdAdvanced.Visibility = Visibility.Collapsed;
                        lblLine1.Visibility = Visibility.Collapsed;
                        lblLine2.Visibility = Visibility.Collapsed;
                        lblLine3.Visibility = Visibility.Visible;
                        lblLine4.Visibility = Visibility.Collapsed;
                        lblLine5.Visibility = Visibility.Collapsed;
                        break;
                    case ClsEnum.Tabs.SPLIT_TUNNELING:
                        grdGeneral.Visibility = Visibility.Collapsed;
                        grdAutoConnect.Visibility = Visibility.Collapsed;
                        grdKillSwitch.Visibility = Visibility.Collapsed;
                        grdSplitTunneling.Visibility = Visibility.Visible;
                        grdAdvanced.Visibility = Visibility.Collapsed;
                        lblLine1.Visibility = Visibility.Collapsed;
                        lblLine2.Visibility = Visibility.Collapsed;
                        lblLine3.Visibility = Visibility.Collapsed;
                        lblLine4.Visibility = Visibility.Visible;
                        lblLine5.Visibility = Visibility.Collapsed;
                        break;
                    case ClsEnum.Tabs.ADVANCE:
                        grdGeneral.Visibility = Visibility.Collapsed;
                        grdAutoConnect.Visibility = Visibility.Collapsed;
                        grdKillSwitch.Visibility = Visibility.Collapsed;
                        grdSplitTunneling.Visibility = Visibility.Collapsed;
                        grdAdvanced.Visibility = Visibility.Visible;
                        lblLine1.Visibility = Visibility.Collapsed;
                        lblLine2.Visibility = Visibility.Collapsed;
                        lblLine3.Visibility = Visibility.Collapsed;
                        lblLine4.Visibility = Visibility.Collapsed;
                        lblLine5.Visibility = Visibility.Visible;
                        break;
                    default:
                        grdGeneral.Visibility = Visibility.Visible;
                        grdAutoConnect.Visibility = Visibility.Collapsed;
                        grdKillSwitch.Visibility = Visibility.Collapsed;
                        grdSplitTunneling.Visibility = Visibility.Collapsed;
                        grdAdvanced.Visibility = Visibility.Collapsed;
                        lblLine1.Visibility = Visibility.Visible;
                        lblLine2.Visibility = Visibility.Collapsed;
                        lblLine3.Visibility = Visibility.Collapsed;
                        lblLine4.Visibility = Visibility.Collapsed;
                        lblLine5.Visibility = Visibility.Collapsed;
                        break;
                }
            }
            catch
            { }
        }
    }
}
