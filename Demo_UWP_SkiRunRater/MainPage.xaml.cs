using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Demo_UWP_SkiRunRater;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo_UWP_SkiRunRater
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<SkiRun> SkiRuns;

        public MainPage()
        {
            this.InitializeComponent();
            SkiRuns = SkiRunManager.GetSkiRuns();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var skiRun = (SkiRun)e.ClickedItem;
            ResultTextBlock.Text = $"You selected {skiRun.Name}";

            BitmapImage bitmapImage = new BitmapImage(new Uri(this.BaseUri, $"/{skiRun.SkiRunImage}"));
            SkiRunImage.Source = bitmapImage;
        }
    }
}
