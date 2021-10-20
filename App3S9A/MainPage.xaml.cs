using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3S9A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Constructor
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try {
                //almacenando en variables lo que usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                //Permite abrir la ventana (viewDos)

                await Navigation.PushAsync(new viewDos(usuario, clave));
            }

            catch(Exception ex){
              await DisplayAlert("Mensaje de advertencia", ex.Message,"OK");
            }


        }
    }
}
