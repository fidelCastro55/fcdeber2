using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fcdeber2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("estudiante2021") && txtPassword.Text.Equals("uisrael2021"))
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("ALERTA", "Contraseña o usuario incorrecto","entendido");
                }
            }
            catch (Exception) { }
        }
    }
}