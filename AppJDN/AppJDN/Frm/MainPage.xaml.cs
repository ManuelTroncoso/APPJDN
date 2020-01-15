using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppJDN.Const;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJDN.Frm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Description(Constant.CREATE));
        }
        private async void Modify_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Description(Constant.MODYFY));
        }
        private async void Show_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllActivity());
        }
    }
}