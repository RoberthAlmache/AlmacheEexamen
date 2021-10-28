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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario = "estudiante2021", string contraseña = "uisrael2021")
        {
            InitializeComponent();

            lblUsuario.Text = usuario;


        }



        private void btnCuotas_Clicked(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(txtMIni.Text);

            double cuotas1 = 1800 - valor1;
            double cuotas2 = cuotas1 / 3; // valor de 266,66

            double cuotas3 = 1800 * 0.05; // interes 5%
            double cuotas4 = cuotas2 + cuotas3;
            double total = valor1 + cuotas4 * 3;



            txtCuota1.Text = cuotas4.ToString();
            txtCuota2.Text = cuotas4.ToString();
            txtCuota3.Text = cuotas4.ToString();
            txtTotPag.Text = total.ToString();
            // txtTotalPagar.Text = cuotas4.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            string nombre = txtNEst.Text;
            string total = txtTotPag.Text;

            //txtTotPag.Text = valor1.ToString();
            //double valor1 = Convert.ToDouble(txtTotPag.Text);

            await DisplayAlert("Registro Correcto.", "Elemento guardado con éxito.!", "Continuar");
            await Navigation.PushAsync(new Resumen(nombre, total));


        }
    }
}