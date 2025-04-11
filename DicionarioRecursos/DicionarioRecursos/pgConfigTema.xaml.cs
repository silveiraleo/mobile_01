namespace DicionarioRecursos;

public partial class pgConfigTema : ContentPage
{
    public pgConfigTema()
    {
        InitializeComponent();
    }

    private void btnClaroClicked(object sender, EventArgs e)
    {
        (Application.Current as App)?.SetTheme("Light");
    }

    private void btnEscuroClicked(object sender, EventArgs e)
    {
        (Application.Current as App)?.SetTheme("Dark");
    }

    private async void btnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
