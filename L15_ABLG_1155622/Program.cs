using System;
using System.ComponentModel.DataAnnotations;

namespace L15_ABLG_1155622
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] Nombre = new string[5];
            int[] Edad = new int[5];
            string[] Estudiante = new string[5];
            int[] notas= new int[5];
            string opcion;
            

            Console.WriteLine("Bienvenid@, tienes que seleccionar 1,2 o 3 para poder ejecutar el programa");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i <5; i++)
                    {
                        Console.WriteLine("Ingresa el nombre: ");
                        Nombre[i] = Console.ReadLine();

                        Console.WriteLine("Ingresa la edad: ");
                        Edad[i] = Convert.ToInt32(int.Parse(Console.ReadLine()));

 
                    }
                    int max = Edad[0];
                    
                    

                    for (int i = 0; i < Edad.Length; i++)
                    {

                        if (Edad[i] > max)
                        {
                            max = Edad[i];
                          
                            
                        }
                    }
                    Console.WriteLine("La mayor edad es de: " + max);
                    










                    double prom;
                    int sum = 0;
                    

                    for (int i = 0; i < Edad.Length; i++)
                    {

                        sum = sum + Edad[i];
                    }
                    
                    prom = sum / Edad.Length;
                    
                    Console.WriteLine("El promedio de las edades es de: " + prom);
                    break;

                case "2":
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingresa el nombre y apellido del estudiante: ");
                            Estudiante [i] = Console.ReadLine();

                            Console.WriteLine("Ingresa la nota del estudiante en el curso de introducción a la programación: ");
                            notas [i] = Convert.ToInt32(int.Parse(Console.ReadLine()));

                      
                        }
                        for (int i = 0; i < Edad.Length; i++)
                        {
                            if (notas[i] >= 71)
                            {
                                Console.WriteLine("Aprobó: " + Estudiante[i]);
                            }else
                            {
                                Console.WriteLine("Reprobó: " + Estudiante[i]);
                            }
                        }
                        
                        double prome;
                        int suma = 0;

                        for (int i = 0; i < Edad.Length; i++)
                        {
                     

                            suma = suma + notas[i];
                        }
                        

                        prome = suma / Edad.Length;

                        Console.WriteLine("El promedio de las edades es de: " + prome);

                        int Max = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] > Max)
                            {
                                Max = notas[i];
                            }
                            
                        }
                        Console.WriteLine("La nota más alta es: " + Max);

                        int min = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i]<min)
                            {
                                min = notas[i];
                            }

                        }
                        Console.WriteLine("La nota más baja es: " + min);

                        
                        


                        break;

                       
                    }

                case "3":
                    {
                        Environment.Exit(0);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Solo se aceptan los nùmero 1,2 o 3");
                    }
                    break;
            }


        }

    }

}
