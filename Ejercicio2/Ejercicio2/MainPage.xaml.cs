using Ejercicio2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var resultado = new Person
            {
                Nombre = txtnombre.Text,
                Apellidos = txtapellidos.Text,
                Edad = txtedad.Text,
                Correo = txtcorreo.Text
            };

            var enviar = new Page2();
            enviar.BindingContext = resultado;
            await Navigation.PushAsync(enviar);

        }
    }
}

