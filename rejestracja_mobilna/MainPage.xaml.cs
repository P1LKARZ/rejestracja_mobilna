namespace rejestracja_mobilna
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void wyslij(object sender, EventArgs e)
        {
            string imie = ImieEntry.Text;
            string nazwisko = NazwiskoEntry.Text;
            string haslo = HasloEntry.Text;
            string wojewodztwo = (string)wojewodztwaPicker.SelectedItem;
            string rola = (string)rolaPicker.SelectedItem;
            bool czy_18 = ageCheckBox.IsChecked;
            if (imie == null || nazwisko == null || haslo == null || wojewodztwo == null || rola == null)
            {
                wynik.Text = "Uzupełnij wszystkie wartosci";
            }
            else
            {
                await Navigation.PushAsync(new ReloadPage(imie, nazwisko, haslo, wojewodztwo, rola, czy_18));//przejscie na 2 strone
            }
        }
    }

}
