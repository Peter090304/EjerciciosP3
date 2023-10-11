using System;
using static EjerciciosP3.Ejercicios;

namespace EjerciciosP3
{
    internal class Ejercicios
    {
        public void LlenarMatrizNumeros()
        {
            int[,] matriz = new int[3, 3];
            int contador = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = contador;
                    contador++;
                }
            }

            ImprimirMatriz(matriz);
        }

        public void LlenarMatrizColores()
        {
            string[,] colores = { { "Rojo", "Verde" }, { "Azul", "Amarillo" } };
            ImprimirMatriz(colores);
        }

        public void LlenarMatrizCaracteres()
        {
            char[,] caracteres = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' } };
            ImprimirMatriz(caracteres);
        }

        private void ImprimirMatriz<T>(T[,] matriz)
        {
            Console.WriteLine("Matriz:");
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char[,] matriz = new char[2, 4];
            char caracter = 'A';

            // Llenar la matriz con caracteres alfabéticos
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = caracter;
                    caracter++;
                }
            }

            // Imprimir la matriz en forma de tabla
            Console.WriteLine("Matriz de Caracteres:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

    



