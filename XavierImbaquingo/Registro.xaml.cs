using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XavierImbaquingo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //string nombre = txtNombre.Text;
            double MontoInicial = Convert.ToDouble (txtMontoInicial.Text);
            double PagoMensual = 3000- MontoInicial;
            
            double  Calular = (PagoMensual/5)*1.05;

            txtCuotaMensual.Text = Calular.ToString();

            DisplayAlert("Mesaje de alerta", Calular.ToString(), "Guardar");




        }
    }
}