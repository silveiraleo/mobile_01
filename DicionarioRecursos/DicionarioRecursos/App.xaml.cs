using System.Diagnostics;

namespace DicionarioRecursos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new MainPage()));
    }

    public void SetTheme(string theme)
    {
        Debug.WriteLine($"Trocando tema para: {theme}");

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
