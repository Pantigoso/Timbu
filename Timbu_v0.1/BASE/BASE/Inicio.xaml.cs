using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BASE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio()
		{
			InitializeComponent ();
            BtnIrBT.Clicked += BtnIrBT_Clicked;
            BtnIrIE.Clicked += BtnIrIE_Clicked;
            btnLogOut.Clicked += BtnLogOut_Clicked;
        }
        private void BtnIrBT_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new BaseTecnica());

        }
        private void BtnIrIE_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new IngresoEmisiones());
        }

        private void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new RegistroBoton());
        }
    }
}