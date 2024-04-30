using jzarciaExam4Prog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaExam4Prog.Servicios
{
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo que carga al inicio del programa las entidades CitasDto de un fichero a la lista de Citas
        /// </summary>
        /// <returns></returns>
        public List<CitasDto> cargaInicialLista();

    }
}
