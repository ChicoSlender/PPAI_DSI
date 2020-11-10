using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Estado
    {
        string ambito;
        string nombre;

        static List<Estado> instancias = new List<Estado>();

        public string Ambito { get => ambito; set => ambito = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Estado(string ambito, string nombre)
        {
            this.ambito = ambito;
            this.nombre = nombre;
            Estado.instancias.Add(this);
        }

        public bool esAbierta() {
            return nombre == "abierta";
        }

        public bool esAbierto()
        {
            return nombre == "abierto";
        }

        public bool esAmbitoPedido()
        {
            return ambito == "pedido";
        }

        public bool esAmbitoDetallePedido()
        {
            return ambito == "detalle pedido";
        }

        public bool esPendPrep()
        {
            return nombre == "pendiente de preparacion";
        }

        public bool esAmbitoMesa()
        {
            return ambito == "mesa";
        }

        public bool esConPedGenerado()
        {
            return nombre == "con pedido generado";
        }

        public static List<Estado> obtenerTodasLasInstancias()
        {
            return Estado.instancias;
        }
    }

    class HistorialEstado
    {
        DateTime fechaHoraInicio;
        Estado estado;
        DateTime fechaHoraFin;

        public HistorialEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        internal Estado Estado { get => estado; set => estado = value; }
    }
}
