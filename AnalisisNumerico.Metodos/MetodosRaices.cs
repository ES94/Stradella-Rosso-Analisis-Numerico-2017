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

        
        public static double? ReglaFalsa(double Xi, double Xd)
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
                double XR = (Funcion(Xd) * Xi - Funcion(Xi) * Xd) / (Funcion(Xd) - Funcion(Xi));
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
                    XR = (Funcion(Xd) * Xi - Funcion(Xi) * Xd) / (Funcion(Xd) - Funcion(Xi));
                    ERROR = Math.Abs(XR - XANT) / XR;
                }

                resultado = XR;
            }

            return resultado;
        }

        private static double FalsaDerivada(double XINI)
        {
            double Derivada;
            double Anterior;
            /// CASO 1
            if ((Funcion(XINI + 0.0001) - Funcion(XINI)) / 0.0001 == 0)
            {
                Derivada = 0.0001;
            }
            else
            {
                Derivada = (Funcion(XINI + 0.0001) - Funcion(XINI)) / 0.0001;
            }
            Anterior = XINI;
            

            return Derivada;
        }

        public static double? Newton(double XINI)
        {
            double? resultado = null;
            double XANT = 0;
            double XR = 0;
            double ERROR = 0;
            if (Math.Abs(Funcion(XINI)) < TOLE)
            {
                resultado = XINI;
            }
            else
            {
                XANT = 0;
                for (int i = 0; i < ITER; i++)
                {
                  
                    XR = XINI - (Funcion(XINI) / FalsaDerivada(XINI));
                    ERROR = Math.Abs(XR - XANT) / XR;
                    if ((Math.Abs(Funcion(XR)) < TOLE) || (ERROR < TOLE))
                    {
                        break;
                    }
                    else
                    {
                        XINI = XR;
                        XANT = XR;
                    }
                }
                resultado = XR;
            }
            return resultado;
        }

        public static double? Secante(double XINI, double XANT)
        {
            double? resultado = null;
            double XR = 0;
            double ERROR = 0;

            if (Math.Abs(Funcion(XINI)) < TOLE)
            {
                resultado = XINI;
            }
            else
            {
                for (int i = 0; i < ITER; i++)
                {
                    XR = ((Funcion(XANT) * XINI) - (Funcion(XINI) * XANT)) / (Funcion(XANT) - Funcion(XINI));
                    ERROR = Math.Abs(XR - XANT) / XR;

                    if ((Math.Abs(Funcion(XR)) < TOLE) || (ERROR < TOLE))
                    {
                        break;
                    }
                    else
                    {
                        XINI = XANT;
                        XANT = XR;
                    }
                }

                resultado = XR;
            }

            return resultado;
        }

        private static double Funcion(double x)
        {
            //return Math.Pow(x - 3, 2) - 1;
            return (0.5 * x - 4);
        }
        //private static double FuncionAGraficar(string f, double x)
        //{
        //    Function funcion = new Function(f);
        //    string argumento = "x = " + Convert.ToString(x).Replace(',', ':');
        //    Argument argument = new Argument(argumento);
        //    Expression r = new Expression("f(x)", funcion, argument);

        //    var a = r.calculate();

        //    return a;
        //}
    }
}
