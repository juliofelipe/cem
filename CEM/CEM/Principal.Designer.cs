namespace CEM
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Chart3DLib.LineStyle lineStyle1 = new Chart3DLib.LineStyle();
            Chart3DLib.DataSeries dataSeries1 = new Chart3DLib.DataSeries();
            Chart3DLib.BarStyle barStyle1 = new Chart3DLib.BarStyle();
            Chart3DLib.LineStyle lineStyle2 = new Chart3DLib.LineStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            Chart3DLib.LineStyle lineStyle3 = new Chart3DLib.LineStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campoMagnéticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campoElétricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eixosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOCEMCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.propertyGridEntrada = new System.Windows.Forms.PropertyGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAzimuth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trkAzimuth = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbElevation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trkElevation = new System.Windows.Forms.TrackBar();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart3D1 = new Chart3DLib.Chart3D();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAzimuth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campoMagnéticoToolStripMenuItem,
            this.campoElétricoToolStripMenuItem});
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.calcularToolStripMenuItem.Text = "Calcular";
            // 
            // campoMagnéticoToolStripMenuItem
            // 
            this.campoMagnéticoToolStripMenuItem.Name = "campoMagnéticoToolStripMenuItem";
            this.campoMagnéticoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.campoMagnéticoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.campoMagnéticoToolStripMenuItem.Text = "Campo Magnético";
            this.campoMagnéticoToolStripMenuItem.Click += new System.EventHandler(this.campoMagnéticoToolStripMenuItem_Click);
            // 
            // campoElétricoToolStripMenuItem
            // 
            this.campoElétricoToolStripMenuItem.Name = "campoElétricoToolStripMenuItem";
            this.campoElétricoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.campoElétricoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.campoElétricoToolStripMenuItem.Text = "Campo Elétrico";
            this.campoElétricoToolStripMenuItem.Click += new System.EventHandler(this.campoElétricoToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoToolStripMenuItem,
            this.toolStripSeparator1,
            this.eixosToolStripMenuItem,
            this.gradeToolStripMenuItem,
            this.gradeToolStripMenuItem1});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.formatarToolStripMenuItem.Text = "Propriedades";
            // 
            // gráficoToolStripMenuItem
            // 
            this.gráficoToolStripMenuItem.Name = "gráficoToolStripMenuItem";
            this.gráficoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gráficoToolStripMenuItem.Text = "Dados do Campo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // eixosToolStripMenuItem
            // 
            this.eixosToolStripMenuItem.Name = "eixosToolStripMenuItem";
            this.eixosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.eixosToolStripMenuItem.Text = "Estilo";
            // 
            // gradeToolStripMenuItem
            // 
            this.gradeToolStripMenuItem.Name = "gradeToolStripMenuItem";
            this.gradeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gradeToolStripMenuItem.Text = "Eixos";
            // 
            // gradeToolStripMenuItem1
            // 
            this.gradeToolStripMenuItem1.Name = "gradeToolStripMenuItem1";
            this.gradeToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.gradeToolStripMenuItem1.Text = "Grade";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.suporteTécnicoToolStripMenuItem,
            this.sobreOCEMCalcToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ajudaToolStripMenuItem.Text = "Referências";
            // 
            // suporteTécnicoToolStripMenuItem
            // 
            this.suporteTécnicoToolStripMenuItem.Name = "suporteTécnicoToolStripMenuItem";
            this.suporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.suporteTécnicoToolStripMenuItem.Text = "Suporte Técnico";
            // 
            // sobreOCEMCalcToolStripMenuItem
            // 
            this.sobreOCEMCalcToolStripMenuItem.Name = "sobreOCEMCalcToolStripMenuItem";
            this.sobreOCEMCalcToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sobreOCEMCalcToolStripMenuItem.Text = "Sobre o CEMCalc";
            this.sobreOCEMCalcToolStripMenuItem.Click += new System.EventHandler(this.sobreOCEMCalcToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1176, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(350, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1176, 670);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.propertyGridEntrada);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(350, 670);
            this.splitContainer4.SplitterDistance = 338;
            this.splitContainer4.TabIndex = 0;
            // 
            // propertyGridEntrada
            // 
            this.propertyGridEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridEntrada.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGridEntrada.Location = new System.Drawing.Point(0, 0);
            this.propertyGridEntrada.Name = "propertyGridEntrada";
            this.propertyGridEntrada.Size = new System.Drawing.Size(350, 338);
            this.propertyGridEntrada.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.txtMax);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(350, 328);
            this.splitContainer3.SplitterDistance = 70;
            this.splitContainer3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ponto de Máximo";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(11, 29);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(330, 20);
            this.txtMax.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer5.Size = new System.Drawing.Size(350, 254);
            this.splitContainer5.SplitterDistance = 59;
            this.splitContainer5.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAzimuth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trkAzimuth);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Azimuth (degree)";
            // 
            // tbAzimuth
            // 
            this.tbAzimuth.Location = new System.Drawing.Point(293, 21);
            this.tbAzimuth.Name = "tbAzimuth";
            this.tbAzimuth.Size = new System.Drawing.Size(48, 20);
            this.tbAzimuth.TabIndex = 6;
            this.tbAzimuth.Text = "-37";
            this.tbAzimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAzimuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAzimuth_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "180";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "-180";
            // 
            // trkAzimuth
            // 
            this.trkAzimuth.Location = new System.Drawing.Point(32, 16);
            this.trkAzimuth.Maximum = 180;
            this.trkAzimuth.Minimum = -180;
            this.trkAzimuth.Name = "trkAzimuth";
            this.trkAzimuth.Size = new System.Drawing.Size(233, 45);
            this.trkAzimuth.TabIndex = 2;
            this.trkAzimuth.TickFrequency = 10;
            this.trkAzimuth.Value = -37;
            this.trkAzimuth.Scroll += new System.EventHandler(this.trkAzimuth_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.tbElevation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trkElevation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevation (degree)";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(112, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Visualização Padrão";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbElevation
            // 
            this.tbElevation.Location = new System.Drawing.Point(293, 24);
            this.tbElevation.Name = "tbElevation";
            this.tbElevation.Size = new System.Drawing.Size(48, 20);
            this.tbElevation.TabIndex = 5;
            this.tbElevation.Text = "30";
            this.tbElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbElevation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbElevation_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "-90";
            // 
            // trkElevation
            // 
            this.trkElevation.Location = new System.Drawing.Point(32, 16);
            this.trkElevation.Maximum = 90;
            this.trkElevation.Minimum = -90;
            this.trkElevation.Name = "trkElevation";
            this.trkElevation.Size = new System.Drawing.Size(233, 45);
            this.trkElevation.TabIndex = 2;
            this.trkElevation.TickFrequency = 5;
            this.trkElevation.Value = 30;
            this.trkElevation.Scroll += new System.EventHandler(this.trkElevation_Scroll);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart3D1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(822, 670);
            this.splitContainer2.SplitterDistance = 567;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart3D1
            // 
            this.chart3D1.BackColor = System.Drawing.Color.White;
            lineStyle1.IsVisible = true;
            lineStyle1.LineColor = System.Drawing.Color.Black;
            lineStyle1.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle1.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle1.Thickness = 1F;
            this.chart3D1.C3Axes.AxisStyle = lineStyle1;
            this.chart3D1.C3Axes.XMax = 5F;
            this.chart3D1.C3Axes.XMin = -5F;
            this.chart3D1.C3Axes.XTick = 1F;
            this.chart3D1.C3Axes.YMax = 3F;
            this.chart3D1.C3Axes.YMin = -3F;
            this.chart3D1.C3Axes.YTick = 1F;
            this.chart3D1.C3Axes.ZMax = 6F;
            this.chart3D1.C3Axes.ZMin = -6F;
            this.chart3D1.C3Axes.ZTick = 3F;
            barStyle1.IsBarSingleColor = false;
            barStyle1.XLength = 0.5F;
            barStyle1.YLength = 0.5F;
            barStyle1.ZOrigin = 0F;
            dataSeries1.BarStyle = barStyle1;
            lineStyle2.IsVisible = true;
            lineStyle2.LineColor = System.Drawing.Color.Black;
            lineStyle2.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle2.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle2.Thickness = 1F;
            dataSeries1.LineStyle = lineStyle2;
            dataSeries1.Point4Array = null;
            dataSeries1.PointArray = null;
            dataSeries1.PointList = ((System.Collections.ArrayList)(resources.GetObject("dataSeries1.PointList")));
            dataSeries1.XDataMin = -5F;
            dataSeries1.XNumber = 10;
            dataSeries1.XSpacing = 1F;
            dataSeries1.YDataMin = -5F;
            dataSeries1.YNumber = 10;
            dataSeries1.YSpacing = 1F;
            dataSeries1.ZNumber = 10;
            dataSeries1.ZSpacing = 1F;
            dataSeries1.ZZDataMin = -5F;
            this.chart3D1.C3DataSeries = dataSeries1;
            lineStyle3.IsVisible = true;
            lineStyle3.LineColor = System.Drawing.Color.LightGray;
            lineStyle3.Pattern = System.Drawing.Drawing2D.DashStyle.Solid;
            lineStyle3.PlotMethod = Chart3DLib.LineStyle.PlotLinesMethodEnum.Lines;
            lineStyle3.Thickness = 1F;
            this.chart3D1.C3Grid.GridStyle = lineStyle3;
            this.chart3D1.C3Grid.IsXGrid = true;
            this.chart3D1.C3Grid.IsYGrid = true;
            this.chart3D1.C3Grid.IsZGrid = true;
            this.chart3D1.C3Labels.LabelFont = new System.Drawing.Font("Arial", 10F);
            this.chart3D1.C3Labels.LabelFontColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.TickFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart3D1.C3Labels.TickFontColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.Title = "Campos Elétricos e Magnéticos";
            this.chart3D1.C3Labels.TitleColor = System.Drawing.Color.Black;
            this.chart3D1.C3Labels.TitleFont = new System.Drawing.Font("Arial Narrow", 14F);
            this.chart3D1.C3Labels.XLabel = "Eixo X";
            this.chart3D1.C3Labels.YLabel = "Eixo Y";
            this.chart3D1.C3Labels.ZLabel = "Eixo Z";
            this.chart3D1.C3ViewAngle.Azimuth = -37.5F;
            this.chart3D1.C3ViewAngle.Elevation = 30F;
            this.chart3D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart3D1.Location = new System.Drawing.Point(0, 0);
            this.chart3D1.Name = "chart3D1";
            this.chart3D1.Size = new System.Drawing.Size(822, 567);
            this.chart3D1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 99);
            this.dataGridView1.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 741);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "CEMCalc - Cálculo de Campos Elétricos e Magnéticos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAzimuth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevation)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campoMagnéticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campoElétricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOCEMCalcToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eixosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.PropertyGrid propertyGridEntrada;
        public Chart3DLib.Chart3D chart3D1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAzimuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkAzimuth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbElevation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trkElevation;
        private System.Windows.Forms.Button btnReset;
    }
}

