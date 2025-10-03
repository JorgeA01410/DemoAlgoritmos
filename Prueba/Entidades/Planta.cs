using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class Planta
    {
        
        public string IdPlanta { get; set; }
        public string IdSolucion { get; set; }
        public int IdLote { get; set; }

        public Planta(Planta planta)
        {
            IdPlanta = planta.IdPlanta;
            IdSolucion = planta.IdSolucion;
            IdLote = planta.IdLote;
        }

    }
}
