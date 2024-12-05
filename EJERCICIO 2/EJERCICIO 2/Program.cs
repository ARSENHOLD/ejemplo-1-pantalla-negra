using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {



            int OPCION = 0;
            int SUPERIOR = 0;
            int INFERIOR = 0;
            int i,j;
            int ctadiv,ctapar=0,ctaimpar=0;
            double promediopar, promedioimpar;
            int sumapar=0;
            int sumaimpar = 0;

            while (OPCION != 5)
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO AL APLICATIVO");
                Console.WriteLine("1 LIMITE SUPERIOR");
                Console.WriteLine("2 LIMITE INFERIOR");
                Console.WriteLine("3 SUMA PAR Y IMPAR PROMEDIO");
                Console.WriteLine("4 MOSTRAR N° PRIMOS ");
                Console.WriteLine("5 SALIR");
                Console.WriteLine("INGRES SU OPCION");
                OPCION = Convert.ToInt32(Console.ReadLine());




                switch (OPCION)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("INGRES LIMITE SUPERIOR");
                        SUPERIOR = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("LIMITE SUPERIOR " + SUPERIOR);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("INGRES LIMITE INFERIOR");
                        INFERIOR = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("LIMITE INFERIOR " + INFERIOR);
                        
                        break;
                    case 3:
                        Console.Clear();
                        i = 0;
                        sumapar = 0;
                        sumaimpar = 0;
                        ctapar = 0;
                        ctaimpar = 0;

                        while (i <= SUPERIOR)
                        {
                            ctadiv = 0;
                            

                            for (j = 1; j <= i; j++)
                            {
                                
                                    if (i % 2 == 0)
                                    {
                                        ctadiv = ctadiv + 1;
                                    }
                                
                            }
                            if (2<=ctadiv)
                            {
                                if (INFERIOR <= i)
                                {
                                    Console.Write("par : ");
                                    Console.WriteLine(i);
                                    sumapar = sumapar + i;
                                    ctapar++;

                                }

                            }
                            else
                            {
                                if (INFERIOR <= i)
                                {
                                    Console.Write("impar : ");
                                    Console.WriteLine(i);
                                    sumaimpar = sumaimpar + i;
                                    ctaimpar++;
                                }
                            }
                            i++;
                        }
                        promediopar = sumapar / ctapar;
                        promedioimpar = sumaimpar / ctaimpar;

                        Console.WriteLine("suma total pares :" + sumapar);
                        Console.WriteLine("promedio pares :" + promediopar);
                        Console.WriteLine("suma total impares :" + sumaimpar);
                        Console.WriteLine("promedio impares :" + promedioimpar);
                       
                      
                        break;

                    case 4:
                        Console.Clear();
                        i = 0;
                        while (i <= SUPERIOR)
                        {
                            ctadiv = 0;
                            

                            for (j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    ctadiv = ctadiv + 1;
                                }
                            }
                            if (ctadiv == 2)
                            { if(INFERIOR<=i){
                                Console.WriteLine("primos");
                                Console.WriteLine(i);
                            }
                            }
                            i++;
                        }

                        break;




                }

                Console.ReadKey();
            }

        }
    }
}
