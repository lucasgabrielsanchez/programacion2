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
    public partial class frmTestDelegados : Form
    {
        //public event DelegadoString enviarTexto;

        //public event DelegadoString enviarPathFoto;
        //public event DelegadoString EventoActualizar;
        private string _pathFoto;

        public frmTestDelegados()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            //this.EventoActualizar(this.txtActualizar.Text);

            
            //this.enviarTexto(this.txtActualizar.Text);

            //validar que no pinche si frmDatos no fué abierto, esto verifica que el delegado actualizarNombrePorDelegado sea distinto de null, (es null cuando no
            //tiene ningún método (o llamado manejador) que procese el texto.
            //if(((frmPrincipal)this.Owner).actualizarNombrePorDelegado != null)

            ((frmPrincipal)this.Owner).actualizarNombrePorDelegado(this.txtActualizar.Text);
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            //this.openFileDialog1 = new OpenFileDialog();
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            //de un lado el nombre y del otro la extensión/extensiones
            this.openFileDialog1.Filter = "Imagenes|*.jpg";
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.CheckPathExists = true;
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Seleccione una foto...";
            //establece que en el cuadro de texto donde se escribe el nombre del archivo o path no aparezca nada en este caso.
            this.openFileDialog1.FileName = "";
            
        }

        private void btnElegirFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this._pathFoto = this.openFileDialog1.FileName;

            if (this._pathFoto != "")
            {
                ((frmPrincipal)this.Owner).actualizarFotoPorDelegado(this._pathFoto);
                //this.enviarPathFoto(this._pathFoto);
            }
        }
    }
}
