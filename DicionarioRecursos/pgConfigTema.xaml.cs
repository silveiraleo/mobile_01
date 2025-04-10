namespace DicionarioRecursos;

public partial class pgConfigTema : ContentPage
{
    public pgConfigTema()
    {
        InitializeComponent();
    }

    private void OnLightThemeClicked(object sender, EventArgs e)
    {
        (Application.Current as App)?.SetTheme("Light");
    }

    private void OnDarkThemeClicked(object sender, EventArgs e)
    {
        (Application.Current as App)?.SetTheme("Dark");
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
