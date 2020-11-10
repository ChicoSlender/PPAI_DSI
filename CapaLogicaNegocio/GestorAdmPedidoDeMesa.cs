using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class GestorAdmPedidoDeMesa
    {
        ICompuestoCarta cartaVigente;
        List<ICompuestoCarta> categoriasCarta;
        List<ICompuestoCarta> subcategoriasCarta;
        List<ICompuestoCarta> productosCarta;
        List<ICompuestoCarta> productosFavCarta;
        List<string> nomCategoriasCarta;
        List<string> nomSubcategoriasCarta;
        List<string> nomProductosCarta;
        ICompuestoCarta categoriaSelec;
        ICompuestoCarta subcategSelec;
        List<object[]> productosSelec = new List<object[]>();
        Empleado empleadoLogueado;
        List<List<String>> mesasAsigAbiertas;
        int mesaSelec;
        int cantComensales;
        DateTime fechaHoraActual;
        int nroPedido;
        Estado estAbierto;
        Estado estPendPrep;
        Estado estConPedGenerado;
        DSI_PPAI_Implementacion_CU_1.CapaPresentacion.PantAdmPedidoMesa pantalla;

        public GestorAdmPedidoDeMesa(DSI_PPAI_Implementacion_CU_1.CapaPresentacion.PantAdmPedidoMesa pantalla)
        {
            this.pantalla = pantalla;
        }

        public void nuevoPedido() {
            this.obtenerUsuarioLogueado();
            this.buscarMesasAsigAbiertas();
        }

        public void obtenerUsuarioLogueado() {
            this.empleadoLogueado = Sesion.obtenerSesionActual().obtenerUsuarioLog();
        }

        public void buscarMesasAsigAbiertas() {
            this.tomarFechaHoraActual();
            this.mesasAsigAbiertas = this.empleadoLogueado.mostMesasAsigAbiertas(this.fechaHoraActual);
            pantalla.mostrarMesasParaSeleccion(this.mesasAsigAbiertas);
        }

        public void tomarFechaHoraActual() {
            this.fechaHoraActual = DateTime.Now;
        }

        public void tomarSeleccionMesa(int indMesa)
        {
            this.mesaSelec = indMesa;
            pantalla.solicitarIngCantComens();
        }
    
        public void tomarCantComens(int cant)
        {
            this.cantComensales = cant;
            pantalla.mostrarOpcParaItems();
        }

        public void tomarOpcionParaItems(string opcion)
        {
            switch (opcion)
            {
                case "ProductoIndiv":
                    pantalla.mostrarOpcBusqueda();
                    break;
                case "MenuSugerido":
                    //Opcion para buscar por menu sugerido
                    break;
            }
        }

        public void tomarOpcBusq(string opcion)
        {
            switch(opcion)
            {
                case "CategSubcateg":
                    this.buscarCategCartaVig();
                    break;
                case "Favoritos":
                    this.buscarProductosFavCartaVig();
                    break;
                case "Nombre":
                    this.buscarProductosCartaVig();
                    break;
            }
        }

        public void buscarProductosFavCartaVig() {
            List<CompuestoCarta> instanciasCompCarta = CompuestoCarta.obtenerTodasLasInstancias();
            this.cartaVigente = instanciasCompCarta.Find(compuesto => compuesto.esVigente());
            if (this.cartaVigente != null)
            {
                this.productosCarta = cartaVigente.obtenerHijos(3).FindAll(hijo => hijo.esFav());
                this.nomProductosCarta = new List<string>();
                this.productosCarta.ForEach(producto => this.nomProductosCarta.Add(producto.mostrarNombre()));
                pantalla.mostrarProductosFavPSeleccion(this.nomProductosCarta);
            }
        }

        public void buscarProductosCartaVig()
        {
            List<CompuestoCarta> instanciasCompCarta = CompuestoCarta.obtenerTodasLasInstancias();
            this.cartaVigente = instanciasCompCarta.Find(compuesto => compuesto.esVigente());
            if (this.cartaVigente != null)
            {
                this.productosCarta = cartaVigente.obtenerHijos(3);
                this.nomProductosCarta = new List<string>();
                this.productosCarta.ForEach(producto => this.nomProductosCarta.Add(producto.mostrarNombre()));
                pantalla.mostrarTodosProductosPSeleccion(this.nomProductosCarta);
            }
        }

        public void tomarSeleccionSubcateg(string subcategSeleccionada)
        {
            this.subcategSelec = this.subcategoriasCarta[nomSubcategoriasCarta.IndexOf(subcategSeleccionada)];
            this.productosCarta = this.subcategSelec.obtenerHijos(1);
            this.nomProductosCarta = this.subcategSelec.mostrarHijos();
            pantalla.mostrarProdPSeleccion(this.nomProductosCarta);
        }

        public void tomarSeleccProd(string prodSeleccionado)
        {
            ICompuestoCarta productoSelec = this.productosCarta[this.nomProductosCarta.IndexOf(prodSeleccionado)];
            if (this.productosSelec.Count == 0 || this.productosSelec[this.productosSelec.Count - 1][1] != null)
            {
                this.productosSelec.Add(new object[3]);
            }
            this.productosSelec[this.productosSelec.Count - 1][0] = productoSelec;
            pantalla.solicitarIngCantProd();
        }

        public void tomarCantidadProd(int cant)
        {
            this.productosSelec[this.productosSelec.Count - 1][1] = cant;
            this.buscarDatosProdSelec();
        }

        private void buscarDatosProdSelec()
        {
            ProductoCarta prodSelec = (ProductoCarta)this.productosSelec[this.productosSelec.Count - 1][0];
            this.productosSelec[this.productosSelec.Count - 1][2] = prodSelec.Precio;
            pantalla.mostrarDatosProdSelecc(this.productosSelec[this.productosSelec.Count - 1]);
            pantalla.mostrarOpcParaModific();
            pantalla.solicitarConfirmacionPRegPed();
        }

        public void tomarCategoriaCarta(string categoriaSeleccionada)
        {
            this.categoriaSelec = this.categoriasCarta[nomCategoriasCarta.IndexOf(categoriaSeleccionada)];
            this.subcategoriasCarta = this.categoriaSelec.obtenerHijos(1);
            this.nomSubcategoriasCarta = this.categoriaSelec.mostrarHijos();
            pantalla.mostrarSubcategoriasPSeleccion(this.nomSubcategoriasCarta);
        }
        public void buscarCategCartaVig()
        {
            List<CompuestoCarta> instanciasCompCarta = CompuestoCarta.obtenerTodasLasInstancias();
            this.cartaVigente = instanciasCompCarta.Find(compuesto=> compuesto.esVigente());
            if(cartaVigente != null) {
                this.categoriasCarta = cartaVigente.obtenerHijos(1);
                this.nomCategoriasCarta = cartaVigente.mostrarHijos();
                pantalla.mostrarCategoriasDeCartaPSeleccion(this.nomCategoriasCarta);
            }
        }

        public void confirmarPedido()
        {
            this.tomarFechaHoraActual();
            this.calcularNumeroPed();
            this.buscarEstadoAbierto();
            this.buscarEstadoPendPrep();
            this.buscarEstadoConPedGenerado();
            this.crearPedido();
        }

        public void calcularNumeroPed()
        {
            List<Pedido> pedidos = Pedido.obtenerTodasLasInstancias();
            int nroMax = 0;
            pedidos.ForEach(pedido =>
            {
                if (pedido.NroPedido > nroMax)
                    nroMax = pedido.NroPedido;
            });
            this.nroPedido = nroMax + 1;
        }

        public void buscarEstadoAbierto()
        {
            this.estAbierto = Estado.obtenerTodasLasInstancias().Find(estado => estado.esAmbitoPedido() && estado.esAbierto());
        }

        public void buscarEstadoPendPrep()
        {
            this.estPendPrep = Estado.obtenerTodasLasInstancias().Find(estado=> estado.esAmbitoDetallePedido() && estado.esPendPrep());
        }

        public void buscarEstadoConPedGenerado()
        {
            this.estConPedGenerado = Estado.obtenerTodasLasInstancias().Find(estado=> estado.esAmbitoMesa() && estado.esConPedGenerado());
        }

        public void crearPedido()
        {
            this.empleadoLogueado.crearPedido(this.mesaSelec, this.fechaHoraActual, this.nroPedido, this.cantComensales, this.productosSelec, this.estAbierto, this.estConPedGenerado, this.estPendPrep);
            this.finDeCU();
        }

        public void finDeCU()
        {
            //Grabar cambios
            pantalla.Close();
        }
    }
}
