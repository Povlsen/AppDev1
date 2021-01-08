using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDev1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblContact.Text = "Kontakt:\nNikolaiPovlsen@yahoo.dk\n+45 60 48 23 70";

            var tgr = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
            tgr.TappedCallback = (sender, args) =>
            {
                ToList(sender, (EventArgs)args);
            };
            gridMain.GestureRecognizers.Add(tgr);
        }

        async void ToList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LVPage());
        }
    }
}
