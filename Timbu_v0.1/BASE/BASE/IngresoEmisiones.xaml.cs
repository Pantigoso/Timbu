using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace BASE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IngresoEmisiones : ContentPage
	{
		public IngresoEmisiones()
		{
			InitializeComponent ();
            BtnIrBT.Clicked += BtnIrBT_Clicked;
            BtnIrInicio.Clicked += BtnIrInicio_Clicked;



        }
        private void BtnIrBT_Clicked(object sender, EventArgs e)
        {
            ((Xamarin.Forms.NavigationPage)this.Parent).PushAsync(new BaseTecnica());

        }
        private void BtnIrInicio_Clicked(object sender, EventArgs e)
        {
            ((Xamarin.Forms.NavigationPage)this.Parent).PushAsync(new Inicio());

        }

    }
}