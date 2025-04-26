using Microsoft.Maui.Controls;

namespace AppCombustivel
{
    public partial class PáginaPrincipal : ContentPage
    {
        public PáginaPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Obtenha os valores dos campos
            if (double.TryParse(txt_etanol.Text, out double precoEtanol) &&
                double.TryParse(txt_gasolina.Text, out double precoGasolina))
            {
                // Calcule qual combustível compensa mais
                string resultado = precoEtanol / precoGasolina <= 0.7
                    ? "Abasteça com Etanol"
                    : "Abasteça com Gasolina";

                // Exiba o resultado
                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Erro", "Por favor, insira valores válidos para os preços.", "OK");
            }
        }
    }
}