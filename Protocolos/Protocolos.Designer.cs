namespace Protocolos
{
    partial class F_protocolos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.B_buscar = new System.Windows.Forms.Button();
            this.B_captar = new System.Windows.Forms.Button();
            this.CH_io = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_datos = new System.Windows.Forms.TextBox();
            this.CH_flujo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CB_Interfaz = new System.Windows.Forms.ComboBox();
            this.TC_operacion = new System.Windows.Forms.TabControl();
            this.TP_paquetes = new System.Windows.Forms.TabPage();
            this.PB_tiempo = new System.Windows.Forms.ProgressBar();
            this.NUD_mins = new System.Windows.Forms.NumericUpDown();
            this.TP_flujo = new System.Windows.Forms.TabPage();
            this.TP_io = new System.Windows.Forms.TabPage();
            this.TP_protocolos = new System.Windows.Forms.TabPage();
            this.CH_protocolos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_flujo)).BeginInit();
            this.TC_operacion.SuspendLayout();
            this.TP_paquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_mins)).BeginInit();
            this.TP_flujo.SuspendLayout();
            this.TP_io.SuspendLayout();
            this.TP_protocolos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CH_protocolos)).BeginInit();
            this.SuspendLayout();
            // 
            // B_buscar
            // 
            this.B_buscar.Location = new System.Drawing.Point(63, 31);
            this.B_buscar.Name = "B_buscar";
            this.B_buscar.Size = new System.Drawing.Size(75, 23);
            this.B_buscar.TabIndex = 0;
            this.B_buscar.Text = "buscar";
            this.B_buscar.UseVisualStyleBackColor = true;
            // 
            // B_captar
            // 
            this.B_captar.Location = new System.Drawing.Point(126, 14);
            this.B_captar.Name = "B_captar";
            this.B_captar.Size = new System.Drawing.Size(75, 23);
            this.B_captar.TabIndex = 1;
            this.B_captar.Text = "Captar";
            this.B_captar.UseVisualStyleBackColor = true;
            this.B_captar.Click += new System.EventHandler(this.B_captar_Click);
            // 
            // CH_io
            // 
            chartArea7.Name = "ChartArea1";
            this.CH_io.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.CH_io.Legends.Add(legend7);
            this.CH_io.Location = new System.Drawing.Point(18, 28);
            this.CH_io.Name = "CH_io";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.CH_io.Series.Add(series7);
            this.CH_io.Size = new System.Drawing.Size(871, 312);
            this.CH_io.TabIndex = 2;
            this.CH_io.Text = "chart1";
            // 
            // TB_datos
            // 
            this.TB_datos.Location = new System.Drawing.Point(16, 112);
            this.TB_datos.Multiline = true;
            this.TB_datos.Name = "TB_datos";
            this.TB_datos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_datos.Size = new System.Drawing.Size(879, 231);
            this.TB_datos.TabIndex = 3;
            // 
            // CH_flujo
            // 
            chartArea8.Name = "ChartArea1";
            this.CH_flujo.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.CH_flujo.Legends.Add(legend8);
            this.CH_flujo.Location = new System.Drawing.Point(6, 19);
            this.CH_flujo.Name = "CH_flujo";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.CH_flujo.Series.Add(series8);
            this.CH_flujo.Size = new System.Drawing.Size(867, 317);
            this.CH_flujo.TabIndex = 4;
            this.CH_flujo.Text = "chart2";
            // 
            // CB_Interfaz
            // 
            this.CB_Interfaz.FormattingEnabled = true;
            this.CB_Interfaz.Location = new System.Drawing.Point(63, 71);
            this.CB_Interfaz.Name = "CB_Interfaz";
            this.CB_Interfaz.Size = new System.Drawing.Size(348, 21);
            this.CB_Interfaz.TabIndex = 5;
            // 
            // TC_operacion
            // 
            this.TC_operacion.Controls.Add(this.TP_paquetes);
            this.TC_operacion.Controls.Add(this.TP_flujo);
            this.TC_operacion.Controls.Add(this.TP_io);
            this.TC_operacion.Controls.Add(this.TP_protocolos);
            this.TC_operacion.Location = new System.Drawing.Point(78, 98);
            this.TC_operacion.Name = "TC_operacion";
            this.TC_operacion.SelectedIndex = 0;
            this.TC_operacion.Size = new System.Drawing.Size(929, 382);
            this.TC_operacion.TabIndex = 6;
            // 
            // TP_paquetes
            // 
            this.TP_paquetes.Controls.Add(this.PB_tiempo);
            this.TP_paquetes.Controls.Add(this.NUD_mins);
            this.TP_paquetes.Controls.Add(this.TB_datos);
            this.TP_paquetes.Controls.Add(this.B_captar);
            this.TP_paquetes.Location = new System.Drawing.Point(4, 22);
            this.TP_paquetes.Name = "TP_paquetes";
            this.TP_paquetes.Padding = new System.Windows.Forms.Padding(3);
            this.TP_paquetes.Size = new System.Drawing.Size(921, 356);
            this.TP_paquetes.TabIndex = 0;
            this.TP_paquetes.Text = "Paquetes";
            this.TP_paquetes.UseVisualStyleBackColor = true;
            // 
            // PB_tiempo
            // 
            this.PB_tiempo.Location = new System.Drawing.Point(16, 56);
            this.PB_tiempo.Name = "PB_tiempo";
            this.PB_tiempo.Size = new System.Drawing.Size(879, 23);
            this.PB_tiempo.TabIndex = 6;
            // 
            // NUD_mins
            // 
            this.NUD_mins.Location = new System.Drawing.Point(16, 17);
            this.NUD_mins.Name = "NUD_mins";
            this.NUD_mins.Size = new System.Drawing.Size(48, 20);
            this.NUD_mins.TabIndex = 5;
            this.NUD_mins.Visible = false;
            // 
            // TP_flujo
            // 
            this.TP_flujo.Controls.Add(this.CH_flujo);
            this.TP_flujo.Location = new System.Drawing.Point(4, 22);
            this.TP_flujo.Name = "TP_flujo";
            this.TP_flujo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_flujo.Size = new System.Drawing.Size(921, 356);
            this.TP_flujo.TabIndex = 1;
            this.TP_flujo.Text = "Grafica de Flujo";
            this.TP_flujo.UseVisualStyleBackColor = true;
            // 
            // TP_io
            // 
            this.TP_io.Controls.Add(this.CH_io);
            this.TP_io.Location = new System.Drawing.Point(4, 22);
            this.TP_io.Name = "TP_io";
            this.TP_io.Padding = new System.Windows.Forms.Padding(3);
            this.TP_io.Size = new System.Drawing.Size(921, 356);
            this.TP_io.TabIndex = 2;
            this.TP_io.Text = "Grafica I/O";
            this.TP_io.UseVisualStyleBackColor = true;
            // 
            // TP_protocolos
            // 
            this.TP_protocolos.Controls.Add(this.CH_protocolos);
            this.TP_protocolos.Location = new System.Drawing.Point(4, 22);
            this.TP_protocolos.Name = "TP_protocolos";
            this.TP_protocolos.Padding = new System.Windows.Forms.Padding(3);
            this.TP_protocolos.Size = new System.Drawing.Size(921, 356);
            this.TP_protocolos.TabIndex = 3;
            this.TP_protocolos.Text = "Protocolos";
            this.TP_protocolos.UseVisualStyleBackColor = true;
            // 
            // CH_protocolos
            // 
            chartArea9.Name = "ChartArea1";
            this.CH_protocolos.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.CH_protocolos.Legends.Add(legend9);
            this.CH_protocolos.Location = new System.Drawing.Point(18, 6);
            this.CH_protocolos.Name = "CH_protocolos";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.CH_protocolos.Series.Add(series9);
            this.CH_protocolos.Size = new System.Drawing.Size(862, 344);
            this.CH_protocolos.TabIndex = 0;
            this.CH_protocolos.Text = "chart1";
            // 
            // F_protocolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 492);
            this.Controls.Add(this.TC_operacion);
            this.Controls.Add(this.CB_Interfaz);
            this.Controls.Add(this.B_buscar);
            this.Name = "F_protocolos";
            this.Text = "Protocolos";
            this.Load += new System.EventHandler(this.F_protocolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_flujo)).EndInit();
            this.TC_operacion.ResumeLayout(false);
            this.TP_paquetes.ResumeLayout(false);
            this.TP_paquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_mins)).EndInit();
            this.TP_flujo.ResumeLayout(false);
            this.TP_io.ResumeLayout(false);
            this.TP_protocolos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CH_protocolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_buscar;
        private System.Windows.Forms.Button B_captar;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_io;
        private System.Windows.Forms.TextBox TB_datos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_flujo;
        private System.Windows.Forms.ComboBox CB_Interfaz;
        private System.Windows.Forms.TabControl TC_operacion;
        private System.Windows.Forms.TabPage TP_paquetes;
        private System.Windows.Forms.TabPage TP_flujo;
        private System.Windows.Forms.TabPage TP_io;
        private System.Windows.Forms.TabPage TP_protocolos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_protocolos;
        private System.Windows.Forms.ProgressBar PB_tiempo;
        private System.Windows.Forms.NumericUpDown NUD_mins;
    }
}

