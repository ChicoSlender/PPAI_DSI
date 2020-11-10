using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Empleado
    {
        string nombre;
        string apellido;
        string domicilio;
        int telefono;
        DateTime fechaIng;
        Usuario usuario;
        List<AsignacionMesa> asignacionMesa;

        static List<Empleado> instancias = new List<Empleado>();

        internal List<AsignacionMesa> AsignacionMesa { get => asignacionMesa; set => asignacionMesa = value; }

        public Empleado(string nombre, string apellido, string domicilio, int telefono, DateTime fechaIng, Usuario usuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.fechaIng = fechaIng;
            this.usuario = usuario;
            this.asignacionMesa = new List<AsignacionMesa>();
            Empleado.instancias.Add(this);
        }

        public static List<Empleado> obtenerTodasLasInstancias() {
            return Empleado.instancias;
        }

        public bool esTuUsuario(Usuario usuario) {
            return this.usuario == usuario;
        }

        public List<List<String>> mostMesasAsigAbiertas(DateTime fechaHora) {
            AsignacionMesa asignacionVigente = this.asignacionMesa.Find(asignacion => asignacion.esVigente(fechaHora));
            return asignacionVigente.mostMesasAbiertas(fechaHora);
        }

        public void agregarAsignacionMesa(AsignacionMesa asignacion) {
            this.asignacionMesa.Add(asignacion);
        }

        public void crearPedido(int mesaSelec, DateTime fechaHoraActual, int nroPedido, int cantComensales, List<object[]> productosSelec, Estado estAbierto, Estado estConPedGenerado, Estado estPendPrep)
        {
            AsignacionMesa asignacionVigente = this.asignacionMesa.Find(asignacion => asignacion.esVigente(fechaHoraActual));
            asignacionVigente.crearPedido(mesaSelec, fechaHoraActual, nroPedido, cantComensales, productosSelec, estAbierto, estConPedGenerado, estPendPrep);
        }
    }

    class AsignacionMesa {
        DateTime fechaHoraDesde;
        DateTime fechaHoraHasta;
        List<Mesa> mesas;

        internal List<Mesa> Mesas { get => mesas; set => mesas = value; }

        public AsignacionMesa(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.mesas = new List<Mesa>();
        }

        public bool esVigente(DateTime fechaHora) {
            return this.fechaHoraDesde <= fechaHora && fechaHora <= this.fechaHoraHasta;
        }

        public List<List<String>> mostMesasAbiertas(DateTime fechaHora)
        {
            List<Mesa> mesasAbiertas = this.mesas.FindAll(mesa=> mesa.esAbierta());
            List<List<String>> datosMesasAbiertas = new List<List<string>>();
            mesasAbiertas.ForEach(mesa => {
                datosMesasAbiertas.Add(mesa.mostrarDatos());
                string mesasUnidas = "";
                mesa.estaEnUnionVigente(fechaHora).ForEach(mesaUnida => {
                    mesasUnidas = mesasUnidas + mesaUnida.Numero + ", ";
                });
                if (mesasUnidas != "") 
                    mesasUnidas = mesasUnidas.Substring(0, mesasUnidas.Length - 2);
                datosMesasAbiertas[datosMesasAbiertas.Count - 1].Add(mesasUnidas);
            });
            return datosMesasAbiertas;
        }

        public void agregarMesa(Mesa mesa) {
            this.mesas.Add(mesa);
        }

        public void crearPedido(int mesaSelec, DateTime fechaHoraActual, int nroPedido, int cantComensales, List<object[]> productosSelec, Estado estAbierto, Estado estConPedGenerado, Estado estPendPrep)
        {
            this.mesas[mesaSelec].crearPedido(fechaHoraActual, nroPedido, cantComensales, productosSelec, estAbierto, estConPedGenerado, estPendPrep);
        }
    }
}
