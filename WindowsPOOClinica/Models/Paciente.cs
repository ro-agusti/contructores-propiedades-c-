using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    public class Paciente
    {
        #region constructores
        public Paciente() { }
        public Paciente(string apellido, string nombre, DateTime fechaNacimiento, string domicilio, int nroHistoriaClinica)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
            NroHistoriaClinica = nroHistoriaClinica;
        }
        #endregion
        #region propiedades autoimplementadas
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public int NroHistoriaClinica { get; set; }
        #endregion
    }
}
