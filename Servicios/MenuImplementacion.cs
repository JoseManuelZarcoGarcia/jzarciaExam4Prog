using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaExam4Prog.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuPrincipal() 
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado consultas");
            Console.WriteLine(string.Concat("-----------------", "\\n"));
            int opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada; 
        }

        public int subMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. mostrar consultas");
            Console.WriteLine("2. imprimir consultas");
            Console.WriteLine(string.Concat("-----------------","\\n"));
            int opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

        public int segundoSubMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("0. Psicologia");
            Console.WriteLine("1. Traumatologia");
            Console.WriteLine("2. Fisioterapia");
            Console.WriteLine(string.Concat("-----------------", "\\n"));
            int opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

    }
}
