using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using Xamarin.Forms;

namespace DNavarreteS6
{
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        void bntInsertar_Clicked(System.Object sender, System.EventArgs e)
        {

            WebClient cliente = new WebClient();
            try
            {
                var parametros = new NameValueCollection();
                parametros.Add("codigo", txtId.Text);
                parametros.Add("nombre", txtnombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
                cliente.UploadValues("http://eyecomers.com/estudiante.php", "POST", parametros);
                DisplayAlert("Mensaje", "Se registro el estudiante " +txtnombre.Text+ " " +txtApellido.Text, "Cerrar");
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
       
        }

        void bntRegresar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Estudiante());
        }
    }
}

