namespace PPAI
{
    partial class InterfazRegistrarReserva
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
            this.btnReservarTurno = new System.Windows.Forms.Button();
            this.comboTipoRecursoTecnologico = new System.Windows.Forms.ComboBox();
            this.grillaRecursoTecnologico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursoTecnologico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservarTurno
            // 
            this.btnReservarTurno.Location = new System.Drawing.Point(12, 12);
            this.btnReservarTurno.Name = "btnReservarTurno";
            this.btnReservarTurno.Size = new System.Drawing.Size(91, 23);
            this.btnReservarTurno.TabIndex = 0;
            this.btnReservarTurno.Text = "button1";
            this.btnReservarTurno.UseVisualStyleBackColor = true;
            this.btnReservarTurno.Click += new System.EventHandler(this.btnReservarTurno_Click);
            // 
            // comboTipoRecursoTecnologico
            // 
            this.comboTipoRecursoTecnologico.FormattingEnabled = true;
            this.comboTipoRecursoTecnologico.Location = new System.Drawing.Point(122, 12);
            this.comboTipoRecursoTecnologico.Name = "comboTipoRecursoTecnologico";
            this.comboTipoRecursoTecnologico.Size = new System.Drawing.Size(432, 21);
            this.comboTipoRecursoTecnologico.TabIndex = 1;
            this.comboTipoRecursoTecnologico.SelectedIndexChanged += new System.EventHandler(this.comboTipoRecursoTecnologico_SelectedIndexChanged);
            // 
            // grillaRecursoTecnologico
            // 
            this.grillaRecursoTecnologico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecursoTecnologico.Location = new System.Drawing.Point(12, 71);
            this.grillaRecursoTecnologico.Name = "grillaRecursoTecnologico";
            this.grillaRecursoTecnologico.Size = new System.Drawing.Size(324, 150);
            this.grillaRecursoTecnologico.TabIndex = 2;
            // 
            // InterfazRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 617);
            this.Controls.Add(this.grillaRecursoTecnologico);
            this.Controls.Add(this.comboTipoRecursoTecnologico);
            this.Controls.Add(this.btnReservarTurno);
            this.Name = "InterfazRegistrarReserva";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursoTecnologico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservarTurno;
        private System.Windows.Forms.ComboBox comboTipoRecursoTecnologico;
        private System.Windows.Forms.DataGridView grillaRecursoTecnologico;
    }
}

