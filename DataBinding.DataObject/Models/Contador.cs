using System.ComponentModel;

namespace DataBinding.DataObject.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int conteo;  

        public event PropertyChangedEventHandler PropertyChanged;
        public int _Conteo
        {
            get => conteo;
            set
            {
                if (conteo != value)
                {
                    conteo = value;
                    OnPropertyChanged(nameof(_Conteo));
                }
            }
        }
        public Contador()
        {
            _Conteo = 0;
        }
        public void _Contar()
        {
            _Conteo++;
        }
        public void Reiniciar()
        {
            _Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName)

        //if (PropertyChanged != null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
