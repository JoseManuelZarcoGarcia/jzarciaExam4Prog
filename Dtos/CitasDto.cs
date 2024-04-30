using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarciaExam4Prog.Dtos
{
    /// <summary>
    /// Clase entidad que representara las citas medicas
    /// </summary>
    internal class CitasDto
    {

        //Atributos
        long idCita;
        string dniPaciente = "aaa";
        string monbrePaciente = "aaa";
        string apellidosPaciente = "aaa";
        string especialidad = "aaa";
        DateTime fechaCita = DateTime.Now;
        bool acistenciaCita = false;

        
        //Getter and Setter
        public long IdCita { get => idCita; set => idCita = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string MonbrePaciente { get => monbrePaciente; set => monbrePaciente = value; }
        public string ApellidosPaciente { get => apellidosPaciente; set => apellidosPaciente = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AcistenciaCita { get => acistenciaCita; set => acistenciaCita = value; }


        //Costructores
        public CitasDto(long idCita, string dniPaciente, string monbrePaciente, string apellidosPaciente, string especialidad, DateTime fechaCita, bool acistenciaCita)
        {
            this.idCita = idCita;
            this.dniPaciente = dniPaciente;
            this.monbrePaciente = monbrePaciente;
            this.apellidosPaciente = apellidosPaciente;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.acistenciaCita = acistenciaCita;
        }

        public CitasDto() { }

        override
        public string ToString()
        {
            string citasMedicasConsulta = string.Concat("", this.idCita, "", this.dniPaciente, "",this.monbrePaciente,
                "",this.apellidosPaciente, "",this.especialidad, "",this.fechaCita, "",this.acistenciaCita, "|");

            return citasMedicasConsulta;
        }
    }
}
