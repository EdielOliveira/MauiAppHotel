using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class SobrePage : ContentPage
    {
        public SobrePage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Volta para a página anterior
        }
    }
}