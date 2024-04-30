using jzarciaExam4Prog.Dtos;
using jzarciaExam4Prog.Servicios;

namespace jzarciaExam4Prog.Controladores
{
    /// <summary>
    /// Clase principal por la que empieza el programa
    /// </summary>
    class Program
    {
        static public DateTime fechaParaLog = DateTime.Now;
        static public string archivoInicial = "C:\\Users\\csi22-jzarcia\\Desktop\\citas.txt";
        // static public string archivoLog = string.Concat("C:\\Users\\csi22-jzarcia\\Desktop\\log-", fechaParaLog("ddMMyyyy"), ".txt");
        /// <summary>
        /// Método Main por el que empieza el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
             List<CitasDto> listaCitas = new List<CitasDto>();
             listaCitas = fi.cargaInicialLista();
            string ficheroLog = "";
            string ficheroImprimirConsulta = string.Concat("C:\\Users\\csi22-jzarcia\\Desktop\\", "citasConAsistencia-","", ".txt");
            string especialidad;
            int opcionSeleccionad, especialidadSeleccionada;
            bool cerrarMenu = false;
            do
            {

                try
                {
                    opcionSeleccionad = mi.menuPrincipal();   

                    switch(opcionSeleccionad)
                    {
                        case 0:
                            cerrarMenu= true;
                            break; 
                        case 1:

                            break;
                        case 2:

                            do
                            {

                                opcionSeleccionad = mi.subMenu();
                                switch (opcionSeleccionad)
                                {
                                    case 0:
                                        cerrarMenu = true;
                                        break;
                                    case 1: //mostrar consulta
                                        especialidadSeleccionada = mi.segundoSubMenu();
                                        
                                        switch (especialidadSeleccionada)
                                        {
                                            case 0:
                                                especialidad = "Psicología";
                                                break; 
                                            case 1:
                                                especialidad = "Traumatología";
                                                break;
                                            case 2:
                                                especialidad = "Fisioterapia";
                                                break;
                                            default:
                                                break;
                                        }
                                            

                                        break;
                                    case 2: //imprimir consulta
                                        especialidadSeleccionada = mi.segundoSubMenu();

                                        switch (especialidadSeleccionada)
                                        {
                                            case 0:
                                                especialidad = "Psicología";
                                                break;
                                            case 1:
                                                especialidad = "Traumatología";
                                                break;
                                            case 2:
                                                especialidad = "Fisioterapia";
                                                break;
                                            default:
                                                break;
                                        }

                                        break;

                                    default:
                                        break;
                                }

                            } while (!cerrarMenu);
                            
                            break;
                        default:
                            break;

                    }

                }
                catch (Exception ex)
                {
                    
                    
                    throw;
                }

            }while (!cerrarMenu);


        }

    }

}