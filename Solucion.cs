namespace EJERCICIO_3{
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
    public class Solucion{

        public int DevolverElMenorEnteroPositivoQueNoOcurre(int[] array){
            
            int mayor = array[0]+1;

            for(int i=0; i<array.Length; i++){
                if(array[i]<100000){
                    if(array[i]>mayor){
                        mayor = array[i]+1;
                    }
                }
            }

            if(mayor<=0){
                return 1;
            }
            
            for(int i=1; i<mayor; i++){
                int similitud = 0;
                for(int j=0; j<array.Length; j++){
                    if(i==array[j]){
                        similitud++;
                    }
                    if(j==array.Length-1 && similitud == 0){
                        return i;
                    }
                }
            }

            return mayor;
        }
    }
}