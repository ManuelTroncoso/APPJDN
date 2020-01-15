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
    public partial class Description : ContentPage
    {
        public string mTypeForms;
        public Description(string pButtonId)
        {
            InitializeComponent();
            mTypeForms = pButtonId;
        }
        protected override void OnAppearing()
        {
            if (mTypeForms == Constant.CREATE)
                TB_Desc.IsReadOnly = false;
            if (mTypeForms == Constant.MODYFY)
                TB_Desc.IsReadOnly = false;
            if (mTypeForms == Constant.SHOW)
                TB_Desc.IsReadOnly = true;
        }
    }
}