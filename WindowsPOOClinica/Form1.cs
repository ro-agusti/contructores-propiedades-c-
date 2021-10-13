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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            //declarar y crer una instancia de Medico
            //creando un objeto
            Medico medico = new Medico();
            //escribir las propiedades - SET 
            medico.Apellido = "Perez";
            medico.Nombre = "Juan";
            medico.Matricula = "123ABC";
            //leer propiedades -GET
            MessageBox.Show($"{medico.Apellido} {medico.Nombre} {medico.Matricula}");

            //ejemplo de instancia usando constructos con parametro
            Medico medico1 = new Medico("ana", "Lopez", "25ge3");
            MessageBox.Show($"{medico1.Apellido} {medico1.Nombre} {medico1.Matricula}");
        }
    }
}
