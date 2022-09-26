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
    public partial class Add_Viagem : ContentPage
    {
        public Add_Viagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked_Pedagios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista_Pedagio());
        }
        private void ToolbarItem_Clicked_Somar(object sender, EventArgs e)
        {
        
        }
        private void ToolbarItem_Clicked_Salvar(object sender, EventArgs e)
        { 
        
        }



        private void Btn_Voltar_Inicio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicio());
        }

        
    }
}