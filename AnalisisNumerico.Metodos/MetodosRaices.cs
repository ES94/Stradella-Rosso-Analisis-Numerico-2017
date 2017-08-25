using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using org.mariuszgromada.math.mxparser.mathcollection;
using org.mariuszgromada.math.mxparser.parsertokens;
using org.mariuszgromada.math.mxparser.regressiontesting;
using org.mariuszgromada.math.mxparser.syntaxchecker;

namespace AnalisisNumerico.Metodos
{
    public static class MetodosRaices
    {
        private static int ITER = 100;
        private static double TOLE = .01;
        private static double? resultadoRaices = null;
        private static double? resultadoSistEq = null;
        private static double? resultadoRegInter = null;
        private static double? resultadoInteg = null;

        public static double? ResultadoRaices
        {
            get
            {
                return resultadoRaices;
            }
        }

        public static double? ResultadoSistEq
        {
            get
            {
                return resultadoSistEq;
            }
        }

        public static double? ResultadoRegInter
        {
            get
            {
                return resultadoRegInter;
            }
        }

        public static double? ResultadoInteg
        {
            get
            {
                return resultadoInteg;
            }
        }

        public static double? Biseccion(double Xi, double Xd)
        {
            double? resultado = null;

            if ((Funcion(Xi) * Funcion(Xd)) > 0)
            {
                resultado = null;
            }
            else if ((Funcion(Xi) * Funcion(Xd)) == 0)
            {
                if (Funcion(Xi) == 0)
                {
                    resultado = Xi;
                }
                else
                {
                    resultado = Xd;
                }
            }
            else
            {
                int C = 0;
                double XANT = 0;
                double XR = (Xi + Xd) / 2;
                double ERROR = Math.Abs(XR - XANT) / XR;

                while (!((Math.Abs(Funcion(XR)) < TOLE) || (ERROR < TOLE) || (C >= ITER)))
                {
                    if ((Funcion(Xi) * Funcion(XR)) > 0)
                    {
                        Xi = XR;
                    }
                    else
                    {
                        Xd = XR;
                    }

                    C++;
                    XANT = XR;
                    XR = (Xi + Xd) / 2;
                    ERROR = Math.Abs(XR - XANT) / XR;
                }

                resultado = XR;
            }

            return resultado;
        }

        public static double? ReglaFalsa()
        {
            double? resultado = null;

            return resultado;
        }

        public static double? Newton()
        {
            double? resultado = null;

            return resultado;
        }

        public static double? Secante()
        {
            double? resultado = null;

            return resultado;
        }

        private static double Funcion(double x)
        {
            return Math.Pow(x - 3, 2) - 1;
        }
    }
}
