namespace GorselOdev;

public partial class HavaDurumu : ContentPage
{
    private List<string> cities = new List<string>();
    public HavaDurumu()
	{
		InitializeComponent();
	}
    private void AddButton_Clicked(object sender, EventArgs e)
    {
        CityLabel.IsVisible = true;
        CityEntry.IsVisible = true;
        AddCityButton.IsVisible = true;
    }

    private void AddCityButton_Clicked(object sender, EventArgs e)
    {
        string city = CityEntry.Text;
        cities.Add(city);
        WeatherListView.ItemsSource = cities;
        ClearCityEntry();
    }

    private void ClearCityEntry()
    {
        CityEntry.Text = string.Empty;
    }
}