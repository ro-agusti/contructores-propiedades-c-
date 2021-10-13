using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    public class Clinica
    {
        #region propiedades autoimplementadas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        #endregion
    }
}
