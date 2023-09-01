
namespace Videos_descargadoss
{
    partial class frmReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.cboSeleccion = new System.Windows.Forms.ComboBox();
            this.lblSeleccione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(3, 54);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(638, 349);
            this.wmpReproductor.TabIndex = 0;
            // 
            // cboSeleccion
            // 
            this.cboSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccion.FormattingEnabled = true;
            this.cboSeleccion.Location = new System.Drawing.Point(3, 27);
            this.cboSeleccion.Name = "cboSeleccion";
            this.cboSeleccion.Size = new System.Drawing.Size(638, 21);
            this.cboSeleccion.TabIndex = 1;
            this.cboSeleccion.SelectedIndexChanged += new System.EventHandler(this.cboSeleccion_SelectedIndexChanged);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(0, 9);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(111, 15);
            this.lblSeleccione.TabIndex = 2;
            this.lblSeleccione.Text = "Seleccione el video";
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.cboSeleccion);
            this.Controls.Add(this.wmpReproductor);
            this.Name = "frmReproductor";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
        private System.Windows.Forms.ComboBox cboSeleccion;
        private System.Windows.Forms.Label lblSeleccione;
    }
}

