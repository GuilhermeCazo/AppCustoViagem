using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btn_Add_Viagem(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Add_Viagem());
        }

        private void Btn_Lista_Viagem(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista_Viagem());
        }

        private void Btn_Add_Pedagio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Add_Pedagio());
        }

        private void Btn_Lista_Pedagio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista_Pedagio());
        }
    }
}