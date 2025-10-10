namespace DataBinding.XamlElement
{
    public partial class MainPage : ContentPage
    {     

        public MainPage()
        {
            InitializeComponent();
        }

        private void UserInputEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserInputLabel.Text = UserInputEntry.Text;
        }
    }
}
