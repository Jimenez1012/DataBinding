using DataBinding.DataObject.Models;

namespace DataBinding.DataObject
{
    public partial class MainPage : ContentPage
    {
        private Contador contador;


        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            ConteoLabel.Text = contador._Conteo.ToString();
        }

        private void OnContarButton_Clicked(object sender, EventArgs e)
        {
            contador._Contar();
            ConteoLabel.Text = contador._Conteo.ToString();
        }

        private void OnReiniciarButton_Clicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
            ConteoLabel.Text = contador._Conteo.ToString();
        }
    }
}
