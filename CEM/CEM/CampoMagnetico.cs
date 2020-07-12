using Chart3DLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEM
{
    class CampoMagnetico : Campo
    {
        public CampoMagnetico() : base() {
        }

        private double [] ir;
        private double [] ii;
        private double []i;
        private float z;

        public double[] Ir { set => ir = value; }
        public double[] Ii { set => ii = value; }
        public double[] I { get => i; set => i = value; }
        public float Z { get => z; set => z = value; }

        public override void plotarGrafico()
        {


            //Calcula Ir E Ii
            ii = this.getIi();
            ir = this.getIr();

            double[][] Bxr = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Byr = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Bzr = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Bxi = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Byi = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Bzi = Campo.zeros(Xn.Length, Yn.Length);

            

            for (int a = 0; a < n; a++)
            {
                for (int i = 0; i < Xn.Length; i++)
                {
                    for (int m = 0; m < Yn.Length; m++)
                    {

                        double L = Math.Sqrt(Math.Pow((Xf[a] - Xi[a]), 2) + Math.Pow((Yf[a] - Yi[a]), 2) + Math.Pow((Zf[a] - Zi[a]), 2));
                        double D = Math.Sqrt(Math.Pow((Xi[a] - Xn[i]), 2) + Math.Pow((Yi[a] - Yn[m]), 2) + Math.Pow((Zi[a] - Zn), 2));
                        double D0 = ((Xi[a] - Xn[i]) * (Xf[a] - Xi[a]) + (Yi[a] - Yn[m]) * (Yf[a] - Yi[a]) + (Zi[a] - Zn) * (Zf[a] - Zi[a])) / L;
                        double K = (1 / (Math.Pow(D, 2) - Math.Pow(D0, 2))) * ((L + D0) / (Math.Sqrt(Math.Pow(L, 2) + 2 * L * D0 + Math.Pow(D, 2))) - D0 / D);

                        double AUXXR = 0.1 * (ir[a] * K / L) * ((Zn - Zi[a]) * (Yf[a] - Yi[a]) - (Yn[m] - Yi[a]) * (Zf[a] - Zi[a]));
                        double AUXYR = 0.1 * (ir[a] * K / L) * ((Xn[i] - Xi[a]) * (Zf[a] - Zi[a]) - (Zn - Zi[a]) * (Xf[a] - Xi[a]));
                        double AUXZR = 0.1 * (ir[a] * K / L) * ((Yn[m] - Yi[a]) * (Xf[a] - Xi[a]) - (Xn[i] - Xi[a]) * (Yf[a] - Yi[a]));

                        double AUXXI = 0.1 * (ii[a] * K / L) * ((Zn - Zi[a]) * (Yf[a] - Yi[a]) - (Yn[m] - Yi[a]) * (Zf[a] - Zi[a]));
                        double AUXYI = 0.1 * (ii[a] * K / L) * ((Xn[i] - Xi[a]) * (Zf[a] - Zi[a]) - (Zn - Zi[a]) * (Xf[a] - Xi[a]));
                        double AUXZI = 0.1 * (ii[a] * K / L) * ((Yn[m] - Yi[a]) * (Xf[a] - Xi[a]) - (Xn[i] - Xi[a]) * (Yf[a] - Yi[a]));

                        Bxr[m][i] = Bxr[m][i] + AUXXR;
                        Byr[m][i] = Byr[m][i] + AUXYR;
                        Bzr[m][i] = Bzr[m][i] + AUXZR;

                        Bxi[m][i] = Bxi[m][i] + AUXXI;
                        Byi[m][i] = Byi[m][i] + AUXYI;
                        Bzi[m][i] = Bzi[m][i] + AUXZI;

                    }
                }
            }


            
            double[,] B = new double[xn.Length, yn.Length];
            pts = new Point3[xn.Length, yn.Length];

            double x = 0.0, y = 0.0;

            for (int i = 0; i < xn.Length; i++)
            {
                if (i == 0)
                {
                    x = Xn[0];
                }
                else
                {
                    x = x + Intervalo;

                }
                for (int m = 0; m < yn.Length; m++)
                {
                    if (m  == 0)
                    {
                        y = Yn[0];
                    }
                    else
                    {
                        y = y + Intervalo;

                    }
                    double zz = B[m, i] = Math.Sqrt((Math.Pow(Bxr[m][i], 2) + Math.Pow(Bxi[m][i], 2) + Math.Pow(Byr[m][i], 2) + Math.Pow(Byi[m][i], 2)) + Math.Pow(Bzr[m][i], 2) + Math.Pow(Bzi[m][i], 2));
                    Z = (float)zz;
                    pts[i, m] = new Point3((float)x, (float)y, Z, 1);

                }                
            }

            Max = B.Cast<double>().Max();
            HGrafico = Math.Round(Max);
        }


        public double[] getIr()
        {
            ir = new double[Xi.Length];
            int cont = 0;
            for (int i = 0; i < Xi.Length; i++)
            {
                if (cont == 0)
                {
                    ir[i] = Math.Cos(Ang[i] * Math.PI / 180) * this.i[i];
                }
                else if (cont == 1)
                {
                    ir[i] = Math.Cos(Ang[i] * Math.PI / 180) * this.i[i];
                }
                else if (cont == 2)
                {
                    ir[i] = Math.Cos(Ang[i] * Math.PI / 180) * this.i[i];
                    cont = -1;
                }
                cont++;
            }
            n = ir.Length;
            return ir;
        }

        public double[] getIi()
        {
            ii = new double[Xi.Length];
            int cont = 0;
            for (int i = 0; i < Xi.Length; i++)
            {
                if (cont == 0)
                {
                    ii[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.i[1];
                }
                else if (cont == 1)
                {
                    ii[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.i[i];
                }
                else if (cont == 2)
                {
                    ii[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.i[i];
                    cont = -1;
                }
                cont++;
            }

            return ii;
        }

    }
}
