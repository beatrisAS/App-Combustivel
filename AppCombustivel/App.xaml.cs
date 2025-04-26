using Microsoft.Maui.Controls;

namespace AppCombustivel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Defina a PáginaPrincipal como a página inicial
        return new Window(new NavigationPage(new PáginaPrincipal()));
    }
}