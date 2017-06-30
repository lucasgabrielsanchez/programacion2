using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase22Entidades;

namespace Clase22Form
{

    public partial class Form1 : Form
    {
        private static void ManejadorForm() // <= "manejador", método que usará el evento
        {
            MessageBox.Show("El sueldo superó el límite - manejador estático");
        }

        private void ManejadorForm1() // <= "manejador", método que usará el evento
        {
            MessageBox.Show("El sueldo superó el límite - manejador de instancia");
        }

        private static void Empleado_SueldoEventMejorado(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString() + ((EmpleadoEventArgs)e).NumDouble , "Sueldo Superado");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));

            emp.SueldoEvent += Form1.ManejadorForm;

            Form1 fr = new Form1();

            emp.SueldoEvent += fr.ManejadorForm1;

            emp.SueldoEventMejorado += Form1.Empleado_SueldoEventMejorado;

            try
            {
               emp.Sueldo = double.Parse(textBox4.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
