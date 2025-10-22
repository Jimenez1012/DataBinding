using DataBinding.DataObject.Models;
using System.ComponentModel;

namespace DataBinding.DataObject
{
    public partial class MainPage : ContentPage
    {
        private Contador contador;


        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            this.BindingContext = contador;
        }
        private void OnContarButton_Clicked(object sender, EventArgs e)
        {
            contador._Contar();            
        }

        private void OnReiniciarButton_Clicked(object sender, EventArgs e)
        {
            contador.Reiniciar();            
        }              
    }
}
