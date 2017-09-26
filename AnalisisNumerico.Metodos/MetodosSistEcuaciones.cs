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
    public static class MetodosSistEcuaciones
    {
        /// <summary>
        /// Obtiene un vector de los resultados de un sistema de ecuaciones a partir de la construcción y reducción de una matriz
        /// obtenida de los coeficientes del sistema.
        /// </summary>
        /// <param name="n">Orden de la matriz cuadrada de coeficientes.</param>
        /// <param name="vectorCoeficientes">Vector de todos los coeficientes ordenados, empezando desde los coeficientes de la primera
        /// ecuación hasta los coeficientes de la última ecuación.</param>
        public static List<double> GaussJordan(List<List<double>> matrizCoeficientes)
        {
            List<double> vectorResultado = new List<double>(matrizCoeficientes.Count);

            for (int columna = 0; columna < matrizCoeficientes.Count; columna++)
            {
                List<double> eqNormalizada = matrizCoeficientes[columna];

                /*
                 * Normalizar ecuación a utilizar en la columna actual.
                 */
                for (int i = 0; i < eqNormalizada.Count; i++)
                {
                    eqNormalizada[i] /= eqNormalizada.Max();
                }

                for (int fila = 0; fila < matrizCoeficientes.Count; fila++)
                {
                    if (columna != fila)
                    {
                        double coeficiente = matrizCoeficientes[fila][columna];
                        List<double> ecuacionActual = matrizCoeficientes[fila];
                        List<double> eqNormalizadaPorCoef = eqNormalizada;

                        /*
                         * Se multiplica la ecuación normalizada por el coeficiente actual.
                         */
                        for (int i = 0; i < eqNormalizada.Count; i++)
                        {
                            eqNormalizadaPorCoef[i] = eqNormalizada[i] * coeficiente;
                        }

                        /*
                         * A la ecuación en la fila actual se le resta el producto la ecuación normalizada por el coeficiente.
                         */
                        for (int i = 0; i < ecuacionActual.Count; i++)
                        {
                            ecuacionActual[i] -= eqNormalizadaPorCoef[i];
                        }
                    }
                }
            }

            /*
             * Se rellena al vector con los valores de resultado. Las posiciones de los coeficientes indican a qué variable pertenecen.
             */
            for (int fila = 0; fila < matrizCoeficientes.Count; fila++)
            {
                for (int columna = 0; columna < matrizCoeficientes.Count; columna++)
                {
                    if (fila == columna)
                    {
                        vectorResultado.Add(matrizCoeficientes[fila][columna]);
                    }
                }
            }

            return vectorResultado;
        }
    }
}
