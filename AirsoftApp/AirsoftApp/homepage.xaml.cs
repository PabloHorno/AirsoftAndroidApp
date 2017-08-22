using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirsoftApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class homepage : ContentPage
	{
        public homepage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_guardar.Clicked += Btn_guardar_Clicked;

        }

        private void Btn_guardar_Clicked(object sender, EventArgs e)
        {
            var nombre = entry_nombre.Text;

            if(!string.IsNullOrEmpty(nombre))
            {
                DisplayAlert("Mensaje de Alerta", nombre, "Aceptar");
                
            }
        }
    }
}