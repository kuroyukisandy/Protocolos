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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.B_buscar = new System.Windows.Forms.Button();
            this.B_captar = new System.Windows.Forms.Button();
            this.CH_io = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_datos = new System.Windows.Forms.TextBox();
            this.CB_Interfaz = new System.Windows.Forms.ComboBox();
            this.TC_operacion = new System.Windows.Forms.TabControl();
            this.TP_paquetes = new System.Windows.Forms.TabPage();
            this.PB_tiempo = new System.Windows.Forms.ProgressBar();
            this.NUD_mins = new System.Windows.Forms.NumericUpDown();
            this.TP_flujo = new System.Windows.Forms.TabPage();
            this.LB_flow = new System.Windows.Forms.ListBox();
            this.TP_io = new System.Windows.Forms.TabPage();
            this.TP_protocolos = new System.Windows.Forms.TabPage();
            this.CH_protocolos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Time_Graf = new System.Windows.Forms.Timer(this.components);
            this.B_Pausar = new System.Windows.Forms.Button();
            this.B_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).BeginInit();
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
            this.B_buscar.Visible = false;
            // 
            // B_captar
            // 
            this.B_captar.Location = new System.Drawing.Point(417, 71);
            this.B_captar.Name = "B_captar";
            this.B_captar.Size = new System.Drawing.Size(75, 23);
            this.B_captar.TabIndex = 1;
            this.B_captar.Text = "Captar";
            this.B_captar.UseVisualStyleBackColor = true;
            this.B_captar.Click += new System.EventHandler(this.B_captar_Click);
            // 
            // CH_io
            // 
            chartArea3.Name = "ChartArea1";
            this.CH_io.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CH_io.Legends.Add(legend3);
            this.CH_io.Location = new System.Drawing.Point(18, 6);
            this.CH_io.Name = "CH_io";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.CH_io.Series.Add(series3);
            this.CH_io.Size = new System.Drawing.Size(871, 334);
            this.CH_io.TabIndex = 2;
            // 
            // TB_datos
            // 
            this.TB_datos.Location = new System.Drawing.Point(16, 6);
            this.TB_datos.Multiline = true;
            this.TB_datos.Name = "TB_datos";
            this.TB_datos.ReadOnly = true;
            this.TB_datos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_datos.Size = new System.Drawing.Size(879, 337);
            this.TB_datos.TabIndex = 3;
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
            this.TC_operacion.Size = new System.Drawing.Size(929, 377);
            this.TC_operacion.TabIndex = 6;
            // 
            // TP_paquetes
            // 
            this.TP_paquetes.Controls.Add(this.TB_datos);
            this.TP_paquetes.Location = new System.Drawing.Point(4, 22);
            this.TP_paquetes.Name = "TP_paquetes";
            this.TP_paquetes.Padding = new System.Windows.Forms.Padding(3);
            this.TP_paquetes.Size = new System.Drawing.Size(921, 351);
            this.TP_paquetes.TabIndex = 0;
            this.TP_paquetes.Text = "Paquetes";
            this.TP_paquetes.UseVisualStyleBackColor = true;
            // 
            // PB_tiempo
            // 
            this.PB_tiempo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_tiempo.Location = new System.Drawing.Point(0, 481);
            this.PB_tiempo.Name = "PB_tiempo";
            this.PB_tiempo.Size = new System.Drawing.Size(1041, 23);
            this.PB_tiempo.TabIndex = 6;
            // 
            // NUD_mins
            // 
            this.NUD_mins.Location = new System.Drawing.Point(12, 163);
            this.NUD_mins.Name = "NUD_mins";
            this.NUD_mins.Size = new System.Drawing.Size(48, 20);
            this.NUD_mins.TabIndex = 5;
            this.NUD_mins.Visible = false;
            // 
            // TP_flujo
            // 
            this.TP_flujo.Controls.Add(this.LB_flow);
            this.TP_flujo.Location = new System.Drawing.Point(4, 22);
            this.TP_flujo.Name = "TP_flujo";
            this.TP_flujo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_flujo.Size = new System.Drawing.Size(921, 351);
            this.TP_flujo.TabIndex = 1;
            this.TP_flujo.Text = "Grafica de Flujo";
            this.TP_flujo.UseVisualStyleBackColor = true;
            // 
            // LB_flow
            // 
            this.LB_flow.FormattingEnabled = true;
            this.LB_flow.Location = new System.Drawing.Point(149, 24);
            this.LB_flow.Name = "LB_flow";
            this.LB_flow.Size = new System.Drawing.Size(617, 316);
            this.LB_flow.TabIndex = 0;
            // 
            // TP_io
            // 
            this.TP_io.Controls.Add(this.CH_io);
            this.TP_io.Location = new System.Drawing.Point(4, 22);
            this.TP_io.Name = "TP_io";
            this.TP_io.Padding = new System.Windows.Forms.Padding(3);
            this.TP_io.Size = new System.Drawing.Size(921, 351);
            this.TP_io.TabIndex = 2;
            this.TP_io.Text = "Grafica I/O";
            this.TP_io.UseVisualStyleBackColor = true;
            // 
            // TP_protocolos
            // 
            this.TP_protocolos.Controls.Add(this.B_Actualizar);
            this.TP_protocolos.Controls.Add(this.CH_protocolos);
            this.TP_protocolos.Location = new System.Drawing.Point(4, 22);
            this.TP_protocolos.Name = "TP_protocolos";
            this.TP_protocolos.Padding = new System.Windows.Forms.Padding(3);
            this.TP_protocolos.Size = new System.Drawing.Size(921, 351);
            this.TP_protocolos.TabIndex = 3;
            this.TP_protocolos.Text = "Protocolos";
            this.TP_protocolos.UseVisualStyleBackColor = true;
            // 
            // CH_protocolos
            // 
            chartArea4.Name = "ChartArea1";
            this.CH_protocolos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CH_protocolos.Legends.Add(legend4);
            this.CH_protocolos.Location = new System.Drawing.Point(3, 36);
            this.CH_protocolos.Name = "CH_protocolos";
            this.CH_protocolos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.CH_protocolos.Series.Add(series4);
            this.CH_protocolos.Size = new System.Drawing.Size(912, 314);
            this.CH_protocolos.TabIndex = 0;
            // 
            // Time_Graf
            // 
            this.Time_Graf.Interval = 30000;
            this.Time_Graf.Tick += new System.EventHandler(this.Time_Graf_Tick);
            // 
            // B_Pausar
            // 
            this.B_Pausar.Location = new System.Drawing.Point(417, 71);
            this.B_Pausar.Name = "B_Pausar";
            this.B_Pausar.Size = new System.Drawing.Size(75, 23);
            this.B_Pausar.TabIndex = 7;
            this.B_Pausar.Text = "Pausar";
            this.B_Pausar.UseVisualStyleBackColor = true;
            this.B_Pausar.Visible = false;
            this.B_Pausar.Click += new System.EventHandler(this.B_Pausar_Click);
            // 
            // B_Actualizar
            // 
            this.B_Actualizar.Location = new System.Drawing.Point(18, 7);
            this.B_Actualizar.Name = "B_Actualizar";
            this.B_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.B_Actualizar.TabIndex = 1;
            this.B_Actualizar.Text = "Actualizar";
            this.B_Actualizar.UseVisualStyleBackColor = true;
            this.B_Actualizar.Click += new System.EventHandler(this.B_Actualizar_Click);
            // 
            // F_protocolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 504);
            this.Controls.Add(this.PB_tiempo);
            this.Controls.Add(this.B_Pausar);
            this.Controls.Add(this.TC_operacion);
            this.Controls.Add(this.CB_Interfaz);
            this.Controls.Add(this.NUD_mins);
            this.Controls.Add(this.B_captar);
            this.Controls.Add(this.B_buscar);
            this.Name = "F_protocolos";
            this.Text = "Protocolos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_protocolos_FormClosing);
            this.Load += new System.EventHandler(this.F_protocolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).EndInit();
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
        private System.Windows.Forms.ComboBox CB_Interfaz;
        private System.Windows.Forms.TabControl TC_operacion;
        private System.Windows.Forms.TabPage TP_paquetes;
        private System.Windows.Forms.TabPage TP_flujo;
        private System.Windows.Forms.TabPage TP_io;
        private System.Windows.Forms.TabPage TP_protocolos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_protocolos;
        private System.Windows.Forms.ProgressBar PB_tiempo;
        private System.Windows.Forms.NumericUpDown NUD_mins;
        private System.Windows.Forms.ListBox LB_flow;
        private System.Windows.Forms.Timer Time_Graf;
        private System.Windows.Forms.Button B_Pausar;
        private System.Windows.Forms.Button B_Actualizar;
    }
}

