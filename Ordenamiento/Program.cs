/* 
Alixon Xiomara Sanchez Perdomo
Codigo: 213023
Ingenieria de Sistemas
Programacion
Cead-Ibague
2022-Noviembre
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ordenamiento
{
    class Program
    {
        //Atributos
        public int[] numeros = new int[10];
        public int numActual;


        public void Datos()
        {
            Console.WriteLine("Buen dia!, este es un programa que sera capaz de ordenar los numeros de menor a mayor");
            Console.WriteLine("===Ingrese 10 numeros aleatorios===");



            for (int x = 0; x < 10; x++)
            {
                Console.Write("\n ingrese cualquier valor para el numero " + (x+1) + " = ");
                numActual = int.Parse(Console.ReadLine());
                numeros[x] = numActual;

            }
        }

        public void metodoBurbuja()
        {
            int t;
            for (int a = 1; a < numeros.Length; a++)
                for (int b = numeros.Length - 1; b >= a; b--)
                {
                    if (numeros[b - 1] > numeros[b])
                    {
                        t = numeros[b - 1];
                        numeros[b - 1] = numeros[b];
                        numeros[b] = t;
                    }
                }


        }

        public void metodoShell()
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = numeros.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (numeros.Length - salto))
                    {
                        if (numeros[e - 1] > numeros[(e - 1) + salto])
                        {
                            auxi = numeros[(e - 1) + salto];
                            numeros[(e - 1) + salto] = numeros[e - 1];
                            numeros[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }

        public void metodoInsercion()
        {
            int auxili;
            int j;
            for (int i = 0; i <numeros.Length; i++)
            {
                auxili =numeros[i];
                j = i - 1;
                while (j >= 0 &&numeros[j] > auxili)
                {
                   numeros[j + 1] =numeros[j];
                    j--;
                }
               numeros[j + 1] = auxili;
            }
        }

        public void metodoSeleccion()
        {
            int menor, posicion, auxiliar;

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                menor = numeros[i];
                posicion = i;

                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[j] < menor)
                    {
                        menor = numeros[j];
                        posicion = j;
                    }
                }

                if (posicion != i)
                {
                    auxiliar = numeros[i];
                    numeros[i] = numeros[posicion];
                    numeros[posicion] = auxiliar;
                }
            }
        }

        void imprimir()
        {
            Console.WriteLine("Estos numeros estan ordenados de menor a mayor segun el metodo elegido  ");
            for (int y = 0; y < 10; y++)
            {
                
                Console.WriteLine(numeros[y] );
            }
        }

        void txt()
        {
            String Archivo = "D:\\Documentos\\Ordenamiento\\archivo.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Archivo))
            {
                for (int x = 0; x < 10; x++) 
                {
                    file.WriteLine(numeros[x]);
                }     
            }
        }
 
        static void Main(string[] args)
        {

        
            //Metodo constructor
            Program dto = new Program ();

            dto.Datos();

            //metros de ordenamiento
            Console.WriteLine("Metodo de ordenamiento a usar: ");
            Console.WriteLine("1) metodo de burbuja");
            Console.WriteLine("2) metodo de seleccion");
            Console.WriteLine("3) metodo de insercion");
            Console.WriteLine("4) metodo de shell");

            Console.WriteLine("\n ingrese la opcion del metodo ");
            int opmenu = int.Parse(Console.ReadLine());

            if (opmenu == 1 ) { dto.metodoBurbuja(); }
            if (opmenu == 2 ) { dto.metodoShell(); }
            if (opmenu == 3 ) { dto.metodoInsercion(); }
            if (opmenu == 4 ) { dto.metodoInsercion(); }

            dto.imprimir();
            dto.txt();

        }
    }
}
