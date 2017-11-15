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
        public static int ITER { get; set; }
        public static double TOLE = 0.0001d;
        public static int contadorIteraciones = 0;

        public static double? Biseccion(string funcion, double Xi, double Xd)
        {
            double? resultado = null;

            if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, Xd)) > 0)
            {
                resultado = null;
            }
            else if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, Xd)) == 0)
            {
                if (ImagenDe(funcion, Xi) == 0)
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

                while (!((Math.Abs(ImagenDe(funcion, XR)) < TOLE) || (Math.Abs(ERROR) < TOLE) || (C >= ITER)))
                {
                    if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, XR)) > 0)
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

                contadorIteraciones = C;
                resultado = XR;
            }

            return resultado;
        }

        public static double? ReglaFalsa(string funcion, double Xi, double Xd)
        {
            double? resultado = null;

            if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, Xd)) > 0)
            {
                resultado = null;
            }
            else if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, Xd)) == 0)
            {
                if (ImagenDe(funcion, Xi) == 0)
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
                double XR = (ImagenDe(funcion, Xd) * Xi - ImagenDe(funcion, Xi) * Xd) / (ImagenDe(funcion, Xd) - ImagenDe(funcion, Xi));
                double ERROR = Math.Abs(XR - XANT) / XR;

                while (!((Math.Abs(ImagenDe(funcion, XR)) < TOLE) || (Math.Abs(ERROR) < TOLE) || (C >= ITER)))
                {
                    if ((ImagenDe(funcion, Xi) * ImagenDe(funcion, XR)) > 0)
                    {
                        Xi = XR;
                    }
                    else
                    {
                        Xd = XR;
                    }

                    C++;
                    XANT = XR;
                    XR = (ImagenDe(funcion, Xd) * Xi - ImagenDe(funcion, Xi) * Xd) / (ImagenDe(funcion, Xd) - ImagenDe(funcion, Xi));
                    ERROR = Math.Abs(XR - XANT) / XR;
                }

                contadorIteraciones = C;
                resultado = XR;
            }

            return resultado;
        }

        private static double FalsaDerivada(string funcion, double XINI)
        {
            double Derivada;
            double Anterior;
            
            if ((ImagenDe(funcion, XINI + 0.0001) - ImagenDe(funcion, XINI)) / 0.0001 == 0)
            {
                Derivada = 0.0001;
            }
            else
            {
                Derivada = (ImagenDe(funcion, XINI + 0.0001) - ImagenDe(funcion, XINI)) / 0.0001;
            }
            Anterior = XINI;


            return Derivada;
        }

        public static double? Newton(string funcion, double XINI)
        {
            double? resultado = null;
            double XANT = 0;
            double XR = 0;
            double ERROR = 0;
            if (Math.Abs(ImagenDe(funcion, XINI)) < TOLE)
            {
                resultado = XINI;
            }
            else
            {
                XANT = 0;
                for (int i = 0; i < ITER; i++)
                {

                    XR = XINI - (ImagenDe(funcion, XINI) / FalsaDerivada(funcion, XINI));
                    ERROR = Math.Abs(XR - XANT) / XR;
                    if ((Math.Abs(ImagenDe(funcion, XR)) < TOLE) || (Math.Abs(ERROR) < TOLE))
                    {
                        break;
                    }
                    else
                    {
                        XINI = XR;
                        XANT = XR;
                    }

                    contadorIteraciones = i;
                }
                resultado = XR;
            }
            return resultado;
        }

        public static double? Secante(string funcion, double XINI, double XANT)
        {
            double? resultado = null;
            double XR = 0;
            double ERROR = 0;

            if (Math.Abs(ImagenDe(funcion, XINI)) < TOLE)
            {
                resultado = XINI;
            }
            else
            {
                for (int i = 0; i < ITER; i++)
                {
                    XR = ((ImagenDe(funcion, XANT) * XINI) - (ImagenDe(funcion, XINI) * XANT)) / (ImagenDe(funcion, XANT) - ImagenDe(funcion, XINI));
                    ERROR = Math.Abs(XR - XANT) / XR;

                    if ((Math.Abs(ImagenDe(funcion, XR)) < TOLE) || (Math.Abs(ERROR) < TOLE))
                    {
                        break;
                    }
                    else
                    {
                        XINI = XANT;
                        XANT = XR;
                    }

                    contadorIteraciones = i;
                }

                resultado = XR;
            }

            return resultado;
        }

        /// <summary>
        /// Devuelve la imagen de una función pasada como parámetro, evaluada en la variable pasada como parámetro.
        /// </summary>
        /// <param name="f">Función a ser evaluada.</param>
        /// <param name="x">Valor con la cuál la función será evaluada.</param>
        public static double ImagenDe(string f, double x)
        {
            return new Function(f).calculate(x);
        }

        public static double ImagenDe(Function f, double x)
        {
            return f.calculate(x);
        }
    }
}
