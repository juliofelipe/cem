using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using Chart3DLib;

namespace CEM
{
    class DadosEntrada
    {

        private string xInicial = "-10;0;10";
        private string xFinal = "-10;0;10"; 
        private string yInicial = "-10;-10;-10";
        private string yFinal = "10;10;10";
        private string zInicial = "10,6;10,6;10,6";
        private string zFinal = "10,6;10,6;10,6";
        private string corrente = "1000;500;1000";
        private string tensao = "500;230;500";
        private string xn = "-80;80;121";
        private string yn = "-80;80;121";
        private double zn = 2;
        private string angulo = "0;120;-120";
        private string diametro = "0,3;0,3;0,3";
  

        public DadosEntrada()
        {
        }

        // Dados dos Cabos

        [Description("Define o ponto inicial em X."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string XInicial
        {
            get { return xInicial; }
            set { xInicial = value; }
        }

        [Description("Define o ponto final em X."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string XFinal
        {
            get { return xFinal; }
            set { xFinal = value; }
        }

        [Description("Define o ponto inicial em Y."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string YInicial
        {
            get { return yInicial; }
            set { yInicial = value; }
        }

        [Description("Define o ponto final em Y."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string YFinal
        {
            get { return yFinal; }
            set { yFinal = value; }
        }

        [Description("Define o ponto inicial em Z."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string ZInicial
        {
            get { return zInicial; }
            set { zInicial = value; }
        }

        [Description("Define o ponto final em Z."),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string ZFinal
        {
            get { return zFinal; }
            set { zFinal = value; }
        }
        [Description("Define o diametro dos cabos"),
                Category("Pontos dos Cabos"), DefaultValue(5)]
        public string Diâmetro
        {
            get { return diametro; }
            set { diametro = value; }
        }

        [Description("Define a corrente no Circuito."),
                Category("Dados Elétricos"), DefaultValue(5)]
        public string Corrente
        {
            get { return corrente; }
            set { corrente = value; }
        }

        [Description("Define a tensão no Circuito."),
                Category("Dados Elétricos"), DefaultValue(5)]
        public string Tensao
        {
            get { return tensao; }
            set { tensao = value; }
        }

        [Description("Define o ângulo das fases."),
               Category("Dados Elétricos"), DefaultValue(5)]
        public string Angulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

        [Description("Define os pontos de medição do campo em X."),
                Category("Pontos de medição"), DefaultValue(5)]
        public string Xn
        {
            get { return xn; }
            set { xn = value; }
        }

        [Description("Define os pontos de medição do campo em Y."),
                Category("Pontos de medição"), DefaultValue(5)]
        public string Yn
        {
            get { return yn; }
            set { yn = value; }
        }

        [Description("Define os ponto de medição do campo em Z."),
                Category("Pontos de medição"), DefaultValue(5)]
        public double Zn
        {
            get { return zn; }
            set { zn = value; }
        }

        


    }
}

