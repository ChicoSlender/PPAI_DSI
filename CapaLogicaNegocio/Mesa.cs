using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Mesa
    {
        int capacidadComensales;
        int[] espacioQueOcupa = new int[2];
        int filaEnPlano;
        int ordenEnPlano;
        int numero;
        Estado estado;
        List<Pedido> pedidos;

        public Mesa(int capacidadComensales, int[] espacioQueOcupa, int filaEnPlano, int ordenEnPlano, int numero)
        {
            this.capacidadComensales = capacidadComensales;
            this.espacioQueOcupa = espacioQueOcupa;
            this.filaEnPlano = filaEnPlano;
            this.ordenEnPlano = ordenEnPlano;
            this.numero = numero;
            this.pedidos = new List<Pedido>();
        }

        public bool esAbierta() {
            return this.estado.esAbierta();
        }

        public List<String> mostrarDatos() {
            List<String> datosMesa = new List<string>();
            datosMesa.Add(this.numero.ToString());
            Seccion seccionDeMesa = Seccion.obtenerTodasLasInstancias().Find(seccion => seccion.esTuMesa(this));
            List<String> datosSeccion = seccionDeMesa.mostrarDatos();
            return datosMesa.Concat(datosSeccion).ToList();
        }

        public List<Mesa> estaEnUnionVigente(DateTime fechaHora)
        {
            List<Mesa> mesasUnidas = new List<Mesa>();
            UnionDeMesas unionVigente = UnionDeMesas.obtenerTodasLasInstancias().Find(union => union.esVigente(fechaHora) && union.esTuMesa(this));
            if (unionVigente != null)
            {
                mesasUnidas = unionVigente.Mesa.FindAll(mesa => mesa != this);
            }
            return mesasUnidas;
        }

        internal Estado Estado { get => estado; set => estado = value; }
        public int Numero { get => numero; set => numero = value; }

        public void crearPedido(DateTime fechaHoraActual, int nroPedido, int cantComensales, List<object[]> productosSelec, Estado estAbierto, Estado estConPedGenerado, Estado estPendPrep)
        {
            Pedido nuevoPedido = new Pedido(nroPedido, fechaHoraActual, cantComensales, estAbierto, productosSelec, estPendPrep);
            UnionDeMesas unionVigente = UnionDeMesas.obtenerTodasLasInstancias().Find(union => union.esVigente(fechaHoraActual) && union.esTuMesa(this));
            if (unionVigente == null)
            {
                this.pedidos.Add(nuevoPedido);
                this.Estado = estConPedGenerado;
                //<debug>
                Console.WriteLine("Mesa nro " + this.Numero + ", estado: " + this.Estado.Nombre);
                //</debug>
            }
            else
            {
                unionVigente.Pedido = nuevoPedido;
                unionVigente.Mesa.ForEach(mesa => mesa.Estado = estConPedGenerado);
                //<debug>
                string nroMesas = "";
                unionVigente.Mesa.ForEach(mesa => nroMesas = nroMesas + " " + mesa.numero);
                Console.WriteLine("Union de mesas" + nroMesas + ", estado: " + unionVigente.Mesa[0].Estado.Nombre);
                //</debug>
            }
            //<debug>
            Console.WriteLine("Pedido nro " + nuevoPedido.NroPedido);
            Console.WriteLine("\tComensales: " + nuevoPedido.CantComensales);
            Console.WriteLine("\tFecha y hora: " + nuevoPedido.FechaHoraPed.ToString());

            Console.WriteLine("\tHistorial de estado:");
            nuevoPedido.HistorialEstado.ForEach(hist => Console.WriteLine("\t\t-Estado: " + hist.Estado.Nombre + ", inicio: " + hist.FechaHoraInicio.ToString()));

            Console.WriteLine("\tDetalle de pedido:");
            nuevoPedido.DetalleDePedido.ForEach(det => Console.WriteLine("\t\t-Producto: " + det.ProductoCarta.mostrarNombre() + ", cantidad: " + det.Cantidad + ", precio: $" + det.Precio + ", hora: " + det.Hora.ToShortTimeString()));
            //</debug>
        }

    }

    class UnionDeMesas {
        DateTime fechaHoraUnion;
        DateTime fechaHoraSeparac;
        List<Mesa> mesa;
        Pedido pedido;

        static List<UnionDeMesas> instancias = new List<UnionDeMesas>();

        internal List<Mesa> Mesa { get => mesa; set => mesa = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }

        public UnionDeMesas(DateTime fechaHoraUnion, DateTime fechaHoraSeparac)
        {
            this.fechaHoraUnion = fechaHoraUnion;
            this.fechaHoraSeparac = fechaHoraSeparac;
            this.mesa = new List<Mesa>();
            UnionDeMesas.instancias.Add(this);
        }

        public void agregarMesa(Mesa mesa) {
            this.mesa.Add(mesa);
        }

        public bool esVigente(DateTime fechaHora)
        {
            return this.fechaHoraUnion <= fechaHora && fechaHora <= this.fechaHoraSeparac;
        }

        public bool esTuMesa(Mesa mesa)
        {
            return this.mesa.Contains(mesa);
        }

        public static List<UnionDeMesas> obtenerTodasLasInstancias()
        {
            return UnionDeMesas.instancias;
        }
    }
}
