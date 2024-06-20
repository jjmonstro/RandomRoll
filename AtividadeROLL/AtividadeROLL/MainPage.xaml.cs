


namespace AtividadeROLL
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRoll_Clicked(object sender, EventArgs e)
        {
            int selectedSide = Convert.ToInt32(Pic.SelectedItem);
            int random = new Random().Next(0, selectedSide+1);
            Result.Text = random.ToString();
    }
    }

}
