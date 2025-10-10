using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBinding.DataObject.Models
{
    public class Contador
    {
        private int conteo;
        public int _Conteo
        {
            get => conteo;
            set
            {
                if (conteo != value)
                {
                    conteo = value;
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

    }
}
