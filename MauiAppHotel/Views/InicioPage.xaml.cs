namespace MauiAppHotel.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ContratacaoHospedagem());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SobrePage());
    }
}