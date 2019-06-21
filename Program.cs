using System;
/*Esta es una tarea de demostración.
Escribe una función:
solución de clase {solución pública int (int [] A); }
que, dada una matriz A de N enteros, devuelve el entero positivo más pequeño (mayor que 0) 
que no ocurre en A.
Por ejemplo, dado que A = [1, 3, 6, 4, 1, 2], la función debe devolver 5.
Dado que A = [1, 2, 3], la función debe devolver 4.
Dado que A = [−1, −3], la función debe devolver 1.
Escriba un algoritmo eficiente para las siguientes suposiciones:
• N es un número entero dentro del rango [1..100,000];
• cada elemento de la matriz A es un número entero dentro del rango [−1,000,000..1,000,000].
 */
namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            int[] enteros;
            Solucion sol = new Solucion();
            Console.WriteLine("Ingrese la cantidad de numeros que quiere ingresar:");
            bool conversion = Int32.TryParse(Console.ReadLine(), out cantidadNumeros);
                    if(!conversion || cantidadNumeros<1 || cantidadNumeros>100000){
                        do{
                        Console.WriteLine($"El dato ingresado no es valido. Solo se aceptan numeros enteros positivos menores a 100001."); 
                        Console.WriteLine("Ingrese la cantidad de numeros que quiere ingresar:");
                        conversion = Int32.TryParse(Console.ReadLine(), out cantidadNumeros);
                        }while(!conversion || cantidadNumeros<1 || cantidadNumeros>100000);
                    }

            enteros = new int[cantidadNumeros];

            for(int i=0; i<enteros.Length; i++){
                Console.WriteLine($"Ingrese un numero entero para la posicion {i+1}: ");
                bool conversion2 = Int32.TryParse(Console.ReadLine(), out enteros[i]);
                    if(!conversion2 || enteros[i]<-1000000 || enteros[i]>1000000){
                        do{
                        Console.WriteLine("El dato ingresado no es valido. Solo se aceptan numeros enteros del -1000000 al 1000000."); 
                        Console.WriteLine($"Ingrese un numero entero para la posicion {i+1}: ");
                        conversion2 = Int32.TryParse(Console.ReadLine(), out enteros[i]);
                        }while(!conversion2 || enteros[i]<-1000000 || enteros[i]>1000000);
                    }
            }

            int resultado = sol.DevolverElMenorEnteroPositivoQueNoOcurre(enteros);
            Console.WriteLine($"El entero positivo más pequeño que no fue registrado es: {resultado}");
        }
    }
}
