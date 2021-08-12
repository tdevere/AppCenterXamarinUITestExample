using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatSampleForUITest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UITestPage : ContentPage
    {
        public UITestPage()
        {
            InitializeComponent();
        }

        public void tstBtnTest_OnClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Button Clicked";
        }
    }
}