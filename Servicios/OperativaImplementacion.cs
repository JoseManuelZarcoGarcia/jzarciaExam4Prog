using jzarciaExam4Prog.Dtos;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaExam4Prog.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public List<object> registrarLLegada(List<object> listaRegistroLlegada)
        {


            return listaRegistroLlegada.ToList();
        }

        /*
        public bool validacionDni()
        {
            bool validacion = false;

        }*/
        


        public long crearId(List<CitasDto> lista)
        {
            int tamanyoLista = lista.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = lista[tamanyoLista - 1].IdCita + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaId;
        }
    }
}

