using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConcesionaria.Models
{
    
    public class Auto
    {
        #region constructor con parametro
        public Auto( string marca, string modelo, string color, int cantPuertas, string matricula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            CantPuertas = cantPuertas;
            Matricula = matricula;
            Año = año;
        }
        #endregion
        #region propiedades autoimplementadas
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int CantPuertas { get; set; }
        public string Matricula { get; set; }
        public int Año { get; set; }
        #endregion
    }
}
