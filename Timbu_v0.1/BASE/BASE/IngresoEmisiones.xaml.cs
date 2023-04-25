using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using BASE.Model;
using System.Diagnostics;

namespace BASE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IngresoEmisiones : ContentPage
	{
		public IngresoEmisiones()
		{
			InitializeComponent ();
            btnIrBT.Clicked += BtnIrBT_Clicked;
            btnIrInicio.Clicked += BtnIrInicio_Clicked;
            btnAgregarActividad.Clicked += BtnAgregarActividad_Clicked;
            btnVerResult.Clicked += BtnVerResult_Clicked;
            btnLogOut.Clicked += BtnLogOut_Clicked;
        }

        private void BtnVerResult_Clicked(object sender, EventArgs e)
        {
            var allEmisions = EmisionRepository.Instancia.GetAllEmisions();
            emisionList.ItemsSource = allEmisions;
            StatusMessage.Text = EmisionRepository.Instancia.EstadoMensaje;
        }

        private void BtnAgregarActividad_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            bool tipoActividad = false;
            if (entryActividad.Text == "Oficina") tipoActividad = false;
            else if (entryActividad.Text == "Vehiculo") tipoActividad = true;
            else
            {
                Debug.WriteLine("ERROR: Tipo de actividad incorrecto.");
            }
            CalculaImpacto(tipoActividad);
            EmisionRepository.Instancia.AddNewEmision(entryFecha.Date, Convert.ToInt32(entryValor.Text), entryActividad.Text, Convert.ToInt32(entryPotencial.Text), Convert.ToInt32(valHuella.Text));
            StatusMessage.Text = EmisionRepository.Instancia.EstadoMensaje; //Debug
            entryValor.Text = "";
            entryPotencial.Text = "";
        }

        private void BtnIrBT_Clicked(object sender, EventArgs e)
        {
            ((Xamarin.Forms.NavigationPage)this.Parent).PushAsync(new BaseTecnica());

        }
        private void BtnIrInicio_Clicked(object sender, EventArgs e)
        {
            ((Xamarin.Forms.NavigationPage)this.Parent).PushAsync(new Inicio());

        }
        private void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            ((Xamarin.Forms.NavigationPage)this.Parent).PushAsync(new RegistroBoton());
        }

        public System.Collections.IList ItemsSource { get; set; }

        private void CalculaImpacto(bool activityType)
        {
            Int32 valTipoActividad = 0;
            if(activityType)
            {
                valTipoActividad = 300;
            } else if(activityType == false)
            {
                valTipoActividad = 2700;
            }
            Int32 numHuellaCarbono = Int32.Parse(entryValor.Text) * Int32.Parse(entryPotencial.Text) * valTipoActividad;
            valHuella.Text = numHuellaCarbono.ToString();
        }

    }
}