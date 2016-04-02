using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EC
    {
        int _idEC, _nro;
        List<Facturas> facturas;
        string _nombreExportador;
        
        public int IdEC
        {
            get
            {
                return _idEC;
            }

            set
            {
                _idEC = value;
            }
        }

        public List<Facturas> Facturas
        {
            get
            {
                return facturas;
            }

            set
            {
                facturas = value;
            }
        }

        public int Nro
        {
            get
            {
                return _nro;
            }

            set
            {
                _nro = value;
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
