using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XavierImbaquingo
{

    public partial class MainPage : ContentPage



    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "Xavier2022";
            string Contrasena = "uisrael2022";

            string TUsuario = txtUsuario.Text;
            string TContrasena = txtContraseña.Text;

            if (usuario == TUsuario & Contrasena == TContrasena)
            {
                await Navigation.PushAsync(new Registro(usuario));
                await DisplayAlert("Ingreso Exitoso !", "Datos Válidos para !!" + usuario, "Cerrar");




            }
            else
            {
                await DisplayAlert("Error !", "Usuario o Contraseña Incorrecta", "Cerrar");
            }

        }
    }
}
        
        

        
    

