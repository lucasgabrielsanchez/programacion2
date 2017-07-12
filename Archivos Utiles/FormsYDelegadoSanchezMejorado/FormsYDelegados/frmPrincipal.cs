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
    //Delegado definido en el codefile

    public partial class frmPrincipal : Form
    {
        //atributo del tipo del delegado
        public DelegadoString actualizarNombrePorDelegado;
        public DelegadoString actualizarFotoPorDelegado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            #region Propiedades frmPrincipal
            this.Text = "frmPrincipal";

            this.IsMdiContainer = true;

            this.WindowState = FormWindowState.Maximized; 
            #endregion

            //desactivo la opción del menu "Mostrar" de frmPrincipal
            this.mostrarToolStripMenuItem.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frmDelegados = new frmTestDelegados();

            //me suscribo a estos eventos generados por frmDelegados
            frmDelegados.Load += this.DeshabilitarMenuTest;
            frmDelegados.Load += this.HabilitarMenuMostrar2;

            frmDelegados.FormClosing += this.HabilitarMenuTest;
            frmDelegados.FormClosing += this.DeshabilitarMenuMostrar;

            #region Propiedades del frmDelegados
            

            frmDelegados.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            frmDelegados.StartPosition = FormStartPosition.CenterScreen;

            frmDelegados.MaximizeBox = false;
            #endregion

            //frmDelegados.enviarTexto += new frmDatos().ActualizarNombre;

            //owner
            frmDelegados.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();

            //forma explícita
            //this.actualizarNombrePorDelegado = new DelegadoString(frmDatos.ActualizarNombre);

            //forma implícita
            this.actualizarNombrePorDelegado += frmDatos.ActualizarNombre;
            //this.actualizarNombrePorDelegado("hola");
            
            this.actualizarFotoPorDelegado += frmDatos.ActualizarFoto;
            //frmDatos.FormClosing += this.FormularioCerrado;

            //Me suscribo a estos eventos generados por frmDatos
            frmDatos.Load += this.DeshabilitarMenuMostrar;
            frmDatos.FormClosing += this.HabilitarMenuMostrar;

            #region Propiedades de frmDatos

            frmDatos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            frmDatos.StartPosition = FormStartPosition.CenterScreen;

            frmDatos.MaximizeBox = false;
            #endregion

            //Mostrar la lista de métodos que un delegado tiene cargada.
            //Delegate[] lista = this.actualizarNombrePorDelegado.GetInvocationList();

            //for (int i = 0; i < 2; i++)
            //{
            //    MessageBox.Show(lista[i].Method.ToString());
            //}

            //owner
            frmDatos.Show(this);
        }

        //activo la opción del menu "Mostrar" de frmPrincipal
        public void HabilitarMenuMostrar(object sender, FormClosingEventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        //activo la opción del menu "Mostrar" de frmPrincipal
        public void HabilitarMenuMostrar2(object sender, EventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        //desactivo la opción del menu "Mostrar" de frmPrincipal
        public void DeshabilitarMenuMostrar(object sender, EventArgs e)
        {
            this.mostrarToolStripMenuItem.Enabled = false;
        }

        //activo la opción del menu "Alta" de frmPrincipal
        public void HabilitarMenuTest(object sender, FormClosingEventArgs e)
        {
            this.altaToolStripMenuItem.Enabled = true;
        }

        //desactivo la opción del menu "Alta" de frmPrincipal
        public void DeshabilitarMenuTest(object sender, EventArgs e)
        {
            this.altaToolStripMenuItem.Enabled = false;
        }
    }
}
