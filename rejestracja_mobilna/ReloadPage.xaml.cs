using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml; // Dodaj tê dyrektywê using

namespace rejestracja_mobilna;

public partial class ReloadPage : ContentPage
{
	  public ReloadPage(string imie,
						string nazwisko,
						string haslo,
						string wojewodztwo,
						string rola,
						bool czy_18)
	{
		string pelnoletni;
		InitializeComponent();
		if(czy_18==true)
		{
			pelnoletni = "Pe³noletni";
		}
		else
		{
			pelnoletni = "Ma³olat";
		}
		ImieLabel.Text = imie;
		NazwiskoLabel.Text = nazwisko;
		HasloLabel.Text = haslo;
		WojewodztwoLabel.Text = wojewodztwo;
		RolaLabel.Text = rola;
		MalolatLabel.Text = pelnoletni;

    }
}