using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsConcesionaria.Models;

namespace WindowsConcesionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            //por default
            //Auto auto = new Auto() { Marca = "Audi", Modelo = "A1", Color = "Gris", CantPuertas = 3, Matricula = "AA236BC", Año = 2019 };
            //Camioneta camioneta = new Camioneta() { Marca = "Toyota", Modelo = "Hilux", Color = "Rojo", CantPuertas = 5, Matricula = "BB236BC", Año = 2021 };
            //Moto moto = new Moto() { Marca = "Vespa", Modelo = "all", Color = "amarillo", Matricula = "cc236BC", Año = 2021 };

            //por parametros
            Auto auto = new Auto("Audi", "A1", "Gris", 3, "AA236BC", 2019);
            Camioneta camioneta = new Camioneta("Toyota", "Hilux", "Rojo", 5, "BB236BC", 2021);
            Moto moto = new Moto("Vespa", "all", "amarillo", "cc236BC", 2021);

            MessageBox.Show($"Auto: {auto.Marca} - {auto.Modelo} - {auto.Color} - {auto.CantPuertas} - {auto.Matricula} - {auto.Año} \n Camioneta: {camioneta.Marca} - {camioneta.Modelo} - {camioneta.Color} - {camioneta.CantPuertas} - {camioneta.Matricula} - {camioneta.Año} \n Moto: {moto.Marca} - {moto.Modelo} - {moto.Color} - {moto.Matricula} - {moto.Año}");
        }
    }
}
