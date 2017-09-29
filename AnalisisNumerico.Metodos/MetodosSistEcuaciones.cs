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
        /// de coeficientes y un vector de términos independientes, obtenidos a partir de los coeficientes de un sistema de
        /// ecuaciones.
        /// </summary>
        /// <param name="matrizCoeficientes">Matriz cuadrada de coeficientes.</param>
        /// <param name="vectorIndependientes">Vector de términos independientes.</param>
        public static decimal[] GaussJordan(decimal[,] matrizCoeficientes, decimal[] vectorIndependientes)
        {
            int n = vectorIndependientes.Length;

            for (int columna = 0; columna < n; columna++)
            {
                #region Normalización de la fila.
                decimal factor = matrizCoeficientes[columna, columna];

                for (int i = 0; i < n; i++)
                {
                    matrizCoeficientes[i, columna] /= factor;
                }

                vectorIndependientes[columna] /= factor;
                #endregion

                for (int fila = 0; fila < n; fila++)
                {
                    if (fila != columna)
                    {
                        #region Multiplicación de la fila normalizada por el coeficiente.
                        decimal[] filaPorCoef = new decimal[n + 1];

                        for (int i = 0; i < n; i++)
                        {
                            filaPorCoef[i] = matrizCoeficientes[i, columna] * matrizCoeficientes[columna, fila];
                        }

                        filaPorCoef[n] = vectorIndependientes[columna] * matrizCoeficientes[columna, fila];
                        #endregion

                        #region Resta entre la fila actual y el producto obtenido anteriormente.
                        for (int i = 0; i < n; i++)
                        {
                            matrizCoeficientes[i, fila] -= filaPorCoef[i];
                        }

                        vectorIndependientes[fila] -= filaPorCoef[n];
                        #endregion
                    }
                }
            }

            return vectorIndependientes;
        }

        public static decimal[] GaussSeidel()
        {
            return new decimal[0];
        }
    }
}