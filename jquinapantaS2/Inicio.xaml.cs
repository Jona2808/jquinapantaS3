using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jquinapantaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIngreso_Clicked(object sender, EventArgs e)
        {
            const String usuario1 = "2023";
            const String pass1 = "2023";
            if ((txtUsuario.Text == usuario1) && (txtContra.Text == pass1))
            {
                DisplayAlert("UISRAEL", "BIENVENIDO " +usuario1, "Cerrar");
                Navigation.PushAsync(new Calificaciones(usuario1));
            }
            if ((txtUsuario.Text != usuario1) && (txtContra.Text == pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "USUARIO INCORRECTO" , "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
            if ((txtUsuario.Text == usuario1) && (txtContra.Text != pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "CONTRASENA INCORRECTA", "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
            if ((txtUsuario.Text != usuario1) && (txtContra.Text != pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "USUARIO Y CONTRASENA INCORRECTOS", "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
        }
    }
}