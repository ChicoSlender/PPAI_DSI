using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio
{
    class Sesion
    {
        DateTime fechaFin;
        DateTime fechaInicio;
        DateTime horaFin;
        DateTime horaInicio;
        Usuario usuario;

        static Sesion sesionActual;

        public Sesion(DateTime fechaInicio, DateTime horaInicio, Usuario usuario)
        {
            this.fechaInicio = fechaInicio;
            this.horaInicio = horaInicio;
            this.usuario = usuario;
            Sesion.sesionActual = this;
        }

        public static Sesion obtenerSesionActual() {
            return Sesion.sesionActual;
        }

        public Empleado obtenerUsuarioLog() {
            return this.usuario.obtenerUsuario();
        }
    }
}
