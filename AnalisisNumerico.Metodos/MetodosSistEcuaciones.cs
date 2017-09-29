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
        public static decimal[] GaussJordan(decimal[,] matrizCoeficientes, decimal[] vectorIndependientes)
        {
            int n = vectorIndependientes.Length;

            for (int columna = 0; columna < n; columna++)
            {
                /*
                 * Se normliza la fila para trabajar con la columna.
                 */
                for (int i = 0; i < n; i++)
                {
                    matrizCoeficientes[i, columna] /= matrizCoeficientes[columna, columna];
                }

                vectorIndependientes[columna] /= matrizCoeficientes[columna, columna];

                for (int fila = 0; fila < n; fila++)
                {
                    if (fila != columna)
                    {
                        /*
                         * Se multiplica la fila normalizada por el coeficiente que se debe convertir a cero.
                         */
                        decimal[] filaPorCoef = new decimal[n];

                        for (int i = 0; i < n - 1; i++)
                        {
                            filaPorCoef[i] = matrizCoeficientes[i, columna] * matrizCoeficientes[columna, fila];
                        }

                        filaPorCoef[n - 1] = vectorIndependientes[columna] * matrizCoeficientes[columna, fila];

                        /*
                         * A la fila a la cuál pertenece el coeficiente que se debe convertir a cero se le resta el valor
                         * auxiliar obtenido de la fila multiplicada por el mismo coeficiente.
                         */
                        for (int i = 0; i < n - 1; i++)
                        {
                            matrizCoeficientes[i, fila] -= filaPorCoef[i];
                        }

                        vectorIndependientes[fila] -= filaPorCoef[n - 1];
                    }
                }
            }

            return vectorIndependientes;
        }
    }
}
