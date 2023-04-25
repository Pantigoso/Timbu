using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BASE.Model;

namespace BASE
{
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
            btnRegistro.Clicked += BtnRegistro_Clicked;
        }

        private void BtnRegistro_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            UserRepository.Instancia.AddNewUser(usr.Text, nmb.Text, apll.Text, pwd.Text);
            StatusMessage.Text = UserRepository.Instancia.EstadoMensaje;
            usr.Text = "";
            nmb.Text = "";
            apll.Text = "";
            pwd.Text = "";
            ((NavigationPage)this.Parent).PushAsync(new Inicio());
        }
    }
}
