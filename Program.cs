using System;

namespace TPFinal_BianchiJuanPablo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que 
            // corta cuando se ingresa un cero. A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado 
            // es primo o no y que devuelva true o false según corresponda.

            int n, mayorPar = 0, conImpar = 0, menorPrimo = 1;
            
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            if(Par(n))
                mayorPar = n;
            if(impar(n))
                conImpar++;
            if(primo(n))
                menorPrimo = n;
            while (n != 0)
            {
            Console.WriteLine("Ingrese otro número:");
            n = int.Parse(Console.ReadLine());
            if(Par(n) && n >= mayorPar)
                mayorPar = n;
            if(impar(n))
                conImpar++;
            if(primo(n) && n <= menorPrimo)
                menorPrimo = n;
            }
            
            Console.WriteLine("El mayor de los números pares es: " + mayorPar);
            Console.WriteLine("La cantidad de números impares es: " + conImpar);
            Console.WriteLine("El menor de los números primos es: " + menorPrimo);
        }
        static bool Par(int a){
            if(a % 2 == 0)
                return true;
            else
                return false;
        }
        static bool impar(int a){
            if(a % 2 != 0)
                return true;
            else
                return false;
        }
        static bool primo(int a){
            int con = 0;
            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                    con++;
            }
            if(con == 2)
                return true;
            else
                return false;
        }
    }
}
