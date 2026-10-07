namespace calculadoraGrid;

public partial class MainPage : ContentPage
{
 double primerNumero = 0;
    string operacion = "";
    bool nuevaOperacion = true;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Numero_Clicked(object sender, EventArgs e)
    {
        Button boton = (Button)sender;

        if (nuevaOperacion || Pantalla.Text == "0")
        {
            Pantalla.Text = boton.Text;
            nuevaOperacion = false;
        }
        else
        {
            Pantalla.Text += boton.Text;
        }
    }

    private void Operacion_Clicked(object sender, EventArgs e)
    {
        Button boton = (Button)sender;

        primerNumero = double.Parse(Pantalla.Text);
        operacion = boton.Text;

        nuevaOperacion = true;
    }

    private void Igual_Clicked(object sender, EventArgs e)
    {
        double segundoNumero = double.Parse(Pantalla.Text);
        double resultado = 0;

        switch (operacion)
        {
            case "+":
                resultado = primerNumero + segundoNumero;
                break;

            case "-":
                resultado = primerNumero - segundoNumero;
                break;

            case "×":
                resultado = primerNumero * segundoNumero;
                break;

            case "÷":
                if (segundoNumero == 0)
                {
                    Pantalla.Text = "Error";
                    return;
                }

                resultado = primerNumero / segundoNumero;
                break;
        }

        Pantalla.Text = resultado.ToString();
        nuevaOperacion = true;
    }

    private void Limpiar_Clicked(object sender, EventArgs e)
    {
        Pantalla.Text = "0";
        primerNumero = 0;
        operacion = "";
        nuevaOperacion = true;
    }
}
