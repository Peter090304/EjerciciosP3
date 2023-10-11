namespace EjerciciosP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();

            Console.WriteLine("Matriz de Números:");
            ejercicios.LlenarMatrizNumeros();

            Console.WriteLine("\nMatriz de Colores:");
            ejercicios.LlenarMatrizColores();

            Console.WriteLine("\nMatriz de Caracteres:");
            ejercicios.LlenarMatrizCaracteres();


        }

    }

}
