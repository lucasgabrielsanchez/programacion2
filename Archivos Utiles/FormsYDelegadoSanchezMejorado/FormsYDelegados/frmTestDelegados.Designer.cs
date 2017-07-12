namespace FormsYDelegados
{
    partial class frmTestDelegados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnElegirFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(55, 23);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(172, 20);
            this.txtActualizar.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(81, 63);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 32);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnElegirFoto
            // 
            this.btnElegirFoto.Location = new System.Drawing.Point(99, 138);
            this.btnElegirFoto.Name = "btnElegirFoto";
            this.btnElegirFoto.Size = new System.Drawing.Size(91, 30);
            this.btnElegirFoto.TabIndex = 2;
            this.btnElegirFoto.Text = "Elegir Foto";
            this.btnElegirFoto.UseVisualStyleBackColor = true;
            this.btnElegirFoto.Click += new System.EventHandler(this.btnElegirFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnElegirFoto);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtActualizar);
            this.Name = "frmTestDelegados";
            this.Text = "frmTestDelegados";
            this.Load += new System.EventHandler(this.frmTestDelegados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnElegirFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}