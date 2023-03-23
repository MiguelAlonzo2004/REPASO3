using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO3
{
    class Reporte
    {
        string nombre;
        string apellido;
        int nocasa;
        double cuota;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Nocasa { get => nocasa; set => nocasa = value; }
        public double Cuota { get => cuota; set => cuota = value; }
    }
}
