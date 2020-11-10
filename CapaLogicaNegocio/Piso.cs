using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Piso
    {
        int numero;
        List<Sector> sector;

        static List<Piso> instancias = new List<Piso>();

        public int Numero { get => numero; set => numero = value; }

        public Piso(int numero)
        {
            this.numero = numero;
            this.sector = new List<Sector>();

            Piso.instancias.Add(this);
        }

        public static List<Piso> obtenerTodasLasInstancias() {
            return Piso.instancias;
        }

        public bool esTuSector(Sector buscado) {
            return this.sector.Find(sector=> sector==buscado) != null;
        }

        public void agregarSector(Sector sector)
        {
            this.sector.Add(sector);
        }
    }
}
