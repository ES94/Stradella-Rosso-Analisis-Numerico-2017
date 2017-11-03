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
    public static class MetodosRegInterpolacion
    {
        public static List<double> RegLinealMinCuadrados(List<Punto> listaPuntos)
        {
            int n = listaPuntos.Count;
            List<double> resultados = new List<double>();

            double a1 = (n * listaPuntos.Sum(punto => punto.X * punto.Y) - listaPuntos.Sum(punto => punto.X) * listaPuntos.Sum(punto => punto.Y)) / 
                (n * listaPuntos.Sum(punto => Math.Pow(punto.X, 2)) - Math.Pow(listaPuntos.Sum(punto => punto.X), 2));
            double a0 = listaPuntos.Average(punto => punto.Y) - a1 * listaPuntos.Average(punto => punto.X);
            double st = listaPuntos.Sum(punto => Math.Pow(listaPuntos.Average(pt => pt.Y) - punto.Y, 2));
            double sr = listaPuntos.Sum(punto => Math.Pow(punto.Y - a1 * punto.X - a0, 2));
            double r = Math.Sqrt((st - sr) / st) * 100;

            resultados.Add(a0);
            resultados.Add(a1);
            resultados.Add(r);

            return resultados;
        }

        public static List<double> RegPoliMinCuadrados(List<Punto> listaPuntos)
        {
            int n = listaPuntos.Count;
            List<double> resultados = new List<double>();



            return resultados;
        }

        public static List<double> InterpolacionLagrange()
        {
            List<double> resultados = new List<double>();

            return resultados;
        }
    }

    public class Punto
    {
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}
