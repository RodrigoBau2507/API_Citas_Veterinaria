using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2._0
{
    internal class DatCitas
    {
        private int idCitas;
        private DateTime Hora;
        private DateTime Fecha;
        private string Decripcion;
        private int Mascota_idMascota;
        private int Servicio_idServicio;


        public int IdCitas { get => idCitas; set => idCitas = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Decripcion1 { get => Decripcion; set => Decripcion = value; }
        public int Mascota_idMascota1 { get => Mascota_idMascota; set => Mascota_idMascota = value; }
        public int Servicio_idServicio1 { get => Servicio_idServicio; set => Servicio_idServicio = value; }
    }
}
