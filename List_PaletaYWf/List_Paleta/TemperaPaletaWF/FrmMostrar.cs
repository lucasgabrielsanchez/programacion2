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
    public partial class FrmMostrar : Form
    {
        private List<Tempera> _temperas;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(List<Tempera> listaTempera) : this()
        {
            this._temperas = listaTempera;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

            this.Refrescar();

            foreach (Tempera temp in _temperas)
	        {
                listBox1.Items.Add((string)temp);
	        }

            

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
            int indexAux = listBox1.SelectedIndex;

            if (indexAux >= 0)
            {
                this._temperas.RemoveAt(indexAux);
            }

            this.Refrescar();

        }

        private void Refrescar()
        {
            listBox1.Items.Clear();
        }
    }
}
