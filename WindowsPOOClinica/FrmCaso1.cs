using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPOOClinica.Models;

namespace WindowsPOOClinica
{
    public partial class FrmCaso1 : Form
    {
        public FrmCaso1()
        {
            InitializeComponent();
        }

        private void btnImprimirInfo_Click(object sender, EventArgs e)
        {
            //inicializacion por default
            Enfermero enfermero;
            enfermero = new Enfermero();
            enfermero.Apellido = "Gomez";
            enfermero.Nombre = "Laura";
            enfermero.FechaNacimiento = new DateTime(1990, 05, 30);
            enfermero.Domicilio = "San Martin 1253";

            Paciente paciente = new Paciente() { Apellido = "Perez", Nombre = "Juan", FechaNacimiento = Convert.ToDateTime("25/03/1961"), Domicilio = "Uruguay 532", NroHistoriaClinica = 5234 };

            Director director = new Director() { Apellido = "Lopez", Nombre = "Maria", FechaNacimiento = Convert.ToDateTime("30/05/1970"), Domicilio = "La plata 1452" };

            //inicializacion con parametros 
            Paciente paciente1 = new Paciente("Gomez", "Laura", new DateTime(1978,03,15), "San lui 123", 1356);
            Enfermero enfermero1 = new Enfermero("Perez", "Martin", new DateTime(1995, 03, 15), "mendoza 123");
            Director director1 = new Director("Lopez", "Juan Carlos", new DateTime(1956, 03, 15), "mendoza 123");

            MessageBox.Show($"CONTRUCTOR POR DEFAULT: \n Enfermero: {enfermero.Apellido}, {enfermero.Nombre}, {enfermero.FechaNacimiento.ToShortDateString()}, {enfermero.Domicilio}, \n Paciente: {paciente.Apellido}, {paciente.Nombre}, {paciente.FechaNacimiento.ToShortDateString()}, {paciente.Domicilio}, {paciente.NroHistoriaClinica} \n Director: {director.Apellido}, {director.Nombre}, {director.FechaNacimiento.ToShortDateString()}, {director.Domicilio} \n\n CONTRUCTOR CON PARAMETROS: \n  Paciente 2: {paciente1.Apellido}, {paciente1.Nombre}, {paciente1.FechaNacimiento.ToShortDateString()}, {paciente1.Domicilio}, {paciente1.NroHistoriaClinica} \n Enfermero: {enfermero1.Apellido}, {enfermero1.Nombre}, {enfermero1.FechaNacimiento.ToShortDateString()}, {enfermero1.Domicilio} \n Director: {director1.Apellido}, {director1.Nombre}, {director1.FechaNacimiento.ToShortDateString()}, {director1.Domicilio}");
        }
    }
}
