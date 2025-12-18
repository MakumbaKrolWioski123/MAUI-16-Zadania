using Microsoft.Maui.Controls;

namespace MauiApp13;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
        Stepper1.Value = 1;
        OsobyLabel.Text = $"Liczba Osób: {(int)Stepper1.Value}";

        ObliczButton.Clicked += ObliczButton_Clicked;
        WyczyscButton.Clicked += WyczyscButton_Clicked;
    }

    private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        OsobyLabel.Text = "Liczba Osób: " + ((int)e.NewValue);
    }

    private void ObliczButton_Clicked(object sender, EventArgs e)
    {

        if (!double.TryParse(RachunekEntry.Text, out double rachunek))
        {
            DisplayAlert("B³¹d", "WprowadŸ prawid³ow¹ kwotê rachunku", "OK");
            return;
        }

        double procent = Slider1.Value;
        double napiwek = rachunek * procent / 100;
        double sumaDoZaplaty = rachunek + napiwek;

        int liczbaOsob = (int)Stepper1.Value;
        double kwotaNaOsobe = liczbaOsob > 0 ? sumaDoZaplaty / liczbaOsob : 0;

        NapiwekLabel.Text = "Napiwek: "+napiwek.ToString("F2");
        SumaLabel.Text = "Suma do zap³aty: "+ sumaDoZaplaty.ToString("F2");
        NaOsobeLabel.Text = "Kwota na osobe: " + kwotaNaOsobe.ToString("F2");
    }

    private void WyczyscButton_Clicked(object sender, EventArgs e)
    {
        RachunekEntry.Text = string.Empty;
        Slider1.Value = 0;
        Stepper1.Value = 1;
        NapiwekLabel.Text = "Napiwek: 0.00";
        SumaLabel.Text = "Suma do zap³aty: 0.00";
        NaOsobeLabel.Text = "Kwota na osobe: 0.00";
    }
}
