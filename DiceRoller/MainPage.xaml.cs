namespace DiceRoller;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();


		toRoll.Clicked += (s, e) => DiceRoller();

	}

    void DiceRoller()
	{
        int chosenOption = DicePicker.SelectedIndex;

        var rnd = new Random();

		int seila = rnd.Next(1, chosenOption);

		rolledNumber.Text = seila.ToString();
    }
}

