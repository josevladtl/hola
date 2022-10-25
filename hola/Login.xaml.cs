using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hola
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "vladi";
            string contrasena = "1234";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;

            if (usuario == tUsuario & contrasena == tContrasena)
            {
                DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");
            }

      
        }
    }
}