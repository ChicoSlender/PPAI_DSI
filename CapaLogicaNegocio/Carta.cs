using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    interface ICompuestoCarta {
        void agregarHijo(ICompuestoCarta hijo);
        void quitarHijo(ICompuestoCarta hijo);
        List<ICompuestoCarta> obtenerHijos(int nivel);
        List<string> mostrarHijos();
        string mostrarNombre();
        bool esVigente();
        bool esFav();
    }

    class CompuestoCarta: ICompuestoCarta
    {
        List<ICompuestoCarta> hijos;
        Categoria categoria;
        Subcategoria subcategoria;
        string nombre;
        string comentario;
        DateTime fechaCreacion;
        DateTime fechaInicioVigencia;
        DateTime fechaFinVigencia;

        static List<CompuestoCarta> instancias = new List<CompuestoCarta>();

        //Constructor carta
        public CompuestoCarta(string nombre, DateTime fechaCreacion, DateTime fechaInicioVigencia, DateTime fechaFinVigencia)
        {
            this.hijos = new List<ICompuestoCarta>();
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
            this.fechaInicioVigencia = fechaInicioVigencia;
            this.fechaFinVigencia = fechaFinVigencia;

           CompuestoCarta.instancias.Add(this);
        }
        //Constructor Categoria
        public CompuestoCarta(Categoria categoria, string comentario="")
        {
            this.hijos = new List<ICompuestoCarta>();
            this.categoria = categoria;
            this.comentario = comentario;
        }
        //Constructor Subcategoria
        public CompuestoCarta(Subcategoria subcategoria, string comentario = "")
        {
            this.hijos = new List<ICompuestoCarta>();
            this.subcategoria = subcategoria;
            this.comentario = comentario;
        }

        public static List<CompuestoCarta> obtenerTodasLasInstancias()
        {
            return instancias;
        }

        public void agregarHijo(ICompuestoCarta hijo)
        {
            hijos.Add(hijo);
        }

        public bool esVigente()
        {
            if (nombre != "")
                return fechaFinVigencia >= DateTime.Today;
            else
                return false;
        }

        public List<string> mostrarHijos()
        {
            List<string> nombres = new List<string>();
            this.obtenerHijos(1).ForEach(hijo => nombres.Add(hijo.mostrarNombre()));
            return nombres;
        }

        public string mostrarNombre()
        {
            if (nombre != null)
                return nombre;
            else if (categoria != null)
                return categoria.Nombre;
            else if (subcategoria != null)
                return subcategoria.Nombre;
            else
                return "";
        }

        public List<ICompuestoCarta> obtenerHijos(int nivel)
        {
            if (nivel == 1)
                return this.hijos;
            else
            {
                List<ICompuestoCarta> hijosNNivel = new List<ICompuestoCarta>();
                this.hijos.ForEach(hijo => hijosNNivel = hijosNNivel.Concat(hijo.obtenerHijos(nivel - 1)).ToList());
                return hijosNNivel;
            }
        }

        public void quitarHijo(ICompuestoCarta hijo)
        {
            hijos.Remove(hijo);
        }

        public bool esFav()
        {
            return false;
        }
    }

    class ProductoCarta : ICompuestoCarta
    {
        Producto producto;
        float precio;
        bool esFavorito;

        public ProductoCarta(Producto producto, bool esFavorito)
        {
            this.producto = producto;
            this.precio = producto.Precio;
            this.esFavorito = esFavorito;
        }

        public override string ToString() {
            return this.mostrarNombre();
        }

        public float Precio { get => precio; set => precio = value; }

        public void agregarHijo(ICompuestoCarta hijo)
        {
            //No implementado
        }

        public bool esVigente()
        {
            return false;
        }

        public List<string> mostrarHijos()
        {
            return new List<string>();
        }

        public string mostrarNombre()
        {
            return producto.Nombre;
        }

        public List<ICompuestoCarta> obtenerHijos(int nivel)
        {
            return new List<ICompuestoCarta>();
        }

        public void quitarHijo(ICompuestoCarta hijo)
        {
            //No implementado
        }

        public bool esFav()
        {
            return this.esFavorito;
        }
    }

    class Categoria
    {
        string nombre;

        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }


    }

    class Subcategoria
    {
        string nombre;

        public Subcategoria(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }

    class Producto
    {
        DateTime fechaCreacion;
        string foto;
        string nombre;
        float precio;

        public Producto(DateTime fechaCreacion, string foto, string nombre, float precio)
        {
            this.fechaCreacion = fechaCreacion;
            this.foto = foto;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
