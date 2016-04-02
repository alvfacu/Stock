using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesES
    {
        int _idDetalle, _cantTotal, _stock;
        float _pesoTotal;
        Productos prod;
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

        public int CantTotal
        {
            get
            {
                return _cantTotal;
            }

            set
            {
                _cantTotal = value;
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }

            set
            {
                _stock = value;
            }
        }

        public float PesoTotal
        {
            get
            {
                return _pesoTotal;
            }

            set
            {
                _pesoTotal = value;
            }
        }

        public Productos Prod
        {
            get
            {
                return prod;
            }

            set
            {
                prod = value;
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

        public Productos Productos
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
