using DataBinding.Coleccion.Models;
using System.Collections.ObjectModel;

namespace DataBinding.Coleccion
{
    public partial class MainPage : ContentPage
    {
        private string _nombre = string.Empty;
        private ObservableCollection<Usuario> _users;


        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            _users = new ObservableCollection<Usuario>();
            this.BindingContext = this;
            this.UsuariosCollectionView.BindingContext = _users;
        }

        private void AgregarButtonClicked(object sender, EventArgs e)
        {
            AgregarUsuario(Nombre);

        }

        private void AgregarUsuario(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                _users.Add(new Usuario(nombre));
            }
        }
    }
}
