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
		}int count_chicas = 0, count_chicos = 0;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_chicas.Clicked += Btn_chicas_Clicked;
            btn_chicos.Clicked += Btn_chicos_Clicked;
        }

        private void Btn_chicos_Clicked(object sender, EventArgs e)
        {
            count_chicos++;
            lbl_chicos.Text = count_chicos.ToString();
        }

        private void Btn_chicas_Clicked(object sender, EventArgs e)
        {
            count_chicas++;
            lbl_chicas.Text = count_chicas.ToString();
        }
    }
}