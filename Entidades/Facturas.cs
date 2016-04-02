using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        int _idFactura;
        float _total;
        DateTime _fecha;
        EC _ec;
        List<DetallesFactura> detalles;
        string _nombreComprador, _nombreExportador;

        public int IdFactura
        {
            get
            {
                return _idFactura;
            }

            set
            {
                _idFactura = value;
            }
        }
        

        public float Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public EC Ec
        {
            get
            {
                return _ec;
            }

            set
            {
                _ec = value;
            }
        }

        public List<DetallesFactura> Detalles
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

        public string NombreComprador
        {
            get
            {
                return _nombreComprador;
            }

            set
            {
                _nombreComprador = value;
            }
        }

        public string NombreExportador
        {
            get
            {
                return _nombreExportador;
            }

            set
            {
                _nombreExportador = value;
            }
        }
    }
}
