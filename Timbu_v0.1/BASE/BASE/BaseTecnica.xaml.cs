using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
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
            btnIrInicio.Clicked += BtnIrInicio_Clicked;
            btnIrIE.Clicked += BtnIrIE_Clicked;
            btnLogOut.Clicked += BtnLogOut_Clicked;
        }
        private void BtnIrInicio_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Inicio());

        }
        private void BtnIrIE_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new IngresoEmisiones());

        }
        private void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new RegistroBoton());
        }

        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Launcher.OpenAsync(new System.Uri(url));
        });
    }
}