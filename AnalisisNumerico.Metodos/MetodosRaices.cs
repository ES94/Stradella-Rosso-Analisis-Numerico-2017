using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos
{
    public class MetodosRaices
    {
        private decimal ResultadosRaices { get; set; }

        private int TopeIteraciones = 100;

        private decimal ErrorRelativo { get; set; }

        private bool OperacionFallida { get; set; }

        public double Funcion(double x)
        {
            return Math.Pow((x - 3), 2) - 1;
        }

        private double? Biseccion(double Xi, double Xf)
        {
            double? resultado = 0;
            int contadorIteraciones = 0;
            OperacionFallida = false;

            while ((Xi != Xf) && (contadorIteraciones <= TopeIteraciones))
            {
                double puntoMedio = (Xi + Xf) / 2;

                contadorIteraciones++;

                if (Funcion(puntoMedio) == 0)
                {
                    resultado = Funcion(puntoMedio);

                    break;
                }
                else if ((Funcion(Xi) * Funcion(Xf)) < 0)
                {
                    Xf = puntoMedio;
                }
                else
                {
                    Xi = puntoMedio;
                }

            }

            if (Xi == Xf)
            {
                resultado = null;
            }

            if (contadorIteraciones == TopeIteraciones)
            {
                OperacionFallida = true;
            }

            return resultado;
        }

        private void ReglaFalsa()
        {

        }

        private void Newton()
        {

        }

        private void Secante()
        {

        }
    }
}
