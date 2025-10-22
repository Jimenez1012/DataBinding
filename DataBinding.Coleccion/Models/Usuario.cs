using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Coleccion.Models
{
    public class Usuario
    {
        private string _nombre;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                }                                    
            }       
        }

        public Usuario(string nombre) 
        { 
            Nombre = nombre;
        }
    }
}
