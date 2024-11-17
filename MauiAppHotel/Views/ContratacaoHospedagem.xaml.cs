namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Avancar(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_Sobre(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());

        }  catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }

    }
}