using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Chart3DLib;


namespace CEM
{
    public partial class Principal : Form
    {
        private DadosEntrada limEixos;
        private CampoMagnetico cm;
        private CampoEletrico ce;
        private string tipo;

        public Principal()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            ComboboxSetup();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dataGridView1.RowHeadersWidth = 70;
            limEixos = new DadosEntrada();
            propertyGridEntrada.SelectedObject = limEixos;
            cm = new CampoMagnetico();
            ce = new CampoEletrico();
            tipo = "";

       

        }


        //Preenche o combobox de Estilos de Gráfico - é chamada no construtor
        private void ComboboxSetup()
        {
            toolStripComboBox1.Items.Add("Mesh");
            toolStripComboBox1.Items.Add("MeshZ");
            toolStripComboBox1.Items.Add("Waterfall");
            toolStripComboBox1.Items.Add("Surface");
            toolStripComboBox1.Items.Add("XYColor");
            toolStripComboBox1.Items.Add("Contour");
            toolStripComboBox1.Items.Add("Filled Contour");
            toolStripComboBox1.Items.Add("Mesh + Contour");
            toolStripComboBox1.Items.Add("Surface + Contour");
            toolStripComboBox1.Items.Add("Surface + Contour");
            toolStripComboBox1.Items.Add("Surface + Filled Contour");
            toolStripComboBox1.Items.Add("Bar3D");
            toolStripComboBox1.SelectedItem = "Surface";
        }

        //É chamada ao selecionar um estilo de gráfico
        private void ChartTypeSetup()
        {
            string chartType = toolStripComboBox1.SelectedItem.ToString();
            switch (chartType)
            {
                case "Mesh":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.Mesh;
                    break;
                case "MeshZ":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.MeshZ;
                    break;
                case "Waterfall":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.Waterfall;
                    break;
                case "Surface":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.Surface;
                    break;
                case "XYColor":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.XYColor;
                    break;
                case "Contour":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.Contour;
                    break;
                case "Filled Contour":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.FillContour;
                    break;
                case "Mesh + Contour":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.MeshContour;
                    break;
                case "Surface + Contour":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.SurfaceContour;
                    break;
                case "Surface + Filled Contour":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.SurfaceFillContour;
                    break;
                case "Bar3D":
                    chart3D1.C3DrawChart.ChartType = DrawChart.ChartTypeEnum.Bar3D;

                    break;
            }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            
        }


