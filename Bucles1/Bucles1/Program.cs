using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num;

            Console.WriteLine("Introduzca un número");
            num = Convert.ToInt32(Console.ReadLine());

            while (i < 11)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
                i++;
            }
            Console.ReadLine();

            int e = 0;

            while (e < 101)
            {
                Console.WriteLine(e);
                e++;
            }
            Console.ReadLine();

            //do
            int a, b;
            a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a == 1);

            Console.ReadLine();
            //Pida un número hasta que lo que introduzca el usuario sea negativo
            //dowhile
            do
            {
                Console.WriteLine("introduzca un número");
                b = Convert.ToInt32(Console.ReadLine());


            } while (b >= 0);
            Console.WriteLine("¡Su número es negativo!");
            Console.ReadLine();

            //while

            Console.WriteLine("ntroduzca un número");
            b = Convert.ToInt32(Console.ReadLine());

            while (b >= 0)
            {
                Console.WriteLine("ntroduzca otro número");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("¡Su número es negativo!");
            Console.ReadLine();

            //for
            for (int c = 0; c <= 10; c++)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            //Pedir 4 numeros y escribir la suma total

            int y = 0, suma = 0;

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Introduzca un número");
                y = Convert.ToInt32(Console.ReadLine());
                suma = suma + y;
            }
            Console.WriteLine("Total: " + suma);
            Console.ReadLine();

            //Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.


            for (int salto = 10; salto < 21; salto++)
            {
                Console.WriteLine(salto + "\n");
            }
            Console.ReadLine();
            //Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.
            for(int g= 20; g>=10; g--)
            {
                Console.WriteLine(g + "\n");
            }
            Console.ReadLine();

            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            int sumaDiez = 0, yDiez = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Introduzca un número");
                y = Convert.ToInt32(Console.ReadLine());
                sumaDiez = sumaDiez + yDiez;
            }
            Console.WriteLine("Total: " + suma);
            Console.ReadLine();

            //Escribe un programa que pida valores hasta que el usuario introduzca un 0. Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos. Mostrar la suma de los valores introducidos. 

            int numIntro = 0, sumaPositivos = 0;

            do
            {
                Console.WriteLine("Introduzca un número:");
                numIntro = Convert.ToInt32(Console.ReadLine());

                if (numIntro < 0)
                {
                    Console.WriteLine("No se admiten números negativos.");
                }
                else
                {
                    sumaPositivos = numIntro + sumaPositivos;
                }
            } while (numIntro != 0);

            Console.WriteLine("El total es " + sumaPositivos);
            Console.ReadLine();

            //Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I . Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.
            string parImpar;

            Console.WriteLine("Elija una opción (P/I)");
            parImpar = Console.ReadLine();

            while (parImpar != "p" && parImpar != "i")
            {
                Console.WriteLine("Ese valor no es correcto, introduzca otra vez.");
                parImpar = Console.ReadLine();
            }

            if (parImpar == "p")
            {
                for (int l = 2; l < 100; l = l + 2)
                {
                    Console.WriteLine(l);
                }
            }
            else
            {
                for (int j = 1; j < 100; j = j + 2)
                {
                    Console.WriteLine(j);
                }

            }

            Console.ReadLine();

            //Escribe un programa que pregunte al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
            int añosRepito;

            Console.WriteLine("Dígame su edad");
            añosRepito = Convert.ToInt32(Console.ReadLine());

            for (int h = 0; h <= añosRepito; h++)
            {
                Console.WriteLine("Feliz cumpleaños!!");
            }
            Console.ReadLine();

            //Pedir al usuario un número. Mostrar en pantalla 
            //*
            //**
            //***
            //Con tantas líneas como el número que ha introducido
            int numEstrella = 0;

            Console.WriteLine("Introduzca un número");
            numEstrella = Convert.ToInt32(Console.ReadLine());

            for (int m = 0; m <= numEstrella; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();


            //Escribe un programa que muestre los números de 1 a 12 en una columna. En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.

            for (int u = 1; u <= 12; u++)
            {
                Console.Write(u + "\t");

                if (u % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(u, 3));
                }
                else
                {
                    Console.WriteLine(Math.Pow(u, 2));
                }


            }
            Console.ReadLine();

            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.
            int sumaCinco=1;

            for (int g=0; g<10; g++)
            {
                Console.WriteLine(sumaCinco);
                sumaCinco= sumaCinco + 5;
            }
            
            Console.ReadLine();

            //STRINGS

//1.Escribe un programa que te calcule la largura de un string.

            string texto;

            Console.WriteLine("Introduzca su texto");
            texto = Console.ReadLine();
            Console.WriteLine("Su texto tiene " + texto.Length + " caracteres.");
            Console.ReadLine();

            //3.Escribe un programa que te escriba un string al revés. //t=largura


            string reves = "";

                Console.WriteLine("Introduzca su texto");

            texto = Console.ReadLine();
            int largura = texto.Length;

            for (int p = largura - 1; p >= 0; p--)
            {
                reves = reves + texto.Substring(p, 1);      
            }
            Console.WriteLine(reves);
            Console.ReadLine();


            //4.Escribe un programa que te calcule el total de palabras que hay en un string.




            //5.Escribe un programa que copia un string a otro string.
            string texto1, texto2;

            Console.WriteLine("Introduzca su primer texto");
            texto1 = Console.ReadLine();

            Console.WriteLine("Introduzca su segundo texto");
            texto2 = Console.ReadLine();







            //6.Escribe un programa que nos cuente el número de vocales y de consonantes en un string.

            int vocales=0;
            string palabra;

            Console.WriteLine("Introduzca su texto");
            palabra = Console.ReadLine();

            for( int s=0; s< palabra.Length; i++)
            {
                if (palabra [s]=='a'||palabra[s]=='e'|| palabra[s]=='i'||palabra[s]=='o'||palabra[s]=='u')
                {
                    vocales++;
                }

            }
            Console.WriteLine("Su texto tiene " + vocales + " vocales");
            Console.ReadLine();


            //7.Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.





        }
    }   
}
