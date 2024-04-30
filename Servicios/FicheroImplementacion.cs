using jzarciaExam4Prog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaExam4Prog.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {

        public List<CitasDto> cargaInicialLista()
        {

            try
            {
                CitasDto nuevaCita = new CitasDto();
                List<CitasDto> carga = new List<CitasDto>();
                OperativaInterfaz op = new OperativaImplementacion();
                string[] lineas = File.ReadAllLines(Controladores.Program.archivoInicial);

                for (int i = 0; i <= lineas.Length; i++) 
                {

                    /*  Esta comentado ya que sino da error, por lo que 
                     *  
                    string acistenciaStringABool = lineas[i].Split(";")[5];
                    if (acistenciaStringABool == "true")
                    {
                        nuevaCita.AcistenciaCita = true;
                    }
                    nuevaCita.AcistenciaCita = false;
                    
                    DateTime fechaCitaStringADateTime = Convert.ToDateTime(lineas[i].Split(";")[4]);*/

                    nuevaCita.IdCita = op.crearId(carga);
                    nuevaCita.DniPaciente = lineas[i].Split(";")[0];
                    nuevaCita.MonbrePaciente = lineas[i].Split(";")[1];
                    nuevaCita.ApellidosPaciente = lineas[i].Split(";")[2];
                    nuevaCita.Especialidad = lineas[i].Split(";")[3];
                   // nuevaCita.FechaCita = fechaCitaStringADateTime;
                    

                    carga.Add(nuevaCita);

                }

                return carga;
            }
            catch (IOException ioex)
            {


                throw;
            }
        }

       
        public void mostrarConsultas(List<CitasDto> listaCitas)
        {

            Console.WriteLine("Indique la fecha que quiera consultar");
            DateTime fechaConsulta = Convert.ToDateTime(Console.ReadLine());

            foreach (CitasDto dto in listaCitas)
            {
                Console.WriteLine(dto.ToString());
            }

        }




    }
}
