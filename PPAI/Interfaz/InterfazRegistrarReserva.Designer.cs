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
            this.grillaTurno = new System.Windows.Forms.DataGridView();
            this.btnConfirmarReservaTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursoTecnologico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservarTurno
            // 
            this.btnReservarTurno.Location = new System.Drawing.Point(12, 12);
            this.btnReservarTurno.Name = "btnReservarTurno";
            this.btnReservarTurno.Size = new System.Drawing.Size(104, 38);
            this.btnReservarTurno.TabIndex = 0;
            this.btnReservarTurno.Text = "Opcion Reserva Turno";
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
            this.grillaRecursoTecnologico.Size = new System.Drawing.Size(542, 150);
            this.grillaRecursoTecnologico.TabIndex = 2;
            this.grillaRecursoTecnologico.SelectionChanged += new System.EventHandler(this.grillaRecursoTecnologico_SelectionChanged);
            // 
            // grillaTurno
            // 
            this.grillaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurno.Location = new System.Drawing.Point(12, 270);
            this.grillaTurno.Name = "grillaTurno";
            this.grillaTurno.Size = new System.Drawing.Size(542, 150);
            this.grillaTurno.TabIndex = 3;
            // 
            // btnConfirmarReservaTurno
            // 
            this.btnConfirmarReservaTurno.Location = new System.Drawing.Point(479, 513);
            this.btnConfirmarReservaTurno.Name = "btnConfirmarReservaTurno";
            this.btnConfirmarReservaTurno.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarReservaTurno.TabIndex = 4;
            this.btnConfirmarReservaTurno.Text = "Confirmar";
            this.btnConfirmarReservaTurno.UseVisualStyleBackColor = true;
            // 
            // InterfazRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 550);
            this.Controls.Add(this.btnConfirmarReservaTurno);
            this.Controls.Add(this.grillaTurno);
            this.Controls.Add(this.grillaRecursoTecnologico);
            this.Controls.Add(this.comboTipoRecursoTecnologico);
            this.Controls.Add(this.btnReservarTurno);
            this.Name = "InterfazRegistrarReserva";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursoTecnologico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservarTurno;
        private System.Windows.Forms.ComboBox comboTipoRecursoTecnologico;
        private System.Windows.Forms.DataGridView grillaRecursoTecnologico;
        private System.Windows.Forms.DataGridView grillaTurno;
        private System.Windows.Forms.Button btnConfirmarReservaTurno;
    }
}

