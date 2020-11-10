using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI_Implementacion_CU_1.CapaPresentacion;
using DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio;

namespace DSI_PPAI_Implementacion_CU_1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Preseteo:
            //Carta no vigente
            new CompuestoCarta("Carta verano", new DateTime(2019, 8, 10), new DateTime(2020, 1, 1), new DateTime(2020, 3, 12));
            //Carta vigente
            CompuestoCarta cartaVigente = new CompuestoCarta("Carta primavera", new DateTime(2020, 6, 8), new DateTime(2020, 9, 21), new DateTime(2020, 12, 31));

            //Añadir categorias a la carta
            cartaVigente.agregarHijo(new CompuestoCarta(new Categoria("Platos Principales")));
            cartaVigente.agregarHijo(new CompuestoCarta(new Categoria("Entradas")));
            cartaVigente.agregarHijo(new CompuestoCarta(new Categoria("Guarniciones")));
            cartaVigente.agregarHijo(new CompuestoCarta(new Categoria("Postres")));
            cartaVigente.agregarHijo(new CompuestoCarta(new Categoria("Bebidas")));

            //Añadir subcategorias
            cartaVigente.obtenerHijos(1)[0].agregarHijo(new CompuestoCarta(new Subcategoria("Carnes")));
            cartaVigente.obtenerHijos(1)[0].agregarHijo(new CompuestoCarta(new Subcategoria("Sandwiches")));
            cartaVigente.obtenerHijos(1)[0].agregarHijo(new CompuestoCarta(new Subcategoria("Pizzas")));
            cartaVigente.obtenerHijos(1)[0].agregarHijo(new CompuestoCarta(new Subcategoria("Pastas")));
            cartaVigente.obtenerHijos(1)[0].agregarHijo(new CompuestoCarta(new Subcategoria("Platos vegetarianos")));

            cartaVigente.obtenerHijos(1)[1].agregarHijo(new CompuestoCarta(new Subcategoria("Empanadas")));
            cartaVigente.obtenerHijos(1)[1].agregarHijo(new CompuestoCarta(new Subcategoria("Picadas")));
            cartaVigente.obtenerHijos(1)[1].agregarHijo(new CompuestoCarta(new Subcategoria("Ensaladas")));

            cartaVigente.obtenerHijos(1)[2].agregarHijo(new CompuestoCarta(new Subcategoria("Rebozados")));
            cartaVigente.obtenerHijos(1)[2].agregarHijo(new CompuestoCarta(new Subcategoria("Ensaladas")));

            cartaVigente.obtenerHijos(1)[3].agregarHijo(new CompuestoCarta(new Subcategoria("Helados")));
            cartaVigente.obtenerHijos(1)[3].agregarHijo(new CompuestoCarta(new Subcategoria("Reposteria")));
            cartaVigente.obtenerHijos(1)[3].agregarHijo(new CompuestoCarta(new Subcategoria("Otros postres")));

            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Gaseosas")));
            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Aguas saborizadas")));
            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Jugos")));
            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Cervezas")));
            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Tragos")));
            cartaVigente.obtenerHijos(1)[4].agregarHijo(new CompuestoCarta(new Subcategoria("Vinos")));

            //Añadir productos
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Hamburguesa completa", 340), true));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Lomo pollo", 270), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Lomo ternera", 280), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Lomo completo", 300), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Tostado jamon y queso", 220), false));
            
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Muzzarella", 200), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Napolitana", 220), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Especial con huevo", 280), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Rúcula y jamon crudo", 340), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Especial con ananá", 310), true));

            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Ñoquis", 320), true));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Ravioles 4 quesos", 350), false));
            cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Sorrentinos caprese", 360), false));

            cartaVigente.obtenerHijos(1)[1].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Arabe", 20), false));
            cartaVigente.obtenerHijos(1)[1].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Jamon y queso", 20), false));
            cartaVigente.obtenerHijos(1)[1].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Criolla", 20), false));
            cartaVigente.obtenerHijos(1)[1].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Salteña frita", 20), false));

            cartaVigente.obtenerHijos(1)[2].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Piezas de pollo frito", 220), true));
            cartaVigente.obtenerHijos(1)[2].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Bastones de muzzarella", 240), false));
            cartaVigente.obtenerHijos(1)[2].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Aros de cebolla", 200), false));

            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Chocolate", 200), false));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Vainilla", 200), false));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Frutilla", 200), false));

            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Flan", 240), true));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Gelatina", 200), false));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Tiramisú", 300), true));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Pannacota", 280), false));
            cartaVigente.obtenerHijos(1)[3].obtenerHijos(1)[2].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Crema oreo", 270), false));

            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Pepsi 750cc", 270), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Mirinda 750cc", 270), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "7up 750cc", 270), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[0].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Guaraná antartica 750cc", 270), false));

            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Mojito", 300), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Daikiri frutilla", 300), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "White russian", 320), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Fernet con coca", 300), true));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Cuba libre", 300), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Margarita", 320), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[4].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Caipiriña", 280), false));

            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Brahma 1L", 150), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Quilmes 1L", 150), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Quilmes negra 1L", 150), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Imperial IPA 1L", 150), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Corona 750cc", 150), false));
            cartaVigente.obtenerHijos(1)[4].obtenerHijos(1)[3].agregarHijo(new ProductoCarta(new Producto(DateTime.Now, "", "Heineken 500cc", 150), false));

            //Crear estados necesarios
            Estado estAbierta = new Estado("mesa", "abierta");
            Estado estConPedGenerado = new Estado("mesa", "con pedido generado");
            Estado estAbierto = new Estado("pedido", "abierto");
            Estado estPendPrep = new Estado("detalle pedido", "pendiente de preparacion");

            //Crear piso 0
            Piso plantaBaja = new Piso(0);

            //Crear sectores de la planta baja
            Sector sectVereda = new Sector(10, 20, "Vereda", "Izquierda, abajo", "");
            plantaBaja.agregarSector(sectVereda);
            Sector sectComedor = new Sector(20, 20, "Comedor", "Derecha, abajo", "A ambos lados");
            plantaBaja.agregarSector(sectComedor);
            
            //Crear secciones
            int[] dimPuertaVer = { 10, 10 };
            Seccion seccPuertaVer = new Seccion(0, 10, dimPuertaVer, "Puerta");
            sectVereda.agregarSeccion(seccPuertaVer);
            int[] dimEsquinaVer = { 10, 10 };
            Seccion seccEsquinaVer = new Seccion(0, 0, dimEsquinaVer, "Esquina");
            sectVereda.agregarSeccion(seccEsquinaVer);

            int[] dimPuertaCom = { 10, 10 };
            Seccion seccPuertaCom = new Seccion(10, 10, dimPuertaCom, "Puerta");
            sectComedor.agregarSeccion(seccPuertaCom);

            //Crear mesas
            int[] espacio1 = { 3, 2 };
            seccPuertaVer.Mesa = new Mesa(4, espacio1, 1, 1, 1);
            seccPuertaVer.Mesa.Estado = estAbierta;
            int[] espacio2 = {3,3};
            seccEsquinaVer.Mesa = new Mesa(6, espacio2, 2, 1, 2);
            seccEsquinaVer.Mesa.Estado = estAbierta;

            int[] espacio3 = { 5, 5 };
            seccPuertaCom.Mesa = new Mesa(5, espacio3, 2, 2, 3);
            seccPuertaCom.Mesa.Estado = estAbierta;

            //Crear union de mesas
            UnionDeMesas unionMesas = new UnionDeMesas(DateTime.Now, DateTime.Now.AddHours(2));
            unionMesas.agregarMesa(seccEsquinaVer.Mesa);
            unionMesas.agregarMesa(seccPuertaVer.Mesa);

            //Crear empleado
            Usuario usuario = new Usuario("Josesito23", "Mozo", "contraseña", new DateTime(2020, 10, 1));
            Empleado empleadoLogueado = new Empleado("Jose", "Antonio", "Cafayate 123", 3510000, new DateTime(2020, 10, 1), usuario);

            //Asignar mesas a empleado
            AsignacionMesa asignacion = new AsignacionMesa(DateTime.Now, DateTime.Now.AddHours(1));
            asignacion.agregarMesa(seccEsquinaVer.Mesa);
            asignacion.agregarMesa(seccPuertaVer.Mesa);
            asignacion.agregarMesa(seccPuertaCom.Mesa);
            empleadoLogueado.agregarAsignacionMesa(asignacion);

            //Crear pedido previo existente
            List<object[]> detPedAnt = new List<object[]>();
            object[] det1 = new object[3];
            det1[0] = cartaVigente.obtenerHijos(1)[0].obtenerHijos(1)[1].obtenerHijos(1)[3];
            det1[1] = 2;
            det1[2] = (float)250;
            detPedAnt.Add(det1);
            Pedido pedidoAnt = new Pedido(1, DateTime.Now.AddHours(-1), 2, estAbierto, detPedAnt, estPendPrep);

            //Crear sesion
            Sesion sesionActual = new Sesion(DateTime.Now.Date, DateTime.Now.ToLocalTime(), usuario);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantMenuPrincipal());
        }
    }
}
