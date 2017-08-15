using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos
{
    public class MetodosRaices
    {
        public double? ResultadoRaices
        {
            get
            {
                return resultadoRaices;
            }
        }

        public double? ResultadoSistEq
        {
            get
            {
                return resultadoSistEq;
            }
        }

        public double? ResultadoRegInter
        {
            get
            {
                return resultadoRegInter;
            }
        }

        public double? ResultadoInteg
        {
            get
            {
                return resultadoInteg;
            }
        }

        private double? resultadoRaices;
        private double? resultadoSistEq;
        private double? resultadoRegInter;
        private double? resultadoInteg;
        private int ITER = 100;
        private double TOLE = .01;

        public double Funcion(double x)
        {
            return Math.Pow((x - 3), 2) - 1;
        }

        private double? Biseccion(double Xi, double Xd)
        {
            double? resultado = null;
            int contadorIteraciones = 0;
            
            if ((Funcion(Xi) * Funcion(Xd)) > 0)
            {
                throw new Exception("Error: debe ingresar parámetros de signos opuestos.");
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
                double ERROR = 0;
                double XR = 0;

                while (!((Math.Abs(Funcion(XR)) < TOLE) || (ERROR < TOLE) || (C >= ITER)))
                {
                    C++;
                    XR = (Xi + Xd) / 2;
                    ERROR = Math.Abs(XR - XANT) / XR;

                    if ((Funcion(Xi) * Funcion(XR)) > 0)
                    {
                        Xi = XR;
                    }
                    else
                    {
                        Xd = XR;
                    }

                    XANT = XR;
                }

                resultado = XR;
            }

            return resultado;
        }

        public static double? ReglaFalsa()
        {
            double? resultado = null;
            int contadorIteraciones = 0;


            return resultado;
        }

        public static double? Newton()
        {
            double? resultado = null;
            int contadorIteraciones = 0;


            return resultado;
        }

        public static double? Secante()
        {
            double? resultado = null;
            int contadorIteraciones = 0;


            return resultado;
        }
    }
}
