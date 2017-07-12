using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsYDelegados
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            
        }

        public void ActualizarNombre(string dato)
        {
            this.lblCapturado.Text = dato;
            
        }

        public void ActualizarFoto(string path)
        {
            //propiedad que hace que si la imagen seleccionada es mas grande que el pictureBox, ésta se encoja para adaptarse al pictureBox, o si es mas chica se estira.
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.pictureBox1.Image = Image.FromFile(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDatos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
