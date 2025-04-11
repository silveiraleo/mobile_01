namespace DicionarioRecursos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnConfigTemaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pgConfigTema());
    }
}
