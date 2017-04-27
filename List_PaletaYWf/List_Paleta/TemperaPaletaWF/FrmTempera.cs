using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06.Paletas.Entidades;

namespace TemperaPaletaWF
{
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;

        public Tempera Tempera
        {
            get
            {
                return this._tempera;
            }
        }

        public FrmTempera()
        {
            InitializeComponent();

            //El consolecolor es un enumerado

            
            //recorro el enumerado Consolecolor y guardo cada tipo Consolecolor en "asd", para luego introducirlos al
            //comboBox
            foreach (ConsoleColor asd in Enum.GetValues(typeof(ConsoleColor)))
            {
                cboColores.Items.Add(asd); //agrego items al comboBox especificado,Y ESOS ITEMS SON OBJECTS, ES LO QUE ESPERA
                                           //el metodo Add
            }

            
            
            
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tempera = new Tempera((ConsoleColor)cboColores.SelectedItem, textBox1.Text, int.Parse(textBox2.Text));//casteo el selecteditem del combobox para transformarlo de objeto a consolecolor
            MessageBox.Show(Tempera.Mostrar(_tempera)); //muestro los parametros de la tempera instanciada
            this.DialogResult = DialogResult.OK;
        }
    }
}
