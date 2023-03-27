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
	public partial class BaseTecnica : ContentPage
	{
		public BaseTecnica()
		{
			InitializeComponent ();
            BtnIrInicio.Clicked += BtnIrInicio_Clicked;
            BtnIrIE.Clicked += BtnIrIE_Clicked;
        }
        private void BtnIrInicio_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Inicio());

        }
        private void BtnIrIE_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new IngresoEmisiones());

        }
    }
}