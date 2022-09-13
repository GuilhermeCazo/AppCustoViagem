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
    public partial class Lista_Pedagio : ContentPage
    {
        public Lista_Pedagio()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Inicio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicio());
        }
    }
}