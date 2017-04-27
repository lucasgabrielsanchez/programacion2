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
    public partial class FrmPrincipal : Form
    {
        private List<Tempera> _temperas;

        public FrmPrincipal()
        {
            InitializeComponent();
            this._temperas = new List<Tempera>();
            this.Text = "Gestion de Temperas";
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("");
            FrmTempera frm = new FrmTempera();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //frm.ShowDialog(FrmTempera.ActiveForm);//Primero se llama al formulario de carga de Temperas para cargar los parametros
            //                                //de una tempera nueva que se va a instanciar al tocar el boton aceptar de dicho
            //                                //formulario. Entonces como la tempera ya fue cargada, el siguiente paso es el
            //                                //de agregar al List de FrmPrincipal, la tempera de FrmTempera instanciada.
            //                                //Utilzo el metodo ShowDialog en frm para que la aplicación espere el resultado
            //                                //que me va a dar el FrmTempera para poder proseguir con la ejecución de la aplicación.

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    this._temperas.Add(frm.Tempera); //cargo en la coleccion List de este formulario, el objeto Tempera instanciado
            //    //en FrmTempera. Para ello, utilizo la PROPIEDAD Tempera de solo lectura que
            //    //me devuelve justamente el objeto de FrmTempera con la propiedad get que creamos.
            //}

            if (frm.ShowDialog(FrmTempera.ActiveForm) == DialogResult.OK)
            {
                this._temperas.Add(frm.Tempera);
            }
                
            
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMost = new FrmMostrar(this._temperas);
            frmMost.Show();
        }
    }
}
