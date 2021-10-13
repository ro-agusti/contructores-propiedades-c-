using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    public class Enfermero
    {
        #region constructores
        public Enfermero() { }
        public Enfermero(string apellido, string nombre, DateTime fechaNacimiento, string domicilio)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
        }
        #endregion
        #region propiedades autoimplementadas
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        #endregion
    }
}
