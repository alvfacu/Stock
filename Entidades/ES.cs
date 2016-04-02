using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ES
    {
        DateTime _fechaOficializacion, _fechaVencimiento;
        int _idES, _nro;
        List<DetallesES> detalles;
        string _nombreExportador;


        public DateTime FechaOficializacion
        {
            get
            {
                return _fechaOficializacion;
            }

            set
            {
                _fechaOficializacion = value;
            }
        }

        public int IdES
        {
            get
            {
                return _idES;
            }

            set
            {
                _idES = value;
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

        public DateTime FechaVencimiento
        {
            get
            {
                return _fechaVencimiento;
            }

            set
            {
                _fechaVencimiento = this.FechaOficializacion.AddDays(180);
            }
        }
    }
}
