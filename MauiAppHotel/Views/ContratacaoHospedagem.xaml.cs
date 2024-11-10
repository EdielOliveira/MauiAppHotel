namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_chekin.MinimumDate = DateTime.Now;
        dtpck_chekin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        dtpck_chekout.MinimumDate = dtpck_chekin.Date.AddDays(1);
        dtpck_chekout.MaximumDate = dtpck_chekin.Date.AddMonths(6);
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratado());
        }
        catch (Exception ex) {
            DisplayAlert("Ops", ex.Message, "Ok");
        }

    }

    private void dtpck_chekin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_chekin = elemento.Date;

        dtpck_chekout.MinimumDate = data_selecionada_chekin.AddDays(1);
        dtpck_chekout.MaximumDate = data_selecionada_chekin.AddMonths(6);
    }
}