using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BASE
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            BtnIr.Clicked += BtnIr_Clicked;
        }

        private void BtnIr_Clicked(object sender, EventArgs e)
        {
        ((NavigationPage)this.Parent).PushAsync(new Inicio());

        }
    }
}
