namespace DicionarioRecursos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Abre a tela de configurações diretamente
        return new Window(new NavigationPage(new pgConfigTema()));
    }

    public void SetTheme(string theme)
    {
        Application.Current.Resources.MergedDictionaries.Clear();

        if (theme == "Light")
        {
            Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else if (theme == "Dark")
        {
            Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
            Application.Current.UserAppTheme = AppTheme.Dark;
        }

        Application.Current.Resources.MergedDictionaries.Add(new Styles());
    }
}
