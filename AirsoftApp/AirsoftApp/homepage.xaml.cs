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
		public homepage ()
		{
			InitializeComponent ();
		}int count = 0;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_sumar.Clicked += Btn_sumar_Clicked;
        }

        private void Btn_sumar_Clicked(object sender, EventArgs e)
        {
            count++;
            btn_sumar.Text = count.ToString();
        }
    }
}