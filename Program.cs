
using System;

public class ADIVINA_EL_NUMERO
{
    public static void Main(string[] args)
    {
        double num;
        int numIntentos = 0;
       

        Console.WriteLine("Adivine el número correcto: ");
        Console.WriteLine("Ingrese un numero: ");

        do
        {
            numIntentos++;

            if (double.TryParse(Console.ReadLine(), out num))
            {
                if (num == 5.0)
                {
                    Console.WriteLine($"El número ingresado es correcto, GANASTE!. Se tomaron {numIntentos} intentos");
                    break;
                }
                else if (num < 5)
                {
                    Console.WriteLine("El numero correcto es mayor");
                }
                else if (num > 5)
                {
                    Console.WriteLine("El numero correcto es menor");
                }

                else
                {
                    Console.WriteLine("Ingrese un número válido.");
                }

            }

            

           
        } while (true);
    }
}