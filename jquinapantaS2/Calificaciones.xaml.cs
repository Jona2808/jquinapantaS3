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
    public partial class Calificaciones : ContentPage
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //Parcial 1
            double notaUno = Convert.ToDouble(txtNotaSeg1.Text) * 0.3;
            double examUno = Convert.ToDouble(txtExam1.Text) * 0.2;
            double resultado1 = notaUno + examUno;
            txtResu1.Text = resultado1.ToString();

            //Parcial 2
            double notaDos = Convert.ToDouble(txtNotaSeg2.Text) * 0.3;
            double examDos = Convert.ToDouble(txtExam2.Text) * 0.2;
            double resultado2 = notaDos + examDos;
            txtResu2.Text = resultado2.ToString();

            double sumatoria = resultado1 + resultado2;
            if (sumatoria>=7) {
                DisplayAlert("RESULTADO", "APROBADO", "Cerrar");
                lblResultado.Text = "APROBADO = " + sumatoria.ToString();
            }
            if ((sumatoria >= 5) && (sumatoria <= 6.9))
            {
                DisplayAlert("RESULTADO", "COMPLEMENTARIO", "Cerrar");
                lblResultado.Text = "COMPLEMENTARIO = " + sumatoria.ToString();
            }
            if (sumatoria < 5)
            {
                DisplayAlert("RESULTADO", "REPROBADO", "Cerrar");
                lblResultado.Text = "REPROBADO = " + sumatoria.ToString();
            }
            
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNotaSeg1.Text = "";
            txtExam1.Text = "";
            txtResu1.Text = "";
            txtNotaSeg2.Text = "";
            txtExam2.Text = "";
            txtResu2.Text = "";
            lblResultado.Text = "";
        }

        private void txtNotaSeg2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nSeg2 = txtNotaSeg2.Text;
            try
            {
                double nt2 = Double.Parse(nSeg2);
                if (nt2 < 0 || nt2 > 10.00)
                {

                    txtNotaSeg2.Text = e.OldTextValue.ToString();

                }
            }
            catch
            {
                return;
            }      
        }

        private void txtNotaSeg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nSeg1 = txtNotaSeg1.Text;
            try
            {
                double nt1 = Double.Parse(nSeg1);
                if (nt1 < 0 || nt1 > 10.00)
                {

                    txtNotaSeg1.Text = e.OldTextValue.ToString();

                }
            }
            catch
            {
                return;
            }
        }

        private void txtExam1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nEx1 = txtExam1.Text;
            try
            {
                double nE1 = Double.Parse(nEx1);
                if (nE1 < 0 || nE1 > 10.00)
                {

                    txtExam1.Text = e.OldTextValue.ToString();

                }
            }
            catch
            {
                return;
            }
        }

        private void txtExam2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nEx2 = txtExam2.Text;
            try
            {
                double nE2 = Double.Parse(nEx2);
                if (nE2 < 0 || nE2 > 10.00)
                {

                    txtExam2.Text = e.OldTextValue.ToString();

                }
            }
            catch
            {
                return;
            }
        }
    }
}