        private void PopulateDadaGridView()
        {
            Point3[,] zdata = chart3D1.C3DataSeries.PointArray;
            int nx = zdata.GetLength(0);
            int ny = zdata.GetLength(1);
            float[] xdata = new float[nx];
            float[] ydata = new float[ny];
            for (int i = 0; i < nx; i++)
            {
                xdata[i] = chart3D1.C3DataSeries.XDataMin +
                    i * (float)(Campo.Intervalo);
            }
            for (int j = 0; j < ny; j++)
            {
                ydata[j] = chart3D1.C3DataSeries.YDataMin +
                    j * (float)(Campo.Intervalo);
            }

            
            dataGridView1.ColumnCount = nx + 1;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.RowHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[i].Width = 80;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;

                for (int j = 0; j < ny + 1; j++)
                {
                    if (i == 0)
                    {
                        dataGridView1.Rows.Add();

                        if (j > 0)
                        {
                            dataGridView1.Rows[j - 1].HeaderCell.Value = ydata[j - 1].ToString();
                        }
                    }
                    if (i > 0)
                    {
                        dataGridView1.Columns[i - 1].Name = xdata[i - 1].ToString();
                    }

                    if (i > 0 && j > 0)
                    {
                        dataGridView1[i - 1, j - 1].Value = zdata[i - 1, j - 1].Z.ToString();

                    }
                }
            }
        }

 

        //Varre o PropertyGrid e atribui os valores de cada propriedade 
        private void ParseGridItems(GridItem gi)
        {
            if (gi.GridItemType == GridItemType.Category)
            {
                foreach (GridItem item in gi.GridItems)
                {
                    ParseGridItems(item);
                }
            }
            if (gi.Label == "Tensao")
            {
                string VString = (string)gi.Value;
                double[] parts = Array.ConvertAll(VString.Split(';'), Double.Parse);
                ce.V = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.V[i] = parts[i] * 1000;
                }
            }
            else if (gi.Label == "Corrente")
            {
                string IString = (string)gi.Value;
                double[] parts = Array.ConvertAll(IString.Split(';'), Double.Parse);
                cm.I = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.I[i] = parts[i];
                }                              
            }
            else if (gi.Label == "Angulo")
            {
                string AngString = (string)gi.Value;
                int[] parts = Array.ConvertAll(AngString.Split(';'), Int32.Parse);
                cm.Ang = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                  cm.Ang[i] = parts[i];
                }
                ce.Ang = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Ang[i] = parts[i];
                }
            }
            else if (gi.Label == "XInicial")
            {
                string XiString = (string)gi.Value;
                double[] parts = Array.ConvertAll(XiString.Split(';'), Double.Parse);
                cm.Xi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Xi[i] = parts[i];
                }
                ce.Xi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Xi[i] = parts[i];
                }
            }
            else if (gi.Label == "XFinal")
            {
                string XfString = (string)gi.Value;
                double[] parts = Array.ConvertAll(XfString.Split(';'), Double.Parse);
                cm.Xf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Xf[i] = parts[i];
                }
                ce.Xf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Xf[i] = parts[i];
                }
            }
            else if (gi.Label == "YInicial")
            {
                string YiString = (string)gi.Value;
                double[] parts = Array.ConvertAll(YiString.Split(';'), Double.Parse);
                cm.Yi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Yi[i] = parts[i];
                }
                ce.Yi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Yi[i] = parts[i];
                }
            }
            else if (gi.Label == "YFinal")
            {
                string YfString = (string)gi.Value;
                double[] parts = Array.ConvertAll(YfString.Split(';'), Double.Parse);
                cm.Yf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Yf[i] = parts[i];
                }
                ce.Yf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Yf[i] = parts[i];
                }
            }
            else if (gi.Label == "ZInicial")
            {
                string ZiString = (string)gi.Value;
                double[] parts = Array.ConvertAll(ZiString.Split(';'), Double.Parse);
                cm.Zi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Zi[i] = parts[i];
                }
                ce.Zi = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Zi[i] = parts[i];
                }
            }
            else if (gi.Label == "ZFinal")
            {
                string ZfString = (string)gi.Value;
                double[] parts = Array.ConvertAll(ZfString.Split(';'), Double.Parse);
                cm.Zf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Zf[i] = parts[i];
                }
                ce.Zf = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Zf[i] = parts[i];
                }
            }
            else if (gi.Label == "Diâmetro")
            {
                string DiametroString = (string)gi.Value;
                double[] parts = Array.ConvertAll(DiametroString.Split(';'), Double.Parse);
                ce.Deq = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Deq[i] = parts[i];
                }

            }
            else if (gi.Label == "Xn")
            {
                string XnString = (string)gi.Value;
                double[] parts = Array.ConvertAll(XnString.Split(';'), Double.Parse);
                cm.Xn = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Xn[i] = parts[i];
                }
                ce.Xn = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Xn[i] = parts[i];
                }
            }
            else if (gi.Label == "Yn")
            {
                string YnString = (string)gi.Value;
                double[] parts = Array.ConvertAll(YnString.Split(';'), Double.Parse);
                cm.Yn = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cm.Yn[i] = parts[i];
                }
                ce.Yn = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ce.Yn[i] = parts[i];
                }
            }
            else if (gi.Label == "Zn")
            {
                cm.Zn = (double)gi.Value;
                ce.Zn = (double)gi.Value;
            }
 
        }

        private void AtribuicaoDados()
        {
            GridItem gi = propertyGridEntrada.SelectedGridItem;
            while (gi.Parent != null)
            {
                gi = gi.Parent;
            }
            foreach (GridItem item in gi.GridItems)
            {
                ParseGridItems(item); //recursive
            }

        }

        private void  AddDataMagnético()
        {

            AtribuicaoDados();

            int XnInicial = (int)(cm.Xn[0]);
            int XnFinal = (int)(cm.Xn[1]);
            int XEspacos = (int)(cm.Xn[2]);
            int YnInicial = (int)(cm.Yn[0]);
            int YnFinal = (int)(cm.Yn[1]);
            int YEspacos = (int)(cm.Yn[2]);
            cm.Xn = Campo.linspace(XnInicial, XnFinal, XEspacos);
            cm.Yn = Campo.linspace(YnInicial, YnFinal, YEspacos);
            chart3D1.C3Axes.XMin = XnInicial;
            chart3D1.C3Axes.XMax = XnFinal;
            chart3D1.C3Axes.YMin = YnInicial;
            chart3D1.C3Axes.YMax = YnFinal;
            cm.plotarGrafico();
            chart3D1.C3Axes.ZMin = 0;
            chart3D1.C3Axes.ZMax = (int)cm.HGrafico;
            chart3D1.C3Axes.XTick = 10;
            chart3D1.C3Axes.YTick = 10;
            chart3D1.C3Axes.ZTick = 1;
            chart3D1.C3DataSeries.XDataMin = chart3D1.C3Axes.XMin;
            chart3D1.C3DataSeries.YDataMin = chart3D1.C3Axes.YMin;
            chart3D1.C3DataSeries.XSpacing = (XnFinal - XnInicial) / (XEspacos - 1);
            chart3D1.C3DataSeries.YSpacing = (XnFinal - XnInicial) / (XEspacos - 1);
            chart3D1.C3DataSeries.XNumber = (int)(
              (chart3D1.C3Axes.XMax - chart3D1.C3Axes.XMin) /
               chart3D1.C3DataSeries.XSpacing) + 1;
            chart3D1.C3ChartStyle.IsColorBar = true;
            chart3D1.C3DataSeries.YNumber = (int)(
              (chart3D1.C3Axes.YMax - chart3D1.C3Axes.YMin) /
              chart3D1.C3DataSeries.YSpacing) + 1;
            chart3D1.C3Labels.XLabel = "X (m)";
            chart3D1.C3Labels.YLabel = "Y (m)";
            chart3D1.C3Labels.ZLabel = "Densidade de Campo Magnético (µT)";
            chart3D1.C3Labels.Title = "Campo Magnético";

            chart3D1.C3DataSeries.PointArray = cm.Pts;
            txtMax.Text = cm.Max.ToString();
        }




        private void AddDataEletrico()
        {
            AtribuicaoDados();
            int XnInicial = (int)(ce.Xn[0]);
            int XnFinal = (int)(ce.Xn[1]);
            int XEspacos = (int)(ce.Xn[2]);
            int YnInicial = (int)(ce.Yn[0]);
            int YnFinal = (int)(ce.Yn[1]);
            int YEspacos = (int)(ce.Yn[2]);
            ce.Xn = Campo.linspace(XnInicial, XnFinal, XEspacos);
            ce.Yn = Campo.linspace(XnInicial, XnFinal, XEspacos);
            ce.plotarGrafico();
            chart3D1.C3Axes.XMin = XnInicial;
            chart3D1.C3Axes.XMax = XnFinal;
            chart3D1.C3Axes.YMin = YnInicial;
            chart3D1.C3Axes.YMax = YnFinal;
            chart3D1.C3Axes.ZMin = 0;
            chart3D1.C3Axes.ZMax = (int)ce.HGrafico;
            chart3D1.C3Axes.XTick = 10;
            chart3D1.C3Axes.YTick = 10;
            chart3D1.C3Axes.ZTick = 1;
            chart3D1.C3ChartStyle.IsColorBar = true;
            chart3D1.C3DataSeries.XDataMin = chart3D1.C3Axes.XMin;
            chart3D1.C3DataSeries.YDataMin = chart3D1.C3Axes.YMin;
            chart3D1.C3DataSeries.XSpacing = (XnFinal - XnInicial) / (XEspacos - 1);
            chart3D1.C3DataSeries.YSpacing = (YnFinal - YnFinal) / (YEspacos - 1);
            chart3D1.C3DataSeries.XNumber = (int)(
             (chart3D1.C3Axes.XMax - chart3D1.C3Axes.XMin) /
             chart3D1.C3DataSeries.XSpacing) + 1;
            chart3D1.C3DataSeries.YNumber = (int)((chart3D1.C3Axes.YMax - chart3D1.C3Axes.YMin) /chart3D1.C3DataSeries.YSpacing) + 1;
            chart3D1.C3Labels.XLabel = "X (m)";
            chart3D1.C3Labels.YLabel = "Y (m)";
            chart3D1.C3Labels.ZLabel = "Campo Elétrico (kV/m)";
            chart3D1.C3Labels.Title = "Campo Elétrico";
            chart3D1.C3DataSeries.PointArray = ce.Pts;
            txtMax.Text = ce.Max.ToString();
           
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

            private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
            {
                this.Invalidate();
            }

        private void campoMagnéticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "Eletrico";
            paintMagnetico();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            DadosEntrada limEixos = new DadosEntrada();
            propertyGridEntrada.SelectedObject = limEixos;
        }

        private void campoElétricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "Magnetico";
            paintEletrico();
        }

        public void paintMagnetico()
        {
            AddDataMagnético();
            PopulateDadaGridView();
            if (dataGridView1.RowCount > 0)
            {
                ChartTypeSetup();
            }
        }

        public void paintEletrico()
        {
            AddDataEletrico();
            PopulateDadaGridView();
       
            if (dataGridView1.RowCount > 0)
            {
                ChartTypeSetup();
            }
        }



        private void trkAzimuth_Scroll(object sender, EventArgs e)
        {
            tbAzimuth.Text = trkAzimuth.Value.ToString();
            chart3D1.C3ViewAngle.Azimuth = trkAzimuth.Value;           
           

            if (chart3D1.C3Labels.Title == "Campo Magnético"){
                AddDataMagnético();
            }
            else if (chart3D1.C3Labels.Title == "Campo Elétrico")
            {
                AddDataEletrico();
            }
             chart3D1.Invalidate();

        }


        private void trkElevation_Scroll(object sender, EventArgs e)
        {
            tbElevation.Text = trkElevation.Value.ToString();
            chart3D1.C3ViewAngle.Elevation = trkElevation.Value;
           

            if (chart3D1.C3Labels.Title == "Campo Magnético")
            {
                AddDataMagnético();
            }
            else if (chart3D1.C3Labels.Title == "Campo Elétrico")
            {
                AddDataEletrico();
            }
            chart3D1.Invalidate();
        }

        private void tbAzimuth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chart3D1.C3ViewAngle.Azimuth = float.Parse(tbAzimuth.Text);
                trkAzimuth.Value = int.Parse(tbAzimuth.Text);


                if (chart3D1.C3Labels.Title == "Campo Magnético")
                {
                    AddDataMagnético();
                }
                else if (chart3D1.C3Labels.Title == "Campo Elétrico")
                {
                    AddDataEletrico();
                }
                chart3D1.Invalidate();
            }

        }

        private void tbElevation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chart3D1.C3ViewAngle.Elevation = float.Parse(tbElevation.Text);
                trkElevation.Value = int.Parse(tbElevation.Text);
                if (chart3D1.C3Labels.Title == "Campo Magnético")
                {
                    AddDataMagnético();
                }
                else if (chart3D1.C3Labels.Title == "Campo Elétrico")
                {
                    AddDataEletrico();
                }
                chart3D1.Invalidate();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAzimuth.Text = "-37";
            tbElevation.Text = "30";
            chart3D1.C3ViewAngle.Elevation = float.Parse(tbElevation.Text);
            trkElevation.Value = int.Parse(tbElevation.Text);
            chart3D1.C3ViewAngle.Azimuth = float.Parse(tbAzimuth.Text);
            trkAzimuth.Value = int.Parse(tbAzimuth.Text);
            if (chart3D1.C3Labels.Title == "Campo Magnético")
            {
                AddDataMagnético();
            }
            else if (chart3D1.C3Labels.Title == "Campo Elétrico")
            {
                AddDataEletrico();
            }
            chart3D1.Invalidate();

        }

        private void sobreOCEMCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEMSobre sobre = new CEMSobre();
            sobre.Show();

        }



    }
    
}
