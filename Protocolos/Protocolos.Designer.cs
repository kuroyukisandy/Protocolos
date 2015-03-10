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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.B_buscar = new System.Windows.Forms.Button();
            this.B_captar = new System.Windows.Forms.Button();
            this.CH_io = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_datos = new System.Windows.Forms.TextBox();
            this.CH_flujo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CB_Interfaz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_flujo)).BeginInit();
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
            this.B_captar.Location = new System.Drawing.Point(167, 30);
            this.B_captar.Name = "B_captar";
            this.B_captar.Size = new System.Drawing.Size(75, 23);
            this.B_captar.TabIndex = 1;
            this.B_captar.Text = "Captar";
            this.B_captar.UseVisualStyleBackColor = true;
            this.B_captar.Click += new System.EventHandler(this.B_captar_Click);
            // 
            // CH_io
            // 
            chartArea1.Name = "ChartArea1";
            this.CH_io.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CH_io.Legends.Add(legend1);
            this.CH_io.Location = new System.Drawing.Point(470, 30);
            this.CH_io.Name = "CH_io";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CH_io.Series.Add(series1);
            this.CH_io.Size = new System.Drawing.Size(537, 203);
            this.CH_io.TabIndex = 2;
            this.CH_io.Text = "chart1";
            // 
            // TB_datos
            // 
            this.TB_datos.Location = new System.Drawing.Point(29, 120);
            this.TB_datos.Multiline = true;
            this.TB_datos.Name = "TB_datos";
            this.TB_datos.Size = new System.Drawing.Size(416, 282);
            this.TB_datos.TabIndex = 3;
            // 
            // CH_flujo
            // 
            chartArea2.Name = "ChartArea1";
            this.CH_flujo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CH_flujo.Legends.Add(legend2);
            this.CH_flujo.Location = new System.Drawing.Point(470, 277);
            this.CH_flujo.Name = "CH_flujo";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CH_flujo.Series.Add(series2);
            this.CH_flujo.Size = new System.Drawing.Size(537, 203);
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
            // F_protocolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 492);
            this.Controls.Add(this.CB_Interfaz);
            this.Controls.Add(this.CH_flujo);
            this.Controls.Add(this.TB_datos);
            this.Controls.Add(this.CH_io);
            this.Controls.Add(this.B_captar);
            this.Controls.Add(this.B_buscar);
            this.Name = "F_protocolos";
            this.Text = "Protocolos";
            this.Load += new System.EventHandler(this.F_protocolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CH_io)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_flujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_buscar;
        private System.Windows.Forms.Button B_captar;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_io;
        private System.Windows.Forms.TextBox TB_datos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_flujo;
        private System.Windows.Forms.ComboBox CB_Interfaz;
    }
}

