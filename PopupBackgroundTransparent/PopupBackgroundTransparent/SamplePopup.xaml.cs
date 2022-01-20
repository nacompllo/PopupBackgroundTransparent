using System;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupBackgroundTransparent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SamplePopup : Popup
    {
        public SamplePopup()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}