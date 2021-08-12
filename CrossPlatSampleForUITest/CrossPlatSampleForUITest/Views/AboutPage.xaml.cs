using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatSampleForUITest.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public void tstBtnTest_OnClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Button Clicked";
        }
    }
}