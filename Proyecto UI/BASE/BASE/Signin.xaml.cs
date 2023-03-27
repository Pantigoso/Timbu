using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BASE
{
    public partial class Signin : ContentPage
    {
        public Signin()
        {
            InitializeComponent();
            btnRegistro.Clicked += BtnRegistro_Clicked;
        }

        private void BtnRegistro_Clicked(object sender, EventArgs e)
        {
        ((NavigationPage)this.Parent).PushAsync(new Inicio());

        }
    }
}
