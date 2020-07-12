using Chart3DLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEM
{
    class CampoEletrico : Campo
    {
        public CampoEletrico() : base() {
        }

        private double[] vr;
        private double[] vi;
        private double[] v;
        private double[] deq;
        private float z;



        public double[] Vr { get => vr; set => vr = value; }
        public double[] Vi { get => vi; set => vi = value; }
        public double[] V { get => v; set => v = value; }
        public double[] Deq { get => deq; set => deq = value; }
        public float Z { get => z; set => z = value; }


        public override void plotarGrafico()
        {
        
            //Calcula Vr e Vi
            vr = this.getVr();
            vi = this.getVi();
            int n = Deq.Length;

            double[][] AF = Campo.zeros(n, n);
            double[][] BF = Campo.zeros(n, n);
            double[][] AS = Campo.zeros(n, n);
            double[][] BS = Campo.zeros(n, n);

            double[][] Exr = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Eyr = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Ezr = Campo.zeros(Xn.Length, Yn.Length);

            double[][] Exi = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Eyi = Campo.zeros(Xn.Length, Yn.Length);
            double[][] Ezi = Campo.zeros(Xn.Length, Yn.Length);

            double SIGMA2R;
            double SIGMA1R;
            double SIGMA2I;
            double SIGMA1I;
           

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    if (a == b)
                    {

                        double L = Math.Sqrt(Math.Pow((Xf[a] - Xi[a]), 2) + Math.Pow((Yf[a] - Yi[a]), 2) + Math.Pow((Zf[a] - Zi[a]), 2));
                        double R = Deq[a] / 2;
                        double AUX = Math.Sqrt(Math.Pow((Xf[a] - Xi[a]), 2) + Math.Pow((Yf[a] - Yi[a]), 2) + Math.Pow((Zf[a] + Zi[a]), 2));
                        double TETA1 = Math.Acos(-(Math.Pow(AUX, 2) - Math.Pow(L, 2) - 4 * Math.Pow(Zi[a], 2)) / (4 * Zi[a] * L));
                        double TETA2 = Math.Acos(-(Math.Pow(AUX, 2) - Math.Pow(L, 2) - 4 * Math.Pow(Zf[a], 2)) / (4 * Zf[a] * L));

                        SIGMA2R = Math.Sqrt(Math.Pow((L / 3), 2) + Math.Pow((Deq[a] / 2), 2));
                        SIGMA1R = Math.Sqrt(Math.Pow((2 * L / 3), 2) + Math.Pow((Deq[a] / 2), 2));
                        SIGMA2I = Math.Sqrt(Math.Pow((L / 3), 2) + 4 * Math.Pow(Zi[a], 2) - 4 * (L / 3) * Math.Cos(TETA1));
                        SIGMA1I = Math.Sqrt(Math.Pow((2 * L / 3), 2) + 4 * Math.Pow(Zf[a], 2) - 4 * (2 * L / 3) * Math.Cos(TETA2));

                        AF[a][a] = Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L)) + Math.Log((SIGMA1I + SIGMA2I - L) / (SIGMA1I + SIGMA2I + L));
                        BF[a][a] = (SIGMA1R - SIGMA2R) / L - (SIGMA1I - SIGMA2I) / L + ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2))) / (2 * Math.Pow(L, 2)) * Math.Log((SIGMA1I + SIGMA2I + L) / (SIGMA1I + SIGMA2I - L))
                        - ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2))) * Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L));

                        SIGMA2R = Math.Sqrt(Math.Pow((2 * L / 3), 2) + Math.Pow((Deq[a] / 2), 2));
                        SIGMA1R = Math.Sqrt(Math.Pow((L / 3), 2) + Math.Pow((Deq[a] / 2), 2));
                        SIGMA2I = Math.Sqrt(Math.Pow((2 * L / 3), 2) + 4 * Math.Pow(Zi[a], 2) - 4 * Zi[a] * (2 * L / 3) * Math.Cos(TETA1));
                        SIGMA1I = Math.Sqrt(Math.Pow((L / 3), 2) + 4 * Math.Pow(Zf[a], 2) - 4 * Zf[a] * (L / 3) * Math.Cos(TETA2));

                        AS[a][a] = Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L)) + Math.Log((SIGMA1I + SIGMA2I - L) / (SIGMA1I + SIGMA2I + L));
                        BS[a][a] = (SIGMA1R - SIGMA2R) / L - (SIGMA1I - SIGMA2I) / L + ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2))) / (2 * Math.Pow(L, 2)) * Math.Log((SIGMA1I + SIGMA2I + L) / (SIGMA1I + SIGMA2I - L))
                        - ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2))) * Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L));

                    }
                }
            }

            double[][] iAF = Matriz.MatrixInverse(AF);
            double[][] iBF = Matriz.MatrixInverse(BF);
            double[][] iAS = Matriz.MatrixInverse(AS);
            double[][] iBS = Matriz.MatrixInverse(BS);
            double[][] eye = Matriz.MatrixIdentity(n);
            double[][] DQ1a = Matriz.MatrixCreate(n, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ1a[i][j] = (BS[i][j] - (AS[i][j] * iAF[i][j]) * BF[i][j]);
                }
            }
            double[][] iDQ1a = Matriz.MatrixInverse(DQ1a);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    iDQ1a = Matriz.MatrixInverse(DQ1a);
                }
            }

            double[][] DQ1b = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ1b[i][j] = (eye[i][j] - (AS[i][j] * iAF[i][j]));
                }
            }
            double[][] DQ1 = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ1[i][j] = 4 * Math.PI * e0 * (iDQ1a[i][j] * DQ1b[i][j]) * vr[j];

                }
            }
            double[][] Q1 = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Q1[i][j] = 4 * Math.PI * e0 * (iAF[i][j] * vr[i] - iAF[i][j] * BF[i][j] * DQ1[i][j] * (1 / (4 * Math.PI * e0)));

                }
            }
            double[][] DQ2a = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ2a[i][j] = (BS[i][j] - (AS[i][j] * iAF[i][j]) * BF[i][j]);


                }
            }
            double[][] iDQ2a = Matriz.MatrixInverse(DQ1a);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    iDQ2a = Matriz.MatrixInverse(DQ1a);
                }
            }
            double[][] DQ2b = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ2b[i][j] = (eye[i][j] - (AS[i][j] * iAF[i][j]));
                }
            }
            double[][] DQ2 = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DQ2[i][j] = 4 * Math.PI * e0 * (iDQ2a[i][j] * DQ2b[i][j]) * vi[j];

                }
            }
            double[][] Q2 = Matriz.MatrixCreate(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Q2[i][j] = 4 * Math.PI * e0 * (iAF[i][j] * vi[i] - iAF[i][j] * BF[i][j] * DQ1[i][j] * (1 / (4 * Math.PI * e0)));

                }
            }
        

            for (int a = 0; a<n; a++)
            {
                for (int i = 0; i<Xn.Length; i++)
                {
                    for (int m = 0; m<Yn.Length; m++)
                    {

                        double L = Math.Sqrt(Math.Pow((Xf[a] - Xi[a]), 2) + Math.Pow((Yf[a] - Yi[a]), 2) + Math.Pow((Zf[a] - Zi[a]), 2));


                        SIGMA1R = Math.Sqrt(Math.Pow((Xn[i] - Xf[a]), 2) + Math.Pow((Yn[m] - Yf[a]), 2) + Math.Pow((Zn - Zf[a]), 2));
                        SIGMA2R = Math.Sqrt(Math.Pow((Xn[i] - Xi[a]), 2) + Math.Pow((Yn[m] - Yi[a]), 2) + Math.Pow((Zn - Zi[a]), 2));
                        SIGMA1I = Math.Sqrt(Math.Pow((Xn[i] - Xf[a]), 2) + Math.Pow((Yn[m] - Yf[a]), 2) + Math.Pow((Zn + Zf[a]), 2));
                        SIGMA2I = Math.Sqrt(Math.Pow((Xn[i] - Xi[a]), 2) + Math.Pow((Yn[m] - Yi[a]), 2) + Math.Pow((Zn + Zi[a]), 2));

                        double A1 = -((Xi[a] - Xn[i]) * (Xf[a] - Xi[a]) + (Yi[a] - Yn[m]) * (Yf[a] - Yi[a]) + (Zi[a] - Zn) * (Zf[a] - Zi[a])) / L;
                        double B1 = Math.Sqrt(Math.Pow(SIGMA2R, 2) - Math.Pow(A1, 2));
                        double A2 = -((Xi[a] - Xn[i]) * (Xf[a] - Xi[a]) + (Yi[a] - Yn[m]) * (Yf[a] - Yi[a]) + (-Zi[a] - Zn) * (-Zf[a] + Zi[a])) / L;
                        double B2 = Math.Sqrt(Math.Pow(SIGMA2I, 2) - Math.Pow(A1, 2));

                        double E1R = (1 / (4 * Math.PI * e0)) * ((Q1[a][a] - DQ1[a][a] * ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2)))) * 2 * L * B1 * ((SIGMA1R + SIGMA2R) / (SIGMA1R * SIGMA2R * (SIGMA1R + SIGMA2R - L) * (SIGMA1R + SIGMA2R + L)))
                                - (DQ1[a][a] / L) * (B1 / SIGMA1R - B1 / SIGMA2R));
                        double E2R = (1 / (4 * Math.PI * e0)) * ((Q1[a][a] - DQ1[a][a] * ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2)))) * (1 / SIGMA1R - 1 / SIGMA2R)
                                - (DQ1[a][a] / L) * Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L))
                                - (DQ1[a][a]) * ((SIGMA1R + SIGMA2R) * (Math.Pow((SIGMA1R - SIGMA2R), 2) - Math.Pow(L, 2))) / (2 * SIGMA1R * SIGMA2R * Math.Pow(L, 2)));

                        double E3R = (1 / (4 * Math.PI * e0)) * ((-Q1[a][a] + DQ1[a][a] * ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2)) / (2 * Math.Pow(L, 2)))) * 2 * L * B2 * ((SIGMA1I + SIGMA2I) / (SIGMA1I * SIGMA2I * (SIGMA1I + SIGMA2I - L) * (SIGMA1I + SIGMA2I + L)))
                                - (-DQ1[a][a] / L) * (B2 / SIGMA1I - B2 / SIGMA2I));
                        double E4R = (1 / (4 * Math.PI * e0)) * ((-Q1[a][a] + DQ1[a][a] * ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2)) / (2 * Math.Pow(L, 2)))) * (1 / SIGMA1I - 1 / SIGMA2I)
                                - (-DQ1[a][a] / L) * Math.Log((SIGMA1I + SIGMA2I + L) / (SIGMA1I + SIGMA2I - L))
                                - (-DQ1[a][a]) * ((SIGMA1I + SIGMA2I) * (Math.Pow((SIGMA1I - SIGMA2I), 2) - Math.Pow(L, 2))) / (2 * SIGMA1I * SIGMA2I * Math.Pow(L, 2)));
                        double E1X;

                        if (Xn[i] < Xi[a])
                        {
                            E1X = E1R* (Xi[a] - (A1 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B1 + E3R* (Xi[a] - (A2 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B2;
                        }
                        else
                        {
                            E1X = E1R* (Xi[a] + (A1 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B1 + E3R* (Xi[a] + (A2 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B2;
                        }

                        double E2X = (E2R + E4R) * (Xf[a] - Xi[a]) / L;
                        Exr[m][i] = Exr[m][i] + E1X + E2X;

                        double E1Y;
                        if (Yn[m] < Yi[a])
                        {
                            E1Y = E1R* (Yi[a] - (A1 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B1 + E3R* (Yi[a] - (A2 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B2;
                        }
                        else
                        {
                            E1Y = E1R* (Yi[a] + (A1 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B1 + E3R* (Yi[a] + (A2 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B2;
                        }

                        double E2Y = (E2R + E4R) * (Yf[a] - Yi[a]) / L;
                        Eyr[m][i] = Eyr[m][i] + E1Y + E2Y;

                        double E1Z;
                        if (Zn<Zi[a])
                        {
                            E1Z = E1R* (Zi[a] - (A1 / L) * (Zf[a] - Zi[a]) - Zn) / B1 + E3R* (-Zi[a] - (A2 / L) * (-Zf[a] + Zi[a]) - Zn) / B2;
                        }
                        else
                        {
                            E1Z = E1R* (Zi[a] + (A1 / L) * (Zf[a] - Zi[a]) - Zn) / B1 + E3R* (-Zi[a] + (A2 / L) * (-Zf[a] + Zi[a]) - Zn) / B2;
                        }

                        double E2Z = (E2R - E4R) * (Zf[a] - Zi[a]) / L;
                        Ezr[m][i] = Ezr[m][i] + E1Z + E2Z;


                     
                        double E1I = (1 / (4 * Math.PI * e0)) * ((Q2[a][a] - DQ2[a][a] * ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2)))) * 2 * L * B1 * ((SIGMA1R + SIGMA2R) / (SIGMA1R * SIGMA2R * (SIGMA1R + SIGMA2R - L) * (SIGMA1R + SIGMA2R + L)))
                            - (DQ2[a][a] / L) * (B1 / SIGMA1R - B1 / SIGMA2R));
                        double E2I = (1 / (4 * Math.PI * e0)) * ((Q2[a][a] - DQ2[a][a] * ((Math.Pow(SIGMA1R, 2) - Math.Pow(SIGMA2R, 2)) / (2 * Math.Pow(L, 2)))) * (1 / SIGMA1R - 1 / SIGMA2R)
                            - (DQ2[a][a] / L) * Math.Log((SIGMA1R + SIGMA2R + L) / (SIGMA1R + SIGMA2R - L))
                            - (DQ2[a][a]) * ((SIGMA1R + SIGMA2R) * (Math.Pow((SIGMA1R - SIGMA2R), 2) - Math.Pow(L, 2))) / (2 * SIGMA1R * SIGMA2R * Math.Pow(L, 2)));

                        double E3I = (1 / (4 * Math.PI * e0)) * ((-Q2[a][a] + DQ2[a][a] * ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2)) / (2 * Math.Pow(L, 2)))) * 2 * L * B2 * ((SIGMA1I + SIGMA2I) / (SIGMA1I * SIGMA2I * (SIGMA1I + SIGMA2I - L) * (SIGMA1I + SIGMA2I + L)))
                            - (-DQ2[a][a] / L) * (B2 / SIGMA1I - B2 / SIGMA2I));
                        double E4I = (1 / (4 * Math.PI * e0)) * ((-Q2[a][a] + DQ2[a][a] * ((Math.Pow(SIGMA1I, 2) - Math.Pow(SIGMA2I, 2)) / (2 * Math.Pow(L, 2)))) * (1 / SIGMA1I - 1 / SIGMA2I)
                            - (-DQ2[a][a] / L) * Math.Log((SIGMA1I + SIGMA2I + L) / (SIGMA1I + SIGMA2I - L))
                            - (-DQ2[a][a]) * ((SIGMA1I + SIGMA2I) * (Math.Pow((SIGMA1I - SIGMA2I), 2) - Math.Pow(L, 2))) / (2 * SIGMA1I * SIGMA2I * Math.Pow(L, 2)));


                        if (Xn[i] < Xi[a])
                        {
                            E1X = E1I* (Xi[a] - (A1 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B1 + E3I* (Xi[a] - (A2 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B2;
                        }
                        else
                        {
                            E1X = E1I* (Xi[a] + (A1 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B1 + E3I* (Xi[a] + (A2 / L) * (Xf[a] - Xi[a]) - Xn[i]) / B2;
                        }

                        E2X = (E2I + E4I) * (Xf[a] - Xi[a]) / L;
                        Exi[m][i] = Exi[m][i] + E1X + E2X;

                        if (Yn[m] < Yi[a])
                        {
                            E1Y = E1I* (Yi[a] - (A1 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B1 + E3I* (Yi[a] - (A2 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B2;
                        }
                        else
                        {
                            E1Y = E1I* (Yi[a] + (A1 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B1 + E3I* (Yi[a] + (A2 / L) * (Yf[a] - Yi[a]) - Yn[m]) / B2;
                        }

                        E2Y = (E2I + E4I) * (Yf[a] - Yi[a]) / L;
                        Eyi[m][i] = Eyi[m][i] + E1Y + E2Y;

                        if (Zn<Zi[a])
                        {
                            E1Z = E1I* (Zi[a] - (A1 / L) * (Zf[a] - Zi[a]) - Zn) / B1 + E3I* (-Zi[a] - (A2 / L) * (-Zf[a] + Zi[a]) - Zn) / B2;
                        }
                        else
                        {
                            E1Z = E1I* (Zi[a] + (A1 / L) * (Zf[a] - Zi[a]) - Zn) / B1 + E3I* (-Zi[a] + (A2 / L) * (-Zf[a] + Zi[a]) - Zn) / B2;
                        }

                        E2Z = (E2I - E4I) * (Zf[a] - Zi[a]) / L;
                        Ezi[m][i] = Ezi[m][i] + E1Z + E2Z;
                    }
                }
            }

            double[,] E = new double[xn.Length, yn.Length];
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
                    if (m == 0)
                    {
                        y = Yn[0];
                    }
                    else
                    {
                        y = y + Intervalo;

                    }

                    double zz = E[m,i] = (Math.Sqrt((Math.Pow(Exr[m][i], 2) + Math.Pow(Exi[m][i], 2) + Math.Pow(Eyr[m][i], 2) + Math.Pow(Eyi[m][i], 2)) + Math.Pow(Ezr[m][i], 2) + Math.Pow(Ezi[m][i], 2))) * 0.001;
                    Z = (float)zz;

                    pts[i, m] = new Point3((float)x, (float)y, Z, 1);
                }
            }
            Max = E.Cast<double>().Max();
            HGrafico = Math.Round(Max);

        }
       

        public double[] getVr()
        {
            vr = new double[Xi.Length];
            int cont = 0;
            for (int i = 0; i < Xi.Length; i++)
            {
                if (cont == 0)
                {
                    vr[i] = Math.Cos(Ang[i] * Math.PI / 180)  * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                }
                else if (cont == 1)
                {
                    vr[i] = Math.Cos(Ang[i] * Math.PI / 180) * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                }
                else if (cont == 2)
                {
                    vr[i] = Math.Cos(Ang[i] * Math.PI / 180) * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                    cont = -1;
                }
                cont++;
            }
            n = vr.Length;
            return vr;
        }

        public double[] getVi()
        {
            vi = new double[Xi.Length];
            int cont = 0;
            for (int i = 0; i < Xi.Length; i++)
            {
                if (cont == 0)
                {
                    vi[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                }
                else if (cont == 1)
                {
                    vi[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                }
                else if (cont == 2)
                {
                    vi[i] = Math.Sin(Ang[i] * Math.PI / 180) * this.v[i] * Math.Pow(Math.Sqrt(3), -1);
                    cont = -1;
                }
                cont++;
            }

            return vi;
        }


    }
}
