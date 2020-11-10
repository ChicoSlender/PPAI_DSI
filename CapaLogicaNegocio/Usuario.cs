using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Usuario
    {
        string nombre;
        string perfil;
        string contraseña;
        DateTime fechaCreacion;
        DateTime fechaBaja;

        public Usuario(string nombre, string perfil, string contraseña, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.perfil = perfil;
            this.contraseña = contraseña;
            this.fechaCreacion = fechaCreacion;
        }

        public Empleado obtenerUsuario() {
            return Empleado.obtenerTodasLasInstancias().Find(empleado => empleado.esTuUsuario(this));
        }
    }
}
