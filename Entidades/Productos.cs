using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        int _idProducto;
        string nombre;
        float peso;
        List<DetallesES> detalles;

        public int IdProducto
        {
            get
            {
                return _idProducto;
            }

            set
            {
                _idProducto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public List<DetallesES> Detalles
        {
            get
            {
                return detalles;
            }

            set
            {
                detalles = value;
            }
        }
    }
}
