


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
           double randomNumber = Convert.ToDouble(RandomNumber.Text);
            double random = new Random().Next(0, 100);
            RandomNumber.Text = randomNumber.ToString();
    }
    }

}
