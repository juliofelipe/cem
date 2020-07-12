using Chart3DLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEM
{
    class Campo
    {
        protected double u0;
        protected double e0;
        protected double[] xi;
        protected double[] xf;
        protected double[] yi;
        protected double[] yf;
        protected double[] zi;
        protected double[] zf;
        protected double n;
        protected double[] xn;
        protected double[] yn;
        protected double zn;
        protected Point3[,] pts;
        protected int[] ang;
        private double hGrafico;
        private double max;
        private static double intervalo;

        public double U0 { get => u0; set => u0 = value; }
        public double E0 { get => e0; set => e0 = value; }
        public double[] Xi { get => xi; set => xi = value; }
        public double[] Xf { get => xf; set => xf = value; }
        public double[] Yi { get => yi; set => yi = value; }
        public double[] Yf { get => yf; set => yf = value; }
        public double[] Zi { get => zi; set => zi = value; }
        public double[] Zf { get => zf; set => zf = value; }
        public double N { get => n; set => n = value; }
        public double[] Xn { get => xn; set => xn = value; }
        public double[] Yn { get => yn; set => yn = value; }
        public double Zn { get => zn; set => zn = value; }
        public Point3[,] Pts { get => pts; set => pts = value; }
        public int[] Ang { get => ang; set => ang = value; }
        public double HGrafico { get => hGrafico; set => hGrafico = value; }
        public double Max { get => max; set => max = value; }
        public static double Intervalo { get => intervalo; set => intervalo = value; }

        public virtual void plotarGrafico()
        {

        }

        public Campo()
        {
            u0 = 4 * Math.PI * Math.Pow(10, -7);
            e0 = 1 / (Math.Pow(299792458, 2) * u0);
        }

        public static double[][] zeros(int x, int y)
        {
            double[][] matrizZeros = Matriz.MatrixCreate(x, y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrizZeros[i][j] = 0;

                }
            }
            return matrizZeros;
        }

        

        public static double[] linspace(int i, int f, int n)
        {
           intervalo = (double) (f - i) / (n - 1);

            double[] matrizLinspace = new double[n];
            for (int y = 0; y < n; y++)
            {
                if (y == 0)
                {
                    matrizLinspace[y] = i;
                }

                else if (y == n)
                {
                    matrizLinspace[y] = f;
                }

                else
                {
                    matrizLinspace[y] = matrizLinspace[y - 1]  + intervalo;
                }
            }
        
            return matrizLinspace;
        }


    }
}
