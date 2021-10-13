using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    //default es private
    public class Medico
    {
        #region constructores
        //default
        public Medico()
        {

        }
        //parametros
        public Medico(string nombre, string apellido, string matricula)
        {
            //inicializamos las propiedades
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
        }
        #endregion

        #region propiedades autoimplementadas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        #endregion
    }
}
