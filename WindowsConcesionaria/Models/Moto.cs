using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConcesionaria.Models
{
    public class Moto
    {
        #region constructor con parametro
        public Moto(string marca, string modelo, string color, string matricula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Matricula = matricula;
            Año = año;
        }
        #endregion
        #region propiedades autoimplementadas
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public int Año { get; set; }
        #endregion
    }
}
