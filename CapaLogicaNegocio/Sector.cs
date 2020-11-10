using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Sector
    {
        int ancho;
        int largo;
        string nombre;
        string ubicacionPuerta;
        string ubicacionVentana;
        List<Seccion> seccion;

        static List<Sector> instancias = new List<Sector>();

        public Sector(int ancho, int largo, string nombre, string ubicacionPuerta, string ubicacionVentana)
        {
            this.ancho = ancho;
            this.largo = largo;
            this.nombre = nombre;
            this.ubicacionPuerta = ubicacionPuerta;
            this.ubicacionVentana = ubicacionVentana;
            this.seccion = new List<Seccion>();

            Sector.instancias.Add(this);
        }

        public static List<Sector> obtenerTodasLasInstancias() {
            return Sector.instancias;
        }

        public bool esTuSeccion(Seccion buscada) {
            return this.seccion.Find(seccion => seccion==buscada) != null;
        }

        public void agregarSeccion(Seccion seccion)
        {
            this.seccion.Add(seccion);
        }

        public List<String> mostrarDatos()
        {
            List<String> datosSector = new List<string>();
            datosSector.Add(this.nombre);
            Piso pisoDeSector = Piso.obtenerTodasLasInstancias().Find(piso => piso.esTuSector(this));
            String datosPiso = pisoDeSector.Numero.ToString();
            datosSector.Add(datosPiso);
            return datosSector;
        }
    }
}
