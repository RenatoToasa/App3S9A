using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3S9A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;

        }
    }
}