using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegaucho.Shared.Entities
{
    public enum Accion
    {
        CREAR_ORDEN,
        MODIFICAR_ORDEN,
        CAMBIAR_ESTADO_ORDEN,
        ELIMINAR_ORDEN,
        INICIAR_TAREA,
        FINALIZAR_TAREA,
        REPORTAR_ESTADO,
        REGISTRAR_INCIDENTE,
        VERIFICAR_PRODUCTO  
    }
}
