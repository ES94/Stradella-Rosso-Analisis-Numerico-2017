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
    public static class MetodosIntegNum
    {
        public static double TrapecioSimple(double a, double b, string func)
        {
            double Res = ((MetodosRaices.ImagenDe(func, a) + MetodosRaices.ImagenDe(func, b)) * (b - a)) / 2;
            return Res;
        }

        public static double TrapecioMultiple(string func, double a, double b, int intervalos)
        {
            double h = (b - a) / intervalos;
            double suma = 0;
            for (int i = 0; i < intervalos; i++)
            {
                suma += MetodosRaices.ImagenDe(func, (a + i * h));
            }
            double Res = ((h / 2) * (MetodosRaices.ImagenDe(func, a) + 2 * suma + MetodosRaices.ImagenDe(func, b)));
            return Res;
        }


        public static double Simpson1_3Simple(string funcion, double a, double b)
        {
            double h = (b - a) / 2;
            double y0 = MetodosRaices.ImagenDe(funcion, a);
            double y1 = MetodosRaices.ImagenDe(funcion, a + h);
            double y2 = MetodosRaices.ImagenDe(funcion, b);

            return (h / 3) * (y0 + (4 * y1) + y2);
        }

        public static double Simpson1_3Multiple(string funcion, double a, double b, int n)
        {
            double resultado = 0;
            double h = (b - a) / n;

            if (Math.Pow(-1, n) > 0)
            {
                double y0 = MetodosRaices.ImagenDe(funcion, a);
                double y1 = MetodosRaices.ImagenDe(funcion, b);
                double sumImp = 0, sumPar = 0;

                sumImp = Sum(funcion, a, h, 1, n - 1, 2);
                sumPar = Sum(funcion, a, h, 2, n - 2, 2);

                resultado = (h / 3) * (y0 + (4 * sumImp) + (2 * sumPar) + y1);
            }
            else
            {
                resultado = Simpson1_3Multiple(funcion, a, b - 3 * h, n - 3) + Simpson3_8Simple(funcion, b - 3 * h, b);
            }

            return resultado;
        }

        private static double Simpson3_8Simple(string funcion, double a, double b)
        {
            double h = (b - a) / 3;
            double y0 = MetodosRaices.ImagenDe(funcion, a);
            double y1 = MetodosRaices.ImagenDe(funcion, a + h);
            double y2 = MetodosRaices.ImagenDe(funcion, b - h);
            double y3 = MetodosRaices.ImagenDe(funcion, b);

            return (3/8 * h) * (y0 + 3 * y1 + 3 * y2 + y3);
        }

        private static double Sum(string funcion, double xInicio, double h, int desde, int hasta, int paso)
        {
            double resultado = 0;
            double xi = xInicio;

            for (int i = desde; i <= hasta; i += paso)
            {
                xi += h * paso;
                resultado += MetodosRaices.ImagenDe(funcion, xi);
            }

            return resultado;
        }
    }
}
