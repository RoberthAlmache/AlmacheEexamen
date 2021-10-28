using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlmacheEexamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //enviar datos como parametros y almacenar en variables
            string usuario = txtUsuario.Text; //estudiante2021   credenciales quemadas y que permiten el acceso a la siguiente ventana.
            string contraseña = txtContraseña.Text; //uisrael2021

            if (usuario == "estudiante2021" && contraseña == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario, contraseña));

            }
            else
            {
                await DisplayAlert("Advertencia.!", "Ingrese las credenciales correctas.", "OK");
            }

        }
    }
}