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


        }
        */


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
/*
for (int f = 0; f < carga.Count; f++)
{
    for (int c = 0; c < carga.Count - 1 - f; c++)
    {
        // ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )
        if (carga[c + 1] > carga[c])
        {
            CitasDto aux = carga[c + 1];
            carga[c + 1] = carga[c];
            carga[c] = aux;
        }
    }
    return carga;
}*/







/*

        
        // Metodo burbuja
        
        for (int f = 0; f<listaCliente.Count; f++)
        {
            for (int c = 0; c<listaCliente.Count - 1 - f; c++)
            {
                // ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )
                if (listaCliente[c + 1].FechaLlegadaAControl > listaCliente[c].FechaLlegadaAControl)
                {
                    Vehiculo aux = listaCliente[c + 1];
        listaCliente[c + 1] = listaCliente[c];
                    listaCliente[c] = aux;
                }


        }



        return listaCliente;

    }
}*/
