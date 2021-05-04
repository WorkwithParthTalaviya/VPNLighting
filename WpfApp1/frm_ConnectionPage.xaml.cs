using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for frm_ConnectionPage.xaml
    /// </summary>
    public partial class frm_ConnectionPage : Window
    {
        ////ImageBrush imgbrs { get; set; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public frm_ConnectionPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Connect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void BtnTapOuter_Click(object sender, RoutedEventArgs e)
        {
            grdConnectionMain.Visibility = Visibility.Collapsed;
            grdConnecting.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Click event of the BtnConnecting control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnConnecting_Click(object sender, RoutedEventArgs e)
        {
            grdConnectionMain.Visibility = Visibility.Collapsed;
            grdConnecting.Visibility = Visibility.Collapsed;
            grdConnected.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Click event of the BtnSmartLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The RoutedEventArgs instance containing the event data.</param>
        private void BtnSmartLocation_Click(object sender, RoutedEventArgs e)
        {
            frm_ServerSelection frm1 = new frm_ServerSelection();
            this.Close();
            frm1.Show();
        }

        ////private void ConnectingImage()
        ////{
        ////    Uri resourceUri = new Uri("Icon/Con_Inner1.png", UriKind.Relative);
        ////    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
        ////    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
        ////    ImageBrush Con_Inner1 = new ImageBrush();
        ////    Con_Inner1.ImageSource = temp;

        ////    resourceUri = new Uri("Icon/Con_Inner2.png", UriKind.Relative);
        ////    streamInfo = Application.GetResourceStream(resourceUri);
        ////    temp = BitmapFrame.Create(streamInfo.Stream);
        ////    ImageBrush Con_Inner2 = new ImageBrush();
        ////    Con_Inner2.ImageSource = temp;

        ////    resourceUri = new Uri("Icon/Con_Outer1.png", UriKind.Relative);
        ////    streamInfo = Application.GetResourceStream(resourceUri);
        ////    temp = BitmapFrame.Create(streamInfo.Stream);
        ////    ImageBrush Con_Outer1 = new ImageBrush();
        ////    Con_Outer1.ImageSource = temp;

        ////    resourceUri = new Uri("Icon/Con_Outer2.png", UriKind.Relative);
        ////    streamInfo = Application.GetResourceStream(resourceUri);
        ////    temp = BitmapFrame.Create(streamInfo.Stream);
        ////    ImageBrush Con_Outer2 = new ImageBrush();
        ////    Con_Outer2.ImageSource = temp;

        ////    int intTryCount = 0;
        ////    int intMaxCount = 300;

        ////    ////btnConnecting.Background = Con_Inner1;
        ////    do
        ////    {
        ////        btnConnecting.Background = Con_Inner1;
        ////        btnConnecting.UpdateLayout();
        ////        btnConnecting.BringIntoView();
        ////        Thread.Sleep(1000);
        ////        btnConnecting.Background = Con_Inner2;
        ////        btnConnecting.UpdateLayout();
        ////        btnConnecting.BringIntoView();
        ////        Thread.Sleep(1000);
        ////        intTryCount++;
        ////    } while (intTryCount < intMaxCount);
        ////    btnConnecting.Background = Con_Inner1;
        ////    ////btnConnecting2.Background = Con_Outer2;
        ////}

        ////private void Demo_Click(object sender, RoutedEventArgs e)
        ////{
        ////    int intTryCount = 0;
        ////    int intMaxCount = 300;
        ////    do
        ////    {
        ////        if (btnConnecting.Content == FindResource("Play"))
        ////        {
        ////            btnConnecting.Content = FindResource("Stop");
        ////        }
        ////        else
        ////        {
        ////            btnConnecting.Content = FindResource("Play");
        ////        }
        ////        intTryCount++;
        ////    } while (intTryCount < intMaxCount);

        ////    ConnectingImage();
        ////}
    }
}
