using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Pedido
    {
        int nroPedido;
        DateTime fechaHoraPed;
        int cantComensales;
        List<DetalleDePedido> detalleDePedido;
        List<HistorialEstado> historialEstado;

        static List<Pedido> instancias = new List<Pedido>();

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        internal List<DetalleDePedido> DetalleDePedido { get => detalleDePedido; set => detalleDePedido = value; }
        internal List<HistorialEstado> HistorialEstado { get => historialEstado; set => historialEstado = value; }
        public DateTime FechaHoraPed { get => fechaHoraPed; set => fechaHoraPed = value; }
        public int CantComensales { get => cantComensales; set => cantComensales = value; }

        public Pedido(int nroPedido, DateTime fechaHoraPed, int cantComensales, Estado estadoAbierto, List<object[]> itemsDet, Estado estadoPendPrep)
        {
            this.nroPedido = nroPedido;
            this.fechaHoraPed = fechaHoraPed;
            this.cantComensales = cantComensales;
            this.detalleDePedido = new List<DetalleDePedido>();
            this.historialEstado = new List<HistorialEstado>();
            this.crearHistEstado(estadoAbierto, fechaHoraPed);
            itemsDet.ForEach(item => {
                this.crearDetallePedido((ProductoCarta)item[0], (int)item[1], (float)item[2], fechaHoraPed, estadoPendPrep);
            });
            Pedido.instancias.Add(this);
        }

        public void crearHistEstado(Estado estado, DateTime fechaHoraInicio)
        {
            this.historialEstado.Add(new HistorialEstado(fechaHoraInicio, estado));
        }

        public void crearDetallePedido(ProductoCarta producto, int cantidad, float precio, DateTime hora, Estado estadoPendPrep)
        {
            this.detalleDePedido.Add(new DetalleDePedido(producto, cantidad, precio, hora, estadoPendPrep));
        }

        public static List<Pedido> obtenerTodasLasInstancias()
        {
            return Pedido.instancias;
        }
    }

    class DetalleDePedido
    {
        ProductoCarta productoCarta;
        int cantidad;
        DateTime hora;
        float precio;
        List<HistorialEstado> historialEstado;

        public DetalleDePedido(ProductoCarta productoCarta, int cantidad, float precio, DateTime hora, Estado estadoPendPrep)
        {
            this.productoCarta = productoCarta;
            this.cantidad = cantidad;
            this.precio = precio;
            this.hora = hora;
            this.historialEstado = new List<HistorialEstado>();
            this.crearHistorial(estadoPendPrep, hora);
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public float Precio { get => precio; set => precio = value; }
        internal ProductoCarta ProductoCarta { get => productoCarta; set => productoCarta = value; }
        internal List<HistorialEstado> HistorialEstado { get => historialEstado; set => historialEstado = value; }

        public void crearHistorial(Estado estado, DateTime fechaHoraInicio) {
            this.historialEstado.Add(new HistorialEstado(fechaHoraInicio, estado));
        }
    }
}
