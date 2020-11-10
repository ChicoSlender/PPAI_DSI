using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Seccion
    {
        int coordenadaX;
        int coordenadaY;
        int[] dimension = new int[2];
        string nombre;
        Mesa mesa;

        static List<Seccion> instancias = new List<Seccion>();
        public Seccion(int coordenadaX, int coordenadaY, int[] dimension, string nombre)
        {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
            this.dimension = dimension;
            this.nombre = nombre;

            Seccion.instancias.Add(this);
        }

        public static List<Seccion> obtenerTodasLasInstancias()
        {
            return Seccion.instancias;
        }

        public List<String> mostrarDatos()
        {
            List<String> datosSeccion = new List<string>();
            datosSeccion.Add(this.nombre);
            Sector sectorDeSeccion = Sector.obtenerTodasLasInstancias().Find(sector => sector.esTuSeccion(this));
            List<String> datosSector = sectorDeSeccion.mostrarDatos();
            return datosSeccion.Concat(datosSector).ToList();
        }

        public bool esTuMesa(Mesa buscada) {
            return this.mesa == buscada;
        }

        internal Mesa Mesa { get => mesa; set => mesa = value; }
    }
}
