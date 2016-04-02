using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesFactura
    {
        int _idDetalle, _cantidad;
        Facturas fact;
        float _subtotal;
        ES _es;

        public int IdDetalle
        {
            get
            {
                return _idDetalle;
            }

            set
            {
                _idDetalle = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public Facturas Fact
        {
            get
            {
                return fact;
            }

            set
            {
                fact = value;
            }
        }

        public float Subtotal
        {
            get
            {
                return _subtotal;
            }

            set
            {
                _subtotal = value;
            }
        }
        
        public ES Es
        {
            get
            {
                return _es;
            }

            set
            {
                _es = value;
            }
        }
    }
}